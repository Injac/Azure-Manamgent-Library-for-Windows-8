using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients
{
    /// <summary>
    /// Base client for any management operations.
    /// </summary>
    public abstract class ManagmentClientBase
    {

        /// <summary>
        /// The base uri for all api calls.
        /// </summary>
        protected  readonly string apiBaseUri = "https://management.core.windows.net//{0}/{1}";

        /// <summary>
        /// The namespace for the return XML.
        /// </summary>
        protected readonly string nameSpace = "http://schemas.microsoft.com/windowsazure";

        /// <summary>
        /// The api header version-identifier.
        /// </summary>
        protected readonly string apiVersionHeaderName = "x-ms-version";

        /// <summary>
        /// The api version.
        /// </summary>
        protected readonly string apiVersionHeaderValue = "2013-03-01";


        /// <summary>
        /// The subscription id.
        /// </summary>
        protected string subscriptionId;

        /// <summary>
        /// Api operation URI
        /// </summary>
        protected Uri apiOperationUri;

        /// <summary>
        /// HttpClient for the API calls.
        /// </summary>
        protected HttpClient client;


        /// <summary>
        /// Initializes a new instance of the <see cref="ManagmentClientBase" /> class.
        /// </summary>
        public ManagmentClientBase()
        {
        }

       
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudServicesClient" /> class.
        /// </summary>
        /// <param name="subscriptionId">The subscription id.</param>
        public ManagmentClientBase(string subscriptionId)
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
        /// Inits the HTTP client.
        /// </summary>
        /// <param name="apiOperation">The API operation.</param>
        protected virtual  void InitHttpClient(string apiOperation)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;

            this.client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add(this.apiVersionHeaderName, this.apiVersionHeaderValue);
            client.DefaultRequestHeaders.IfModifiedSince = DateTime.UtcNow;
            // client.DefaultRequestHeaders.CacheControl.NoStore = true;
            //client.DefaultRequestHeaders.CacheControl.NoCache = true;
            this.apiOperationUri = new Uri(string.Format(apiBaseUri, this.subscriptionId, apiOperation));
        }

        /// <summary>
        /// Inits the HTTP client, using a specific media type.
        /// </summary>
        /// <param name="apiOperation">The API operation.</param>
        /// <param name="contentType">Type of the content.</param>
        protected virtual void InitHttpClient(string apiOperation, string contentType)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            this.client = new HttpClient(handler);
            client.DefaultRequestHeaders.IfModifiedSince = DateTime.UtcNow;
            //client.DefaultRequestHeaders.CacheControl.NoStore = true;
            client.DefaultRequestHeaders.CacheControl.NoCache = true;
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            client.DefaultRequestHeaders.Add(this.apiVersionHeaderName, this.apiVersionHeaderValue);
            this.apiOperationUri = this.apiOperationUri = new Uri(string.Format(apiBaseUri, this.subscriptionId, apiOperation));
            ;
        }
    }
}
