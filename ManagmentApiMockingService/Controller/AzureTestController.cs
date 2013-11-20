using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Serialization;

namespace ManagmentApiMockingService.Controller
{
    /// <summary>
    /// Mocking Azure API
    /// </summary>
    public class AzureTestController : ApiController
    {
        /// <summary>
        /// Checks the check storage account name availability.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/storageservices/operations/isavailable/{servicename}")]
        public async Task<HttpResponseMessage> CheckCheckStorageAccountNameAvailability(string id, string servicename)
        {
            return Request.CreateResponse(string.Format("Success calling {0}attribute routing", "ARG0"));
        }

        /// <summary>
        /// Creates the storage account.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/services/storageservices")]
        public async Task<HttpResponseMessage> CreateStorageAccount(HttpRequestMessage request)
        {
            return Request.CreateResponse("Success calling attribute routing");
        }

        [HttpGet]
        [Route("{id}/services/storageservices")]
        public async Task<HttpResponseMessage> ListStorageServices()
        {
            return Request.CreateResponse("Success calling attribute routing");
        }

        /// <summary>
        /// Deletes the storage service.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}/services/storageservices/{servicename}")]
        public async Task<HttpResponseMessage> DeleteStorageService(string id, string servicename)
        {
            return Request.CreateResponse("Success calling attribute routing");
        }

        /// <summary>
        /// Updates the storage servcie.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/services/storageservices/{servicename}")]
        public async Task<HttpResponseMessage> UpdateStorageServcie(string id, string servicename)
        {
            return Request.CreateResponse("Success calling attribute routing");
        }
       
        /// <summary>
        /// Gets the storage service keys.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/services/storageservices/{servicename}/keys")]
        public async Task<HttpResponseMessage> GetStorageServiceKeys(string id, string servicename)
        {
            return Request.CreateResponse("Success calling attribute routing");
        }

        /// <summary>
        /// Gets the storage account properties.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/services/storageservices/{servicename}")]
        public async Task<HttpResponseMessage> GetStorageAccountProperties(string id, string servicename)
        {
            return Request.CreateResponse("Success calling attribute routing");
        }
       
        /// <summary>
        /// Regenerates the storage keys.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="servicename">The servicename.</param>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/services/storagesevices/{servicename}/keys")]
        public async Task<HttpResponseMessage> RegenerateStorageKeys(string  id, string servicename, string action)
        {

            var param = Request.GetQueryNameValuePairs();
            
            return Request.CreateResponse("Success calling attribute routing");
        }


       


    }
}