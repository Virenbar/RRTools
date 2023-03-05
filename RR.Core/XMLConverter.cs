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
            ServicePointManager.ServerCertificateValidationCallback = null;
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ServerCertificateValidationCallback);
            //HttpClientHandler.ServerCertificateCustomValidationCallback += new RemoteCertificateValidationCallback(ServerCertificateValidationCallback);
        }

        static XMLConverter()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ServerCertificateValidationCallback);
        }

        public static bool ChromeInstalled => Registry.GetValue(ChromeKey, null, null) is string;

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

        private static bool ServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            String rootCAThumbprint = ""; // write your code to get your CA's thumbprint

            // remove this line if commercial CAs are not allowed to issue certificate for your service.
            if (sslPolicyErrors == SslPolicyErrors.None) { return true; }

            if (
                (sslPolicyErrors & (SslPolicyErrors.RemoteCertificateNameMismatch)) > 0 ||
                (sslPolicyErrors & (SslPolicyErrors.RemoteCertificateNotAvailable)) > 0
            ) { return false; }
            // get last chain element that should contain root CA certificate
            // but this may not be the case in partial chains
            X509Certificate2 projectedRootCert = chain.ChainElements[chain.ChainElements.Count - 1].Certificate;
            if (projectedRootCert.Thumbprint != rootCAThumbprint)
            {
                return false;
            }
            // execute certificate chaining engine and ignore only "UntrustedRoot" error
            X509Chain customChain = new X509Chain
            {
                ChainPolicy = {
                    VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority
                }
            };
            Boolean retValue = customChain.Build(chain.ChainElements[0].Certificate);
            // RELEASE unmanaged resources behind X509Chain class.
            customChain.Reset();
            return retValue;
        }

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