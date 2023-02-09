using Microsoft.Win32;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.Net.Security;
using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Xsl;

namespace RR.Core
{
    public class XMLConverter : IDisposable
    {
        private const string ChromeKey = @"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command";
        private readonly PdfOptions PDFConfig = new() { Format = PaperFormat.A4 };
        private readonly XsltSettings Settings = new(true, true);
        private readonly XslCompiledTransform Transform = new();
        private readonly XmlReaderSettings XMLR = new() { DtdProcessing = DtdProcessing.Parse };
        private IBrowser Browser;

        public XMLConverter()
        {
            EnableSSL();
        }

        public static bool ChromeInstalled => Registry.GetValue(ChromeKey, null, null) is string;

        public static void DisableSSL()
        {
            ServicePointManager.ServerCertificateValidationCallback = null;
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(SkipCertificate);
        }

        public static void EnableSSL()
        {
            ServicePointManager.ServerCertificateValidationCallback = null;
        }

        public async Task PrepareBrowser()
        {
            var Options = new LaunchOptions
            {
                Headless = true,
                WebSocketFactory = async (uri, socketOptions, cancellationToken) =>
                {
                    var client = SystemClientWebSocket.CreateClientWebSocket();
                    if (client is System.Net.WebSockets.Managed.ClientWebSocket managed)
                    {
                        managed.Options.KeepAliveInterval = TimeSpan.FromSeconds(0);
                        await managed.ConnectAsync(uri, cancellationToken);
                    }
                    else
                    {
                        var coreSocket = client as ClientWebSocket;
                        coreSocket.Options.KeepAliveInterval = TimeSpan.FromSeconds(0);
                        await coreSocket.ConnectAsync(uri, cancellationToken);
                    }
                    return client;
                }
            };
            if (Registry.GetValue(ChromeKey, null, null) is string command)
            {
                var Command = command.Split('\"');
                Options.ExecutablePath = Command.Length >= 2 ? Command[1] : null;
            }
            else
            {
                using var browserFetcher = new BrowserFetcher();
                await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
            }
            Browser = await Puppeteer.LaunchAsync(Options);
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
            using var Page = await Browser.NewPageAsync();
            await Page.SetContentAsync(HTML);
            await Page.PdfAsync(outputPDF, PDFConfig);
            await Page.CloseAsync();
        }

        private static bool SkipCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors) => true;

        private string TransformToHTML(string inputXML)
        {
            XmlDocument XML = new();
            XML.Load(inputXML);
            var PI = XML.SelectSingleNode("processing-instruction('xml-stylesheet')");
            if (PI is null) { throw new Exception("Не указана ссылка на шаблон"); }
            var URI = Regex.Match(PI.Value!, @"href=""(.+)""").Groups[1].Value;

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