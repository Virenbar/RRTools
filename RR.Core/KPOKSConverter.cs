using System.Xml.Xsl;
using System.Xml;
using SelectPdf;
using RR.Core.Properties;

namespace RR.Core
{
    public class KPOKSConverter
    {
        private readonly XslCompiledTransform Transform = new();
        private readonly HtmlToPdf Converter = new();

        public KPOKSConverter()
        {
            var Settings = new XsltSettings(true, true);
            var rr = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
            using var reader = XmlReader.Create(new StringReader(Resources.Common), rr);
            Transform.Load(reader, Settings, new XmlUrlResolver());
        }

        public void TransformXMLtoPDF(string inputXML, string outputPDF)
        {
            var SW = new StringWriter();
            //var results = new StreamWriter(memoryStream);
            //Transform.Transform(inputXML, null, results);
            Transform.Transform(inputXML, null, SW);
            var HTML = SW.ToString();
            var PDF = Converter.ConvertHtmlString(HTML);
            PDF.Save(outputPDF);
            PDF.Close();
        }
    }
}