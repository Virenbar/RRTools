using System.Text.RegularExpressions;
using System.Xml.Xsl;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace RR.Core
{
    public class XMLConverter
    {
        private readonly XsltSettings Settings = new(true, true);
        private readonly XslCompiledTransform Transform = new();
        private readonly XmlReaderSettings XMLR = new() { DtdProcessing = DtdProcessing.Parse };

        public XMLConverter()
        {
        }

        public void SaveToHTML(string inputXML, string outputHTML)
        {
            var HTML = TransformToHTML(inputXML);
            File.WriteAllText(outputHTML, HTML);
        }

        public void SaveToPDF(string inputXML, string outputPDF)
        {
            var HTML = TransformToHTML(inputXML);
            var PDF = PdfGenerator.GeneratePdf(HTML, PdfSharp.PageSize.A4);
            PDF.Save(outputPDF);
        }

        private string TransformToHTML(string inputXML)
        {
            XmlDocument document = new();
            document.Load(inputXML);
            var pi = document.SelectSingleNode("processing-instruction('xml-stylesheet')");
            if (pi is null) { throw new Exception("Не указана ссылка на шаблон"); }
            var URI = Regex.Match(pi.Value!, @"href=""(.+)""").Groups[1].Value;

            using var reader = XmlReader.Create(URI, XMLR);
            using var writer = new StringWriter();
            Transform.Load(reader, Settings, new XmlUrlResolver());
            Transform.Transform(inputXML, null, writer);

            var HTML = writer.ToString();
            HTML = HTML.Replace(@"rowspan=""0""", @"rowspan=""1""");
            return HTML;
        }
    }
}