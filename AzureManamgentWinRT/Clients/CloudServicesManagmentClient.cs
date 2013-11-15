using AzureManamgentWinRT.Clients.CloudServicesOperationResults;
using AzureManamgentWinRT.Clients.Helper;
using AzureManamgentWinRT.Model.CloudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients
{
    /// <summary>
    /// Operations on Cloudservices
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169559.aspx
    /// </summary>
    public class CloudServicesManagmentClient : ManagmentClientBase
    {
        /// <summary>
        /// Add an extnsion to 
        /// an existing cloud serice.
        /// </summary>
        private const string addExtensionOperation = "/services/hostedservices/{0}/extensions";

        public async Task<AddCloudServiceExtensionOperationResult> AddExtensionAsync(string cloudService, CloudServiceExtension extension)
        {
            if (string.IsNullOrEmpty(cloudService) || string.IsNullOrWhiteSpace(cloudService))
            {
                return new AddCloudServiceExtensionOperationResult()
                {
                    AsyncException = null,
                    Message = "The name of the cloud service cannot be empty or null. Please check the parameter cloudService",
                    Successfull = false
                };
            }

            if (extension == null)
            {
                return new AddCloudServiceExtensionOperationResult()
                {
                    AsyncException = null,
                    Message = "The cloud-extension you want to add to your servcie cannot be null. Please check the parameter extension",
                    Successfull = false
                };
            }

            try
            {
                var postData = SerializationHelper.DataContractSerialize(extension);

                var extOp = string.Format(addExtensionOperation, cloudService);

                this.InitHttpClient(extOp);

                var content = new StringContent(postData);

                var message = await this.client.PostAsync(this.apiOperationUri, content);

                if (!message.IsSuccessStatusCode)
                {
                    return new AddCloudServiceExtensionOperationResult()
                    {
                        AsyncException = null,
                        Message = string.Format("The aAddExtensionAsync method could not post successfully to Azure. Reason {0}", message.ReasonPhrase),
                        Successfull = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new AddCloudServiceExtensionOperationResult()
                {
                    AsyncException = ex,
                    Message = string.Format("An error occured during the execution of AddExtensionAsync for cloud serivce {0}. Please see the AsyncException for further details.", cloudService),
                    Successfull = false
                };
                
            }

            return new AddCloudServiceExtensionOperationResult()
            {
                AsyncException = null,
                Message = string.Format("Successfully added extension type {0} to cloud service {1}", extension.Type, cloudService),
                Successfull = true
            };
        }
    }
}