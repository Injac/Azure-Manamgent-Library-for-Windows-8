using AzureManamgentWinRT.Model.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                AsyncException=null,
                Message="Successfully retrieved all storage services",
                OperationResult = serviceRoot,
                Successfull = true 
            };
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
    }
}