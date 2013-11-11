using AzureManamgentWinRT.ErrorHandling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Security.Cryptography.Certificates;
using Windows.Storage;
using Windows.Storage.Streams;

namespace AzureManamgentWinRT.Credentials
{
    /// <summary>
    /// Certificate credentials.
    /// You can authenticate your app
    /// against Azure loading existing
    /// importing pfx
    /// files.
    /// </summary>
    public class CertificateCredentials
    {
        private StorageFile manamgentCertificate;

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCredentials" /> class.
        /// </summary>
        public CertificateCredentials(StorageFile pfxFile)
        {
            if (pfxFile == null)
            {
                throw new ArgumentException("PFX storage file cannot be null.", "pfxFile");
            }
                                                
            this.manamgentCertificate = pfxFile;
        }

        /// <summary>
        /// Initializes the credentials.
        /// </summary>
        /// <param name="credentialIdentifier">The credential identifier.</param>
        /// <param name="credentialPassword">The credential password.</param>
        /// <returns></returns>
        public async Task<AsyncExecutionResult> InitializeCredentials(string credentialIdentifier, string credentialPassword)
        {
            if (string.IsNullOrEmpty(credentialIdentifier) || string.IsNullOrWhiteSpace(credentialIdentifier))
            {
                return new AsyncExecutionResult()
                {
                    Successfull = false,
                    Message = "Parameter error.", AsyncException =
                        new ArgumentException("Identifier cannot be null or empty.", "credentialIdentifier")
                };
            }

            if (string.IsNullOrEmpty(credentialPassword) || string.IsNullOrWhiteSpace(credentialPassword))
            {
                return new AsyncExecutionResult()
                {
                    Successfull = false,
                    Message = "Parameter error.",
                    AsyncException =
                        new ArgumentException("Identifier cannot be null or empty.", "credentialIdentifier")
                };
            }

            IBuffer content = null;
            
            try
            {
                content = await Windows.Storage.FileIO.ReadBufferAsync(manamgentCertificate);
            }
            catch (FileNotFoundException ex)
            {
                return new AsyncExecutionResult() { Successfull = false, Message = "Error occured trying to read the pfx file.", AsyncException = ex };
            }

            try
            {
                string base64Encoded = Windows.Security.Cryptography.CryptographicBuffer.EncodeToBase64String(content);

                await CertificateEnrollmentManager.ImportPfxDataAsync(
                    base64Encoded,
                    credentialPassword,
                    ExportOption.NotExportable,
                    KeyProtectionLevel.NoConsent,
                    InstallOptions.None,
                    credentialIdentifier);
              
            }
            catch (Exception ex)
            {
                return new AsyncExecutionResult() { Successfull = false, Message = "Error during pfx import occurred", AsyncException = ex };
            }

            return new AsyncExecutionResult()
            {
                Successfull = true,
                Message = "Sucess. Pfx importet into local app store.",
                AsyncException = null
            };
        }
    }
}