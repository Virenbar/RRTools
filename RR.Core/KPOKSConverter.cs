using RR.Core.Properties;
using SelectPdf;
using System.Xml.Xsl;

namespace RR.Core
{
    public class KPOKSConverter
    {
        private readonly HtmlToPdf Converter = new();
        private readonly XslCompiledTransform Transform = new();

        public KPOKSConverter()
        {
            var Settings = new XsltSettings(true, true);
            var rr = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
            using var reader = XmlReader.Create(new StringReader(Resources.Common), rr);
            Transform.Load(reader, Settings, new XmlUrlResolver());
            Converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            Converter.Options.PdfPageSize = PdfPageSize.A4;
            Converter.Options.PageBreaksEnhancedAlgorithm = true;
        }

        public void TransformXMLtoHTML(string inputXML, string outputHTML)
        {
            Transform.Transform(inputXML, outputHTML);
        }

        public void TransformXMLtoPDF(string inputXML, string outputPDF)
        {
            using var SW = new StringWriter();
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