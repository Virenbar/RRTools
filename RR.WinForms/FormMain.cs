using RR.Core;
using RR.WinForms.Properties;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RR.WinForms
{
    public partial class FormMain : Form
    {
        private readonly DirectoryInfo Output = new("Output");
        private readonly HashSet<FileInfo> XMLFiles = new();

        public FormMain()
        {
            InitializeComponent();
            DataBindings.Add("BackColor", Settings.Default, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            DataBindings.Add("ForeColor", Settings.Default, "ForeColor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void B_PDFConvert_Click(object sender, EventArgs e)
        {
            if (XMLFiles.Count == 0) { return; }
            var ToPDF = false;

            var Converter = new XMLConverter();
            foreach (var file in XMLFiles)
            {
                var OutPath = Path.Combine(Output.FullName, file.FullName);
                var HTMLPath = OutPath.Replace(file.Extension, ".html");
                var PDFPath = OutPath.Replace(file.Extension, ".pdf");
                Directory.CreateDirectory(Output.FullName);
                if (ToPDF)
                {
                    var PDF = new FileInfo(PDFPath);
                    Converter.SaveToPDF(file.FullName, PDF.FullName);
                }
                else
                {
                    var HTML = new FileInfo(HTMLPath);
                    Converter.SaveToHTML(file.FullName, HTML.FullName);
                }
            }
        }

        private void RefreshList()
        {
            //XMLFiles = XMLInput.GetFiles("*.xml", SearchOption.AllDirectories).ToList();
            //label1.Text = Regex.Replace(label1.Text, @"\d+", $"{XMLFiles.Count}");
        }

        private void RefreshUI()
        {
        }

        #region UIEvents

        private void B_OpenOut_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Output.FullName);
            Process.Start("explorer.exe", Output.FullName);
        }

        private void LV_Files_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null) { return; }
            var Files = ((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void LV_Files_DragEnter(object sender, DragEventArgs e) => ProcessDrag(e);

        private static void ProcessDrag(DragEventArgs e)
        {
            var Effect = DragDropEffects.None;
            if (e.Data is null) { return; }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var Files = ((string[])e.Data.GetData(DataFormats.FileDrop)).Take(5);
                Files = Files.Where(F =>
                File.Exists(F) ||
                F.EndsWith(".xml")
                );
                if (Files.Any())
                {
                    Effect = DragDropEffects.Link;
                }
            }
            e.Effect = Effect;
        }

        private void LV_Files_DragOver(object sender, DragEventArgs e) => ProcessDrag(e);

        #endregion UIEvents
    }
}