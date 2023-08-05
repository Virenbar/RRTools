using RR.Core.Properties;
using System.Security.Cryptography.X509Certificates;

namespace RR.Core
{
    public class CertificateStore
    {
        private static readonly X509Certificate2 Publisher = new(Resources.russian_trusted_sub_ca);
        private static readonly X509Certificate2 Root = new(Resources.russian_trusted_root_ca);
        private readonly StoreLocation location;

        private CertificateStore(StoreLocation location)
        {
            this.location = location;
        }

        public static CertificateStore MachineStore() => new(StoreLocation.LocalMachine);

        public static CertificateStore UserStore() => new(StoreLocation.CurrentUser);

        public void InstallCertificate()
        {
            InstallCertificate(StoreName.Root, Root);
            InstallCertificate(StoreName.TrustedPublisher, Publisher);
        }

        public bool Installed()
        {
            return Installed(StoreName.Root, Root)
                && Installed(StoreName.TrustedPublisher, Publisher);
        }

        public void RemoveCertificate()
        {
            RemoveCertificate(StoreName.Root, Root);
            RemoveCertificate(StoreName.TrustedPublisher, Publisher);
        }

        private void InstallCertificate(StoreName storeName, X509Certificate2 certificate)
        {
            using X509Store store = new(storeName, location);
            store.Open(OpenFlags.ReadWrite);
            store.Add(certificate);
        }

        private bool Installed(StoreName storeName, X509Certificate2 certificate)
        {
            using X509Store store = new(storeName, location);
            store.Open(OpenFlags.ReadOnly);
            return store.Certificates.Find(X509FindType.FindByThumbprint, certificate.Thumbprint, true).Count > 0;
        }

        private void RemoveCertificate(StoreName storeName, X509Certificate2 certificate)
        {
            using X509Store store = new(storeName, location);
            store.Open(OpenFlags.ReadWrite);
            store.Remove(certificate);
        }
    }
}