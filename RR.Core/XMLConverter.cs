using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.Text.RegularExpressions;
using System.Xml.Xsl;

namespace RR.Core
{
    public class XMLConverter : IDisposable
    {
        private readonly PdfOptions PDFConfig = new() { Format = PaperFormat.A4 };
        private readonly XsltSettings Settings = new(true, true);
        private readonly XslCompiledTransform Transform = new();
        private readonly XmlReaderSettings XMLR = new() { DtdProcessing = DtdProcessing.Parse };
        private IBrowser? Browser;

        public XMLConverter()
        { }

        public async Task PrepareBrowser()
        {
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
            Browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
        }

        public void SaveAsHTML(string inputXML, string outputHTML)
        {
            var HTML = TransformToHTML(inputXML);
            File.WriteAllText(outputHTML, HTML);
        }

        public async Task SaveAsPDF(string inputXML, string outputPDF, PDFOrientation orientation)
        {
            if (Browser is null) { throw new Exception("Браузер не инициализирован"); }

            PDFConfig.Landscape = orientation switch
            {
                PDFOrientation.Album => true,
                PDFOrientation.Book => false,
                _ => throw new NotImplementedException()
            };
            var HTML = TransformToHTML(inputXML);
            var Page = await Browser.NewPageAsync();
            await Page.SetContentAsync(HTML);
            await Page.PdfAsync(outputPDF, PDFConfig);
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

        #region IDisposable

        public void Dispose() => Browser?.Dispose();

        #endregion IDisposable
    }
}