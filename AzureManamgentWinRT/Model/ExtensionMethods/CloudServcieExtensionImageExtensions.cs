using System;
using System.Text;
using AzureManamgentWinRT.Model.CloudServices;
using AzureManamgentWinRT.Clients.Helper;
using AzureManamgentWinRT.Models.ConfDiag.Public;

namespace AzureManamgentWinRT.Model.ExtensionMethods
{
    /// <summary>
    /// Extensions for the CloudserviceExtensionImages class.
    /// </summary>
    public static class CloudServcieExtensionImageExtensions
    {
        
        /// <summary>
        /// Clouds the service extension image2 cloud service extension.
        /// </summary>
        /// <param name="cloudExtensionImage">The cloud extension image.</param>
        /// <param name="thumbPrint">The thumb print.</param>
        /// <param name="thumbAlgorithm">The thumb algorithm.</param>
        /// <param name="thumbConfigSchema">The thumb config schema.</param>
        /// <param name="configSchemaPrivate">The config schema private.</param>
        /// <returns></returns>
        public static CloudServiceExtension CloudServiceExtensionImage2CloudServiceExtension(this CloudServiceExtensionImage cloudExtensionImage,
            string thumbPrint = null, string thumbAlgorithm = null, string thumbConfigSchema = null, string configSchemaPrivate = null)
        {
            CloudServiceExtension ext = new CloudServiceExtension();


            if (cloudExtensionImage.Type.Equals("RDP"))
            {
                ext.Id = "RDP-" + Guid.NewGuid().ToString();
            }

            if (cloudExtensionImage.Type.Equals("Diagnostics"))
            {
                ext.Id = "Diagnostics-" + Guid.NewGuid().ToString();
            }
                      

            if (configSchemaPrivate != null)
            {
                ext.PrivateConfiguration = cloudExtensionImage.PrivateConfigurationSchema;
            }

            ext.ProviderNameSpace = cloudExtensionImage.ProviderNameSpace;

            if (thumbConfigSchema != null)
            {
                ext.PublicConfiguration = cloudExtensionImage.PublicConfigurationSchema; 
            }

            if (thumbAlgorithm != null)
            {
                ext.ThumbPrintAlgorithm = cloudExtensionImage.ThumbprintAlgorithm; 
            }

            if (thumbPrint != null)
            {
                ext.Thumbprint = thumbPrint;
            }

            ext.Type = cloudExtensionImage.Type;
            
            ext.Thumbprint = null;

            return ext;
        }
        
        
        /// <summary>
        /// Serialize a public diagnostics configuration for a cloud service extension
        /// and convert it to a base64 string. The value will be assigned to your
        /// current CloudServiceExtension instance, propert PublicConfiguration.
        /// </summary>
        /// <param name="extension">The service extension</param>
        /// <param name="config">The public configuration for a diagnostics extension</param>
        public static async void  DiagnosticsPublicConfiguration2Base64(this CloudServiceExtension extension, PublicDiagnosticsConfig config)
        {
            try
            {
                var serialized = await SerializationHelper.DataContractSerializerFragment<PublicDiagnosticsConfig>(config);

                if (serialized != null)
                {
                    var bas64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));

                    extension.PublicConfiguration = bas64Encoded;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Serialize a private diagnostics configuration for a cloud service extension
        /// and convert it to a base64 string. The value will be assigned to your
        /// current CloudServiceExtension instance, propert PrivateConfiguration.
        /// </summary>
        /// <param name="extension">The service extension</param>
        /// <param name="config">The public configuration for a diagnostics extension</param>
        public static async void DiagnosticsPrivateConfiguration2Base64(this CloudServiceExtension extension, AzureManamgentWinRT.Models.ConfDiag.Private.PrivateConfig config )
        {
            try
            {
                var serialized = await SerializationHelper.DataContractSerializerFragment<AzureManamgentWinRT.Models.ConfDiag.Private.PrivateConfig>(config);

                if (serialized != null)
                {
                    var bas64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));

                    extension.PrivateConfiguration = bas64Encoded;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        /// <summary>
        /// Serialize a public RDP configuration for a cloud service extension
        /// and convert it to a base64 string. The value will be assigned to your
        /// current CloudServiceExtension instance, propert PrivateConfiguration.
        /// </summary>
        /// <param name="extension">The service extension</param>
        /// <param name="config">The public configuration for a RDP extension</param>
        public static async void RDPPublicConfiguration2Base64(this CloudServiceExtension extension,AzureManamgentWinRT.Models.ConfRDP.Public.PublicConfig config)
        {
            try
            {
                var serialized = await SerializationHelper.DataContractSerializerFragment<AzureManamgentWinRT.Models.ConfRDP.Public.PublicConfig>(config);

                if (serialized != null)
                {
                    var bas64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));

                    extension.PrivateConfiguration = bas64Encoded;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Serialize a private RDP configuration for a cloud service extension
        /// and convert it to a base64 string. The value will be assigned to your
        /// current CloudServiceExtension instance, propert PrivateConfiguration.
        /// </summary>
        /// <param name="extension">The service extension</param>
        /// <param name="config">The private configuration for a RDP extension</param>
        public static async void RDPPrivateConfiguration2Base64(this CloudServiceExtension extension, AzureManamgentWinRT.Models.ConfRDP.Private.PrivateConfig config)
        {
            try
            {
                var serialized = await SerializationHelper.DataContractSerializerFragment<AzureManamgentWinRT.Models.ConfRDP.Private.PrivateConfig>(config);

                if (serialized != null)
                {
                    var bas64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));

                    extension.PrivateConfiguration = bas64Encoded;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
