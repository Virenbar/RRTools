using RR.Core;
using RR.WinForms.Properties;
using System.Text.RegularExpressions;

namespace RR.WinForms
{
    public partial class FormMain : Form
    {
        private readonly DirectoryInfo HTMLOutput = new("HTML");
        private readonly DirectoryInfo PDFOutput = new("PDF");
        private readonly DirectoryInfo XMLInput = new("XML");
        private readonly FileSystemWatcher XMLWatcher;
        private List<FileInfo> XMLFiles = new();

        public FormMain()
        {
            InitializeComponent();
            DataBindings.Add("BackColor", Settings.Default, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            DataBindings.Add("ForeColor", Settings.Default, "ForeColor", true, DataSourceUpdateMode.OnPropertyChanged);

            if (!XMLInput.Exists) { XMLInput.Create(); }
            XMLWatcher = new(XMLInput.FullName)
            {
                SynchronizingObject = this,
                IncludeSubdirectories = true
            };
            XMLWatcher.Changed += (object sender, FileSystemEventArgs e) => RefreshList();
            XMLWatcher.Deleted += (object sender, FileSystemEventArgs e) => RefreshList();
            XMLWatcher.Renamed += (object sender, RenamedEventArgs e) => RefreshList();
            XMLWatcher.EnableRaisingEvents = true;
            RefreshList();
        }

        private void B_PDFConvert_Click(object sender, EventArgs e)
        {
            if (XMLFiles.Count == 0) { return; }
            var ToPDF = false;

            var Converter = new XMLConverter();
            foreach (var file in XMLFiles)
            {
                var HTMLPath = Path.Combine(HTMLOutput.FullName, Path.GetRelativePath(XMLInput.FullName, file.FullName));
                HTMLPath = HTMLPath.Replace(file.Extension, ".html");
                var HTML = new FileInfo(HTMLPath);
                Directory.CreateDirectory(HTML.DirectoryName);
                Converter.SaveToHTML(file.FullName, HTML.FullName);
            }
            return;
            foreach (var file in XMLFiles)
            {
                var PDFPath = Path.Combine(PDFOutput.FullName, Path.GetRelativePath(XMLInput.FullName, file.FullName));
                PDFPath = PDFPath.Replace(file.Extension, ".pdf");
                var PDF = new FileInfo(PDFPath);
                Directory.CreateDirectory(PDF.DirectoryName);
                Converter.SaveToPDF(file.FullName, PDF.FullName);
            }
        }

        private void RefreshList()
        {
            XMLFiles = XMLInput.GetFiles("*.xml", SearchOption.AllDirectories).ToList();
            RefreshUI();
        }

        private void RefreshUI()
        {
            label1.Text = Regex.Replace(label1.Text, @"\d+", $"{XMLFiles.Count}");
        }
    }
}