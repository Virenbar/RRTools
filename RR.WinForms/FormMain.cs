using GDPIControl;
using RR.Core;
using RR.WinForms.Models;
using RR.WinForms.Properties;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;

namespace RR.WinForms
{
    public partial class FormMain : Form
    {
        private readonly DirectoryInfo Output = new("Output");
        private readonly CertificateStore Store = CertificateStore.UserStore();
        private readonly Dictionary<string, FileInfo> XMLFiles = new();

        public FormMain()
        {
            InitializeComponent();
            DataBindings.Add("BackColor", Settings.Default, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            DataBindings.Add("ForeColor", Settings.Default, "ForeColor", true, DataSourceUpdateMode.OnPropertyChanged);
            Icon = Resources.RR_Icon;
            Text += $" v{Application.ProductVersion}";
        }

        private async void B_PDFConvert_Click(object sender, EventArgs e)
        {
            if (XMLFiles.Count == 0) { return; }
            try
            {
                UIState(false);
                await Convert();
            }
            finally
            {
                UIState(true);
            }
        }

        private async Task Convert()
        {
            var IsPDF = RB_PDF.Checked;
            var Orientation = RB_Album.Checked ? PDFOrientation.Album : PDFOrientation.Book;
            var Count = 1;
            using var Converter = new XMLConverter();
            if (IsPDF)
            {
                var M = "На компьютере не обнаружен Google Chrome. Будет скачана портативная версия Chromium.(~200 МБ)\nПродолжить?";
                if (!XMLConverter.ChromeInstalled && MessageBox.Show(M, "Скачать Chromium", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                SL_Status.Text = "Подготовка браузера";
                await Converter.PrepareBrowser();
            }

            foreach (FileListViewItem item in LV_Files.Items)
            {
                SL_Status.Text = $"Конвертация файлов: {Count++}";
                try
                {
                    var File = item.File;
                    var OutPath = Path.Combine(Output.FullName, File.Name);
                    Directory.CreateDirectory(Output.FullName);
                    OutPath = OutPath.Replace(File.Extension, IsPDF ? ".pdf" : ".html");
                    var OutFile = new FileInfo(OutPath);
                    var ConvertTask = IsPDF
                         ? Converter.SaveAsPDF(File.FullName, OutFile.FullName, Orientation)
                         : Task.Run(() => Converter.SaveAsHTML(File.FullName, OutFile.FullName));
                    await ConvertTask;

                    item.BackColor = Color.LightGreen;
                    item.Result = "Файл конвертирован";
                }
                catch (Exception e)
                {
                    item.BackColor = Color.MistyRose;
                    item.Result = $"Ошибка: {e.Message}";
                }
            }
            SL_Status.Text = "Конвертация завершена";
        }

        private void RefreshList()
        {
            var style = XMLFiles.Count > 0
                ? ColumnHeaderAutoResizeStyle.ColumnContent
                : ColumnHeaderAutoResizeStyle.HeaderSize;

            LV_Files.BeginUpdate();
            LV_Files.Items.Clear();
            LV_Files.Items.AddRange(XMLFiles.Select((KV) => new FileListViewItem(KV.Value)).ToArray());
            LV_Files.AutoResizeColumn(0, style);
            LV_Files.EndUpdate();
            SL_Count.Text = Regex.Replace(SL_Count.Text, @"\d+", $"{XMLFiles.Count}");
        }

        private void RefreshUI()
        {
            var installed = Store.Installed();
            MI_InstallCertificate.Enabled = !installed;
            MI_RemoveCertificate.Enabled = installed;
        }

        private void UIState(bool state)
        {
            B_Convert.Enabled = state;
            SB_Add.Enabled = state;
            SB_Delete.Enabled = state;
            LV_Files.AllowDrop = state;
        }

        #region UIEvents

        private static void ProcessDrag(DragEventArgs e)
        {
            var Effect = DragDropEffects.None;
            if (e.Data is null) { return; }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var Paths = ((string[])e.Data.GetData(DataFormats.FileDrop)).Take(5);
                Paths = Paths.Where(F => Directory.Exists(F) || F.EndsWith(".xml"));
                if (Paths.Any())
                {
                    Effect = DragDropEffects.Link;
                }
            }
            e.Effect = Effect;
        }

        private void B_OpenOut_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Output.FullName);
            Process.Start("explorer.exe", Output.FullName);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshUI();
            RefreshList();
        }

        private void LV_Files_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null) { return; }
            var Paths = ((string[])e.Data.GetData(DataFormats.FileDrop)).AsEnumerable();
            Paths = Paths.Where(F => Directory.Exists(F) || F.EndsWith(".xml"));
            foreach (var Path in Paths)
            {
                if (Directory.Exists(Path))
                {
                    var Files = Directory.GetFiles(Path, "*.xml", SearchOption.AllDirectories).Select(F => new FileInfo(F));
                    foreach (var File in Files) { XMLFiles[File.Name] = File; }
                }
                else
                {
                    var File = new FileInfo(Path);
                    XMLFiles[File.Name] = File;
                }
            }
            RefreshList();
        }

        private void LV_Files_DragEnter(object sender, DragEventArgs e) => ProcessDrag(e);

        private void LV_Files_DragOver(object sender, DragEventArgs e) => ProcessDrag(e);

        private void MI_About_Click(object sender, EventArgs e)
        {
            var F = new FormAbout();
            F.ShowDialog(this);
        }

        private void MI_InstallCertificate_Click(object sender, EventArgs e)
        {
            Store.InstallCertificate();
            RefreshUI();
        }

        private void MI_RemoveCertificate_Click(object sender, EventArgs e)
        {
            Store.RemoveCertificate();
            RefreshUI();
        }

        private void RB_PDF_CheckedChanged(object sender, EventArgs e) => FLP_Orientation.Enabled = RB_PDF.Checked;

        private void SB_Add_Click(object sender, EventArgs e)
        {
            using var F = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "XML файлы (*.xml)|*.xml",
                Multiselect = true
            };
            if (F.ShowDialog(this) != DialogResult.OK) { return; }

            foreach (var File in F.FileNames)
            {
                var FI = new FileInfo(File);
                XMLFiles[FI.Name] = FI;
            }
            RefreshList();
        }

        private void SB_Delete_Click(object sender, EventArgs e)
        {
            foreach (FileListViewItem Item in LV_Files.SelectedItems)
            {
                XMLFiles.Remove(Item.File.Name);
            }
            RefreshList();
        }

        #endregion UIEvents
    }
}