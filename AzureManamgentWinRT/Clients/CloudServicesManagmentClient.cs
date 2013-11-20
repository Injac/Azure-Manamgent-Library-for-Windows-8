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

        /// <summary>
        /// Lis all available cloud extensions.
        /// </summary>
        private const string listAvailableExtensionsOperation = "/services/extensions";


        private const string changeDeploymentDeploymentSlot = "/services/hostedservices/{0}>/deploymentslots/{1}?comp=config ";

        private const string changeDeploymentDeploymentName = "/services/hostedservices/{0}>/deployments/{1}?comp=config ";
       
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudServicesManagmentClient" /> class.
        /// </summary>
        /// <param name="subscriptionId">The subscription id.</param>
        public CloudServicesManagmentClient(string subscriptionId)
        {
            if (string.IsNullOrEmpty(subscriptionId) || string.IsNullOrWhiteSpace(subscriptionId))
            {
                throw new ArgumentException("Subscription id cannot be null or empty.", "subscriptionId");
            }

            Guid id;
            
            var isGuid = Guid.TryParse(subscriptionId, out id);

            if (!isGuid)
            {
                throw new ArgumentException("Subscription format unknown.", "subscriptionId");
            }

            this.subscriptionId = subscriptionId;
        }

        /// <summary>
        /// Adds the extension async.
        /// </summary>
        /// <param name="cloudService">The cloud service.</param>
        /// <param name="extension">The extension.</param>
        /// <returns></returns>
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
                var postData = await SerializationHelper.DataContractSerializerFragment<CloudServiceExtension>(extension);
                                
                var extOp = string.Format(addExtensionOperation, cloudService);
                
                this.InitHttpClient(extOp, "application/xml");

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

        /// <summary>
        /// Lists the available extensions async.
        /// </summary>
        /// <returns></returns>
        public async Task<ListAvailableExtensionsOperationResult> ListAvailableExtensionsAsync()
        {
            try
            {
                this.InitHttpClient(listAvailableExtensionsOperation);

                var message = await this.client.GetAsync(this.apiOperationUri);

                if (!message.IsSuccessStatusCode)
                {
                    return new ListAvailableExtensionsOperationResult()
                    {
                        AsyncException = null,
                        Message = string.Format("API call failed. Reason {0}.", message.ReasonPhrase),
                        OperationResult = null,
                        Successfull = false
                    };
                }

                var xmlReply = await message.Content.ReadAsStringAsync();

                var availableExtensions = SerializationHelper.DataContractDesirializeXmlFragment<CloudServiceExtensionImagesRoot>(xmlReply, "ExtensionImages", "http://schemas.microsoft.com/windowsazure");
               
                return new ListAvailableExtensionsOperationResult()
                {
                    AsyncException = null,
                    Message = "Successfully listed all available cloud service extensions.",
                    OperationResult = availableExtensions,
                    Successfull = true
                };
            }
            catch (Exception ex)
            {
                return new ListAvailableExtensionsOperationResult()
                {
                    AsyncException = ex,
                    Message = "An error occured trying to list all available cloud service extentions. Please see the AsnycException property for more details.",
                    OperationResult = null,
                    Successfull = true
                };
            }
        }

        /// <summary>
        /// Lists the extensions async.
        /// </summary>
        /// <param name="cloudService">The cloud service.</param>
        /// <returns></returns>
        public async Task<ListExtensionsOperationResult> ListExtensionsAsync(string cloudService)
        {
            if (string.IsNullOrEmpty(cloudService) || string.IsNullOrWhiteSpace(cloudService))
            {
                return new ListExtensionsOperationResult()
                {
                    AsyncException = null,
                    Message = "The name of the cloud service cannot be empty or null. Please check the parameter cloudService",
                    Successfull = false
                };
            }

            try
            {
                var op = string.Format(addExtensionOperation, cloudService);

                this.InitHttpClient(op);

                var message = await this.client.GetAsync(this.apiOperationUri);


                if (!message.IsSuccessStatusCode)
                {
                    return new ListExtensionsOperationResult()
                    {
                        AsyncException = null,
                        Message = string.Format("Error occured during web-request. Reason:{0}.", message.ReasonPhrase),
                        Successfull = true
                    };
                }

                var content = await message.Content.ReadAsStringAsync();

                var extensions = SerializationHelper.DataContractDeserialize<CloudServiceExtensions>(content);

                return new ListExtensionsOperationResult()
                {
                    AsyncException = null,
                    Message = string.Format("Extensions for cloud service {0} successfully retrieved.", cloudService),
                    Successfull = true
                };
            }
            catch (Exception ex)
            {

                return new ListExtensionsOperationResult()
                {
                    AsyncException = ex,
                    Message = "An error occured. Please check the AsyncException property.",
                    Successfull = false
                };
            }
        }


     
    }
}