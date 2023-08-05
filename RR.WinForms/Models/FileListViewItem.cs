namespace RR.WinForms.Models
{
    internal class FileListViewItem : ListViewItem
    {
        public FileListViewItem(FileInfo file) : base(file.Name)
        {
            File = file;
            SubItems.Add("");
        }

        public FileInfo File { get; }

        public string Result
        {
            get => SubItems[1].Text;
            set => SubItems[1].Text = value;
        }
    }
}