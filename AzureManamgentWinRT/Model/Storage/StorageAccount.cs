using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// The storage service returned
    /// by Windows Azure.
    /// </summary>
    [DataContract]
    public class StorageAccount
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [DataMember(Name = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        [DataMember(Name = "ServiceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the service properties.
        /// </summary>
        /// <value>The service properties.</value>
        [DataMember(Name = "StorageServiceProperties")]
        public StorageServiceProperties ServiceProperties { get; set; }
    }
}