namespace RR.WinForms.Models
{
    internal class FileListViewItem : ListViewItem
    {
        public FileListViewItem(FileInfo file)
        {
            File = file;
            SubItems[0].Text = file.Name;
        }

        public FileInfo File { get; }
    }
}