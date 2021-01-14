using Org.BouncyCastle.X509;

namespace ARSoft.Tools.Net
{
    public class DotNetUtilities
    {
        public static X509Certificate FromX509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate x509Cert)
        {
            return new X509CertificateParser().ReadCertificate(x509Cert.GetRawCertData());
        }

    }
}
