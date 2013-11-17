using System;
using AzureManamgentWinRT.Model.CloudServices;

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
        
    }
}
