using AzureManamgentWinRT.Clients.CloudServicesOperationResults;
using AzureManamgentWinRT.Clients.Helper;
using AzureManamgentWinRT.Configuration;
using AzureManamgentWinRT.Model;
using AzureManamgentWinRT.Model.CloudServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AzureManamgentWinRT.Model.HostedServices;

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

        private const string changeDeploymentDeploymentSlot = "/services/hostedservices/{0}/deploymentslots/{1}/?comp=config ";

        private const string changeDeploymentDeploymentName = "/services/hostedservices/{0}/deployments/{1}/?comp=config ";

        private const string getCloudSerivcePropertiesSimple = "services/hostedservices/{0}?embed-detail=false";

        private const string getCloudSerivcePropertiesDetailed = "services/hostedservices/{0}?embed-detail=true";

        private const string checkHostedSericeNameAvailability = "/services/hostedservices/operations/isavailable/{0}";

        private const string createCloudSerice = "/services/hostedservices";
       
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
                var postData = await SerializationHelper.DataContractSerializerDocument<CloudServiceExtension>(extension);
                                
                var extOp = string.Format(addExtensionOperation, cloudService);
                
                this.InitHttpClient(extOp, "application/xml");

                var content = new StringContent(postData,Encoding.UTF8,"application/xml");

                var message = await this.client.PostAsync(this.apiOperationUri, content);

                var messageContent = await message.Content.ReadAsStringAsync();
                
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

        /// <summary>
        /// Gets the cloud service properties async.
        /// </summary>
        /// <param name="cloudServiceName">Name of the cloud service.</param>
        /// <param name="extended">The extended.</param>
        /// <returns></returns>
        public async Task<GetCloudServicePropertiesOperationResult> GetCloudServicePropertiesAsync(string cloudServiceName, bool extended=false)
        {
            if (string.IsNullOrEmpty(cloudServiceName) || string.IsNullOrWhiteSpace(cloudServiceName))
            {
                return new GetCloudServicePropertiesOperationResult()
                {
                    AsyncException = null,
                    Message = "The name of the cloud service cannot be empty or null. Please check the parameter cloudService",
                    Successfull = false
                };
            }
            
            string op = string.Empty;

            if (extended)
            {
                op = string.Format(getCloudSerivcePropertiesDetailed, cloudServiceName);
            }
            else
            {
                op = string.Format(getCloudSerivcePropertiesSimple, cloudServiceName);
            }

            try
            {
                this.InitHttpClient(op);

                var message = await client.GetAsync(this.apiOperationUri);

                if (!message.IsSuccessStatusCode)
                {
                    return new GetCloudServicePropertiesOperationResult()
                    {
                        AsyncException = null,
                        Message = string.Format("Something went wrong during the web-request. Reason: {0}", message.ReasonPhrase),
                        Successfull = false
                    };
                }

                var content = await message.Content.ReadAsStringAsync();

                content = content.Replace("i:type=\"NetworkConfigurationSet\"", " ");

                var deser = SerializationHelper.XmlDeSerialize<HostedService>(content);

                return new GetCloudServicePropertiesOperationResult()
                {
                    AsyncException = null,
                    Message = string.Format("Sucessfully retrieved properties for cloud service {0}", cloudServiceName),
                    Successfull = true,
                    OperationResult = deser
                };
            }
            catch (Exception ex)
            {
                return new GetCloudServicePropertiesOperationResult()
                {
                    AsyncException = ex,
                    Message = "An error occured. Please check the AsyncException property for further informations about the error.",
                    Successfull = false
                };
            }
        }

        /// <summary>
        /// Changes the deployment using deployment slots. Production or
        /// Staging.
        /// </summary>
        /// <param name="cloudServiceName">Name of the cloud service.</param>
        /// <param name="slot">The slot.</param>
        /// <param name="conf">The conf.</param>
        /// <returns></returns>
        public async Task<CloudServiceChangeDeploymentOperationResult> ChangeDeploymentUsingDeploymentSlotAsync(string cloudServiceName, DeploymentSlot slot, ChangeConfiguration conf)
        {
            if (string.IsNullOrEmpty(cloudServiceName) || string.IsNullOrWhiteSpace(cloudServiceName))
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    Message = "Parameter cloudServicename cannot be null, empty or whitespace"
                };
            }

            if (conf == null)
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    Message = "Parameter conf cannot be null."
                };
            }

            string op = string.Empty;

            if (slot == DeploymentSlot.Production)
            {
                op = string.Format(changeDeploymentDeploymentSlot, cloudServiceName, "Production");
            }

            if (slot == DeploymentSlot.Staging)
            {
                op = string.Format(changeDeploymentDeploymentSlot, cloudServiceName, "Staging");
            }

            try
            {
                this.InitHttpClient(op, "application/xml");

                var postData = await SerializationHelper.XmlSerialize<ChangeConfiguration>(conf, omitDeclaration: true);

                var postContent = new StringContent(postData, Encoding.UTF8, "application/xml");

                var message = await client.PostAsync(this.apiOperationUri, postContent);

                var messageContent = await message.Content.ReadAsStringAsync();

                if (!message.IsSuccessStatusCode)
                {
                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = false,
                        Message = string.Format("An error occured during the request. Reason {0}, Error Message: {1}", message.ReasonPhrase, messageContent)
                    };
                }

                if (message.Headers.Contains("x-ms-request-id"))
                {
                    var header = message.Headers.First(h => h.Key.Equals("x-ms-request-id"));

                    var headerValue = header.Value.First();

                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = true,
                        Message = headerValue
                    };
                }
                else
                {
                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = false,
                        Message = "Request id was not delivered."
                    };
                }
            }
            catch (Exception ex)
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = ex,
                    Successfull = false,
                    Message = "An error occured during the request. Please see the AsyncException property."
                };
            }
        }

        /// <summary>
        /// Changes the deployment using deployment name. 
        /// </summary>
        /// <param name="cloudServiceName">Name of the cloud service.</param>
        /// <param name="deplyomentName">The name of a cloud service deployment.</param>
        /// <param name="conf">The conf.</param>
        /// <returns></returns>
        public async Task<CloudServiceChangeDeploymentOperationResult> ChangeDeploymentUsingDeploymentNameAsync(string cloudServiceName, string deploymentName, ChangeConfiguration conf)
        {
            if (string.IsNullOrEmpty(cloudServiceName) || string.IsNullOrWhiteSpace(cloudServiceName))
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    Message = "Parameter cloudServicename cannot be null, empty or whitespace"
                };
            }

            if (string.IsNullOrEmpty(deploymentName) || string.IsNullOrWhiteSpace(deploymentName))
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    Message = "Parameter cloudServicename cannot be null, empty or whitespace"
                };
            }

            if (conf == null)
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    Message = "Parameter conf cannot be null."
                };
            }

            string op = string.Empty;

            op = string.Format(changeDeploymentDeploymentName, cloudServiceName, deploymentName);

            try
            {
                this.InitHttpClient(op, "application/xml");

                var postData = await SerializationHelper.XmlSerialize<ChangeConfiguration>(conf, omitDeclaration: true);

                var postContent = new StringContent(postData, Encoding.UTF8, "application/xml");

                var message = await client.PostAsync(this.apiOperationUri, postContent);

                var messageContent = await message.Content.ReadAsStringAsync();

                if (!message.IsSuccessStatusCode)
                {
                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = false,
                        Message = string.Format("An error occured during the request. Reason {0}, Error Message: {1}", message.ReasonPhrase, messageContent)
                    };
                }

                if (message.Headers.Contains("x-ms-request-id"))
                {
                    var header = message.Headers.First(h => h.Key.Equals("x-ms-request-id"));

                    var headerValue = header.Value.First();

                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = true,
                        Message = headerValue
                    };
                }
                else
                {
                    return new CloudServiceChangeDeploymentOperationResult()
                    {
                        AsyncException = null,
                        Successfull = false,
                        Message = "Request id was not delivered."
                    };
                }
            }
            catch (Exception ex)
            {
                return new CloudServiceChangeDeploymentOperationResult()
                {
                    AsyncException = ex,
                    Successfull = false,
                    Message = "An error occured during the request. Please see the AsyncException property."
                };
            }
        }


        /// <summary>
        /// Checks the hosted service name availability.
        /// </summary>
        /// <param name="cloudServiceName">Name of the cloud service.</param>
        /// <returns></returns>
        public async Task<HostedServiceCheckNameAvailabilityOperationResult> CheckHostedServiceNameAvailability(string cloudServiceName)
        {
            
            if (string.IsNullOrEmpty(cloudServiceName) || string.IsNullOrWhiteSpace(cloudServiceName))
            {
                return new HostedServiceCheckNameAvailabilityOperationResult()
                {
                    AsyncException = null,
                    Successfull = false,
                    OperationResult = null
                };
            }

            try
            {
                string op = string.Empty;

                op = string.Format(checkHostedSericeNameAvailability, cloudServiceName);

                this.InitHttpClient(op);

                var message = await this.client.GetAsync(this.apiOperationUri);

                var messageContent = await message.Content.ReadAsStringAsync();

                var response = SerializationHelper.XmlDeSerialize<AvailabilityResponse>(messageContent);

                if (!message.IsSuccessStatusCode)
                {
                    return new HostedServiceCheckNameAvailabilityOperationResult()
                    {
                        AsyncException = null,
                        Successfull = true,
                        OperationResult = response
                    };
                }
                else
                {
                    if (response.Result)
                    {
                        return new HostedServiceCheckNameAvailabilityOperationResult()
                        {
                            AsyncException = null,
                            Successfull = true,
                            OperationResult = response
                        };
                    }
                    else
                    {
                        return new HostedServiceCheckNameAvailabilityOperationResult()
                        {
                            AsyncException = null,
                            Successfull = false,
                            OperationResult = response
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new HostedServiceCheckNameAvailabilityOperationResult()
                {
                    AsyncException = ex,
                    Successfull = false,
                    OperationResult = null
                };

                
            }

        }


        /// <summary>
        /// Creates the cloud service async.
        /// </summary>
        /// <param name="serviceDefinition">The service definition.</param>
        /// <returns></returns>
        public async Task<CreateCloudServiceOperationResult> CreateCloudServiceAsync(CreateHostedService serviceDefinition)
        {
            if (serviceDefinition == null)
            {
                return new CreateCloudServiceOperationResult()
                {
                    AsyncException = null,
                    OperationResult = "The parameter serviceDefinition cannot be null.",
                    Successfull = false

                };
            }
            
            var op = string.Empty;

            op = createCloudSerice;

            this.InitHttpClient(op,"application/xml");

            var xmlContent = await SerializationHelper.XmlSerialize<CreateHostedService>(serviceDefinition);

            try
            {
                if (!string.IsNullOrEmpty(xmlContent))
                {
                    var httpContent = new StringContent(xmlContent, Encoding.UTF8, "application/xml");
                    var message = await client.PostAsync(this.apiOperationUri, httpContent);
                    var messageContent = await message.Content.ReadAsStringAsync();

                    if (!message.IsSuccessStatusCode)
                    {
                        return new CreateCloudServiceOperationResult()
                        {
                            AsyncException = null,
                            OperationResult = string.Format("Something went wrong during the request. Reason: {1}, Error message: {2}", message.ReasonPhrase, messageContent),
                            Successfull = false

                        };
                    }
                    else
                    {
                        if (message.Headers.Contains("x-ms-request-id"))
                        {
                            var header = message.Headers.First(h => h.Key.Equals("x-ms-request-id"));

                            var headerValue = header.Value.First();


                            return new CreateCloudServiceOperationResult()
                            {
                                AsyncException = null,
                                OperationResult = headerValue,
                                Successfull = true

                            };
                        }
                        else
                        {
                            return new CreateCloudServiceOperationResult()
                            {
                                AsyncException = null,
                                OperationResult = "The request returned a success code. But the required header value was not present.",
                                Successfull = false

                            };
                        }
                    }
                }
                else
                {
                    return new CreateCloudServiceOperationResult()
                    {
                        AsyncException = null,
                        OperationResult = "The parameter serviceDefinition could not be serialized.",
                        Successfull = false

                    };
                }
            }
            catch (Exception ex)
            {

                return new CreateCloudServiceOperationResult()
                {
                    AsyncException = ex,
                    OperationResult = "An error occured. Please check the AsyncException property for more informations",
                    Successfull = false

                };
            }
        }

    }
}