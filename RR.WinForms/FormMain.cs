using RR.Core;

namespace RR.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Converter = new KPOKSConverter();
            Converter.TransformXMLtoPDF("kv_5ef7503e-6d15-4ec5-b500-ffcb0ab9206f.xml", "kv_5ef7503e-6d15-4ec5-b500-ffcb0ab9206f.pdf");
        }
    }
}