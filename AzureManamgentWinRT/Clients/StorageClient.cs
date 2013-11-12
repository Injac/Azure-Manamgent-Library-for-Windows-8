using AzureManamgentWinRT.Model.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Clients
{
    /// <summary>
    /// Client to get information about
    /// the available storage services.
    /// </summary>
    public class StorageClient
    {
        /// <summary>
        /// The api endpoint to list all available storage services.
        /// </summary>
        private const string apiEndpointListServices = "/services/storageservices";

        /// <summary>
        /// Used to indicate an opearation one the storage
        /// service endpoint.
        /// </summary>
        private const string apiOperationsEndpoint = "/operations";

        /// <summary>
        /// Check the availability of the service.
        /// </summary>
        private const string apiIsAvailableOperation = "/isavailable/{0}";
                        
        /// <summary>
        /// The base uri for all api calls.
        /// </summary>
        private readonly string apiBaseUri = "https://management.core.windows.net//{0}/{1}";

        /// <summary>
        /// The namespace for the return XML.
        /// </summary>
        private readonly string nameSpace = "http://schemas.microsoft.com/windowsazure";

        /// <summary>
        /// The api header version-identifier.
        /// </summary>
        private readonly string apiVersionHeaderName = "x-ms-version";

        /// <summary>
        /// The api version.
        /// </summary>
        private readonly string apiVersionHeaderValue = "2013-03-01";

        /// <summary>
        /// The subscription id.
        /// </summary>
        private string subscriptionId;

        /// <summary>
        /// Api operation URI
        /// </summary>
        private Uri apiOperationUri;

        /// <summary>
        /// HttpClient for the API calls.
        /// </summary>
        private HttpClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageClient" /> class.
        /// </summary>
        /// <param name="subscriptionId">The subscription id.</param>
        public StorageClient(string subscriptionId)
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
        /// List all available storage services of
        /// the current subscription.
        /// </summary>
        /// <returns></returns>
        public async Task<StorageListResult> ListAsync()
        {
            var serviceRoot = new StorageServiceRoot() { StorageServices = new List<StorageService>() };

            try
            {
                this.InitHttpClient(apiEndpointListServices);

                var result = await client.GetAsync(apiOperationUri, HttpCompletionOption.ResponseContentRead);
                var responseContent = await result.Content.ReadAsStringAsync();

                XDocument doc = XDocument.Parse(responseContent);

                XNamespace wa = this.nameSpace;

                XElement storageServices = doc.Element(wa + "StorageServices");

                foreach (XElement service in storageServices.Elements(wa + "StorageService"))
                {
                    var srv = new StorageService()
                    {
                        Url = service.Element(wa + "Url").Value,
                        ServiceName = service.Element(wa + "ServiceName").Value,
                        ServiceProperties = new StorageServiceProperties() { EndPoints = new List<string>(), ExtendedProperties = new Dictionary<string, object>() }
                    };

                    foreach (XElement property in service.Elements(wa + "StorageServiceProperties"))
                    {
                        srv.ServiceProperties.Description = property.Element(wa + "Description").Value;
                        srv.ServiceProperties.Location = property.Element(wa + "Location").Value;
                        srv.ServiceProperties.Label = property.Element(wa + "Label").Value;
                        srv.ServiceProperties.Status = property.Element(wa + "Status").Value;
                        srv.ServiceProperties.GeoPrimaryRegion = property.Element(wa + "GeoPrimaryRegion").Value;
                        srv.ServiceProperties.GeoReplicationEnabled = Convert.ToBoolean(property.Element(wa + "GeoReplicationEnabled").Value);
                        srv.ServiceProperties.GeoSecondaryRegion = property.Element(wa + "GeoSecondaryRegion").Value;
                        srv.ServiceProperties.Created = DateTime.Parse(property.Element(wa + "CreationTime").Value);

                        foreach (XElement endpoint in property.Elements(wa + "Endpoints").Descendants(wa + "Endpoint"))
                        {
                            srv.ServiceProperties.EndPoints.Add(endpoint.Value);
                        }

                        foreach (XElement extProperty in property.Elements(wa + "ExtendedProperties").Descendants(wa + "ExtendedProperty"))
                        {
                            srv.ServiceProperties.ExtendedProperties.Add(extProperty.Element(wa + "Name").Value, extProperty.Element(wa + "Value"));
                        }
                    }

                    serviceRoot.StorageServices.Add(srv);
                }
            }
            catch (Exception ex)
            {
                return new StorageListResult()
                {
                    AsyncException = ex,
                    Message = "An error occured, retrieving storage services. Please check the the AsyncException property.",
                    OperationResult = null,
                    Successfull = false
                };
            }

            return new StorageListResult()
            {
                AsyncException = null,
                Message = "Successfully retrieved all storage services",
                OperationResult = serviceRoot,
                Successfull = true
            };
        }

        /// <summary>
        /// Checks the storage account name availablity.
        /// </summary>
        /// <param name="storageAccountName">Name of the storage account.</param>
        /// <returns></returns>
        public async Task<StorageAccountNameAvailabilityResult> CheckStorageAccountNameAvailablityAsync(string storageAccountName)
        {
            try
            {
                if (string.IsNullOrEmpty(storageAccountName) || string.IsNullOrWhiteSpace(storageAccountName))
                {
                    return new StorageAccountNameAvailabilityResult()
                    {
                        AsyncException = null,
                        Message = "Parameter storageAccountName cannot be null or empty.",
                        OperationResult = null,
                        Successfull = false
                    };
                }

                if (storageAccountName.Length < 3 || storageAccountName.Length > 24)
                {
                    return new StorageAccountNameAvailabilityResult()
                    {
                        AsyncException = null,
                        Message = "Storage account names must be between 3 and 24 characters in lenght.",
                        OperationResult = null,
                        Successfull = false
                    };
                }

                if (storageAccountName.Length < 3 || storageAccountName.Length > 24)
                {
                    return new StorageAccountNameAvailabilityResult()
                    {
                        AsyncException = null,
                        Message = "Storage account names must be between 3 and 24 characters in lenght.",
                        OperationResult = null,
                        Successfull = false
                    };
                }

                if (System.Text.RegularExpressions.Regex.IsMatch(storageAccountName, @"\d"))
                {
                    return new StorageAccountNameAvailabilityResult()
                    {
                        AsyncException = null,
                        Message = "Storage account names can only contain lower case letters.",
                        OperationResult = null,
                        Successfull = false
                    };
                }

                var operation = string.Format("{0}{1}{2}", apiEndpointListServices, apiOperationsEndpoint, string.Format(apiIsAvailableOperation,
                    storageAccountName.ToLowerInvariant()));

                this.InitHttpClient(operation);

                var result = await client.GetAsync(apiOperationUri, HttpCompletionOption.ResponseContentRead);
                var responseContent = await result.Content.ReadAsStringAsync();

                XDocument doc = XDocument.Parse(responseContent);

                XNamespace wa = this.nameSpace;

                var available = Convert.ToBoolean(doc.Descendants(wa + "Result").FirstOrDefault().Value);
                var reason = doc.Descendants(wa + "Reason").FirstOrDefault().Value;

                return new StorageAccountNameAvailabilityResult()
                {
                    AsyncException = null,
                    Message = "Operation successfull.",
                    OperationResult = new StorageAccountNameAvailablitiy()
                    {
                        Result = available,
                        Reason = reason
                    },
                    Successfull = true
                };
            }
            catch (Exception ex)
            {
                return new StorageAccountNameAvailabilityResult()
                {
                    AsyncException = ex,
                    Message = "An error occured. Please check the AsyncException.",
                    OperationResult = null,
                    Successfull = false
                };
            }
        }

        /// <summary>
        /// Creates the storage account async.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <returns></returns>
        public async Task<StorageServiceCreateResult> CreateStorageAccountAsync(CreateStorageServiceInput account)
        {
            try
            {
                if (account == null)
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = String.Format("Parameter cannot be null {0}",
                            "account"),
                        OperationResult = "Parameter null",
                        Successfull = false
                    };
                }

                Regex r = new Regex(@"^[a-z0-9]*$");
                if (!r.IsMatch(account.ServiceName))
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = "Storage account name must contain only numbers and lowercase letters. Please check your data",
                        OperationResult = "Validation error.",
                        Successfull = false
                    };
                }

                if (account.ServiceName.Length > 24 || account.ServiceName.Length < 3)
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = "Storage account name must be between 3 and 24 characters long.",
                        OperationResult = "Validation error.",
                        Successfull = false
                    };
                }

                if (account.Label.Length > 100)
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = "Label must be base64 encoded and cannot be longer than 100 characters.",
                        OperationResult = "Validation error.",
                        Successfull = false
                    };
                }

                if (account.AffinityGroup != null || account.Location != null)
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = "You have to choose between affinity group, or location, both is not possible.",
                        OperationResult = "Validation error.",
                        Successfull = false
                    };
                }

                var ser = new DataContractSerializer(typeof(CreateStorageServiceInput));

                StringBuilder b = new StringBuilder();

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

                xmlWriterSettings.Async = true;
                xmlWriterSettings.Encoding = Encoding.UTF8;
                xmlWriterSettings.NamespaceHandling = NamespaceHandling.OmitDuplicates;
                xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;

                using (XmlWriter documentWriter = XmlWriter.Create(b, xmlWriterSettings))
                {
                    ser.WriteObject(documentWriter, account);

                    await documentWriter.FlushAsync();
                }

                this.InitHttpClient(apiEndpointListServices, "application/xml");

                HttpContent content = new StringContent(b.ToString());

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");

                var message = await this.client.PostAsync(this.apiOperationUri, content);

                if (!message.IsSuccessStatusCode)
                {
                    return new StorageServiceCreateResult()
                    {
                        AsyncException = null,
                        Message = String.Format("Storage service {0} could not be created. Reason {1}. Please check your data.",
                            account.ServiceName, message.ReasonPhrase),
                        OperationResult = account.ServiceName,
                        Successfull = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new StorageServiceCreateResult()
                {
                    AsyncException = ex,
                    Message = String.Format("Storage service {0} could not be created.",
                        account.ServiceName),
                    OperationResult = account.ServiceName,
                    Successfull = false
                };
            }

            return new StorageServiceCreateResult()
            {
                AsyncException = null,
                Message = String.Format("Storage service {0} successfully created",
                    account.ServiceName),
                OperationResult = account.ServiceName,
                Successfull = true
            };
        }

        /// <summary>
        /// Deletes the storage account async.
        /// </summary>
        /// <param name="storageAccountName">Name of the storage account.</param>
        /// <returns></returns>
        public async Task<StorageDeleteResult> DeleteStorageAccountAsync(string storageAccountName)
        {
            if (string.IsNullOrWhiteSpace(storageAccountName) || string.IsNullOrEmpty(storageAccountName))
            {
                return new StorageDeleteResult()
                {
                    AsyncException = null,
                    Message = String.Format("Parameter cannot be null {0}",
                        "storageAccountName"),
                    OperationResult = "Parameter null",
                    Successfull = false
                };
            }

            Regex r = new Regex(@"^[a-z0-9]*$");
            if (!r.IsMatch(storageAccountName))
            {
                return new StorageDeleteResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must contain only numbers and lowercase letters. Please check your data",
                    OperationResult = "Validation error.",
                    Successfull = false
                };
            }

            if (storageAccountName.Length > 24 || storageAccountName.Length < 3)
            {
                return new StorageDeleteResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must be between 3 and 24 characters long.",
                    OperationResult = "Validation error.",
                    Successfull = false
                };
            }

            this.InitHttpClient(String.Format("{0}{1}{2}", apiEndpointListServices, "/", storageAccountName.ToLowerInvariant()));
            
            var message = await client.DeleteAsync(this.apiOperationUri);

            if (!message.IsSuccessStatusCode)
            {
                return new StorageDeleteResult()
                {
                    AsyncException = null,
                    Message = String.Format("Storage account {0} could not be deleted. Reason {1}. Please check your data.",
                        storageAccountName, message.ReasonPhrase),
                    OperationResult = storageAccountName,
                    Successfull = false
                };
            }

            return new StorageDeleteResult()
            {
                AsyncException = null,
                Message = String.Format("Storage account {0} was successfully deleted.", storageAccountName.ToLowerInvariant()),
                OperationResult = storageAccountName.ToLowerInvariant(),
                Successfull = true
            };
        }

        /// <summary>
        /// Gets the storage account keys async.
        /// </summary>
        /// <param name="storageAccountName">Name of the storage account.</param>
        /// <returns></returns>
        public async Task<StorageKeysResult> GetStorageAccountKeysAsync(string storageAccountName)
        {
            if (string.IsNullOrWhiteSpace(storageAccountName) || string.IsNullOrEmpty(storageAccountName))
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = String.Format("Parameter cannot be null {0}",
                        "storageAccountName"),
                    OperationResult = null,
                    Successfull = false
                };
            }

            Regex r = new Regex(@"^[a-z0-9]*$");
            if (!r.IsMatch(storageAccountName))
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must contain only numbers and lowercase letters. Please check your data",
                    OperationResult = null,
                    Successfull = false
                };
            }

            if (storageAccountName.Length > 24 || storageAccountName.Length < 3)
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must be between 3 and 24 characters long.",
                    OperationResult = null,
                    Successfull = false
                };
            }

            try
            {
                this.InitHttpClient(String.Format("{0}{1}{2}{3}", apiEndpointListServices, "/", storageAccountName.ToLowerInvariant(), "/keys"));

                var message = await client.GetAsync(this.apiOperationUri);

                if (!message.IsSuccessStatusCode)
                {
                    return new StorageKeysResult()
                    {
                        AsyncException = null,
                        Message = String.Format("Could not execute storage key request. Reason {0}", message.ReasonPhrase),
                        OperationResult = null,
                        Successfull = false
                    };
                }

                var content = await message.Content.ReadAsStringAsync();
                              
                
                XmlReaderSettings readerSettings = new XmlReaderSettings();
                readerSettings.Async = true;
                readerSettings.ConformanceLevel = ConformanceLevel.Auto;

                DataContractSerializer ser = new DataContractSerializer(typeof(StorageServiceReply));

                StorageServiceReply result = null;

                byte[] byteArray = Encoding.UTF8.GetBytes(content);
                MemoryStream stream = new MemoryStream(byteArray);
                stream.Position = 0;

                using (XmlReader documentReader = XmlReader.Create(stream, readerSettings))
                {
                    result = ser.ReadObject(documentReader) as StorageServiceReply;
                }

                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = string.Format("Access keys for storage account {0} successfully retrieved", storageAccountName),
                    OperationResult = result,
                    Successfull = true
                };
            }
            catch (Exception ex)
            {
                return new StorageKeysResult()
                {
                    AsyncException = ex,
                    Message = "An error occured during the storage account key request operation.",
                    OperationResult = null,
                    Successfull = false
                };
            }
        }

        /// <summary>
        /// Res the generate storage keys async.
        /// </summary>
        /// <param name="storageAccountName">Name of the storage account.</param>
        /// <param name="keyType">Type of the access key to be generatedy.</param>
        /// <returns></returns>
        public async Task<StorageKeysResult> ReGenerateStorageKeysAsync(string storageAccountName, StorageAccountKeyType keyType)
        {
            if (string.IsNullOrWhiteSpace(storageAccountName) || string.IsNullOrEmpty(storageAccountName))
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = String.Format("Parameter cannot be null {0}",
                        "storageAccountName"),
                    OperationResult = null,
                    Successfull = false
                };
            }

            Regex r = new Regex(@"^[a-z0-9]*$");
            if (!r.IsMatch(storageAccountName))
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must contain only numbers and lowercase letters. Please check your data",
                    OperationResult = null,
                    Successfull = false
                };
            }

            if (storageAccountName.Length > 24 || storageAccountName.Length < 3)
            {
                return new StorageKeysResult()
                {
                    AsyncException = null,
                    Message = "Storage account name must be between 3 and 24 characters long.",
                    OperationResult = null,
                    Successfull = false
                };
            }

            try
            {
                RegenerateKeys keys = null;

                if (keyType == StorageAccountKeyType.Primary)
                {
                    keys = new RegenerateKeys() { KeyType = "Primary" };
                }

                if (keyType == StorageAccountKeyType.Secondary)
                {
                    keys = new RegenerateKeys() { KeyType = "Secondary" };
                }

                var ser = new DataContractSerializer(typeof(RegenerateKeys));

                StringBuilder b = new StringBuilder();

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

                xmlWriterSettings.Async = true;
                xmlWriterSettings.Encoding = Encoding.UTF8;
                xmlWriterSettings.NamespaceHandling = NamespaceHandling.OmitDuplicates;
                xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;

                using (XmlWriter documentWriter = XmlWriter.Create(b, xmlWriterSettings))
                {
                    ser.WriteObject(documentWriter, keys);

                    await documentWriter.FlushAsync();
                }

                var opUrl = string.Format("{0}{1}{2}{3}", apiEndpointListServices, "/", storageAccountName, "/keys?action=regenerate");

                this.InitHttpClient(opUrl, "application/xml");

                HttpContent content = new StringContent(b.ToString());

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");

                var message = await this.client.PostAsync(this.apiOperationUri, content);

                var keyReply = await message.Content.ReadAsStringAsync();

                XmlReaderSettings readerSettings = new XmlReaderSettings();
                readerSettings.Async = true;
                readerSettings.ConformanceLevel = ConformanceLevel.Auto;

                ser = new DataContractSerializer(typeof(StorageServiceReply));

                StorageServiceReply result = null;

                byte[] byteArray = Encoding.UTF8.GetBytes(keyReply);
                MemoryStream stream = new MemoryStream(byteArray);
                stream.Position = 0;

                using (XmlReader documentReader = XmlReader.Create(stream, readerSettings))
                {
                    result = ser.ReadObject(documentReader) as StorageServiceReply;
                }

                return new StorageKeysResult()
                {
                    OperationResult = result,
                    Message = string.Format("{0} successfully re-generated for storage account:{1}",
                        keyType == StorageAccountKeyType.Primary ? "Primary access key " : "Secondary access key ", storageAccountName),
                    AsyncException = null,
                    Successfull = true
                };
            }
            catch (Exception ex)
            {

                return new StorageKeysResult()
                {
                    AsyncException = ex,
                    Message = String.Format("An error occured re-generating the access keys for storage account {0}. Please check the AsyncException.", 
                        storageAccountName),
                    OperationResult = null,
                    Successfull = false
                };
            }
        }

        /// <summary>
        /// Inits the HTTP client.
        /// </summary>
        /// <param name="apiOperation">The API operation.</param>
        private void InitHttpClient(string apiOperation)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            this.client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add(this.apiVersionHeaderName, this.apiVersionHeaderValue);
            this.apiOperationUri = new Uri(string.Format(apiBaseUri, this.subscriptionId, apiOperation));
        }
       
        /// <summary>
        /// Inits the HTTP client, using a specific media type.
        /// </summary>
        /// <param name="apiOperation">The API operation.</param>
        /// <param name="contentType">Type of the content.</param>
        private void InitHttpClient(string apiOperation, string contentType)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            this.client = new HttpClient(handler);
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            client.DefaultRequestHeaders.Add(this.apiVersionHeaderName, this.apiVersionHeaderValue);
            this.apiOperationUri = this.apiOperationUri = new Uri(string.Format(apiBaseUri, this.subscriptionId, apiOperation));
            ;
        }
    }
}