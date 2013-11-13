using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    [DataContract(Name="StorageService", Namespace="http://schemas.microsoft.com/windowsazure")]
    public class StorageAccountProperties
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
        public StorageAccountPropertiesPropCall StorageServiceProperties { get; set; }
               
        /// <summary>
        /// Gets or sets the extended properties.
        /// </summary>
        /// <value>The extended properties.</value>
        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }

        [DataMember(Name = "Capabilities")]
        public List<string> Capabilities { get; set; }

    }

    ///// <summary>
    ///// Class to represent the capability items.
    ///// </summary>
    //[CollectionDataContract(ItemName = "Capability")]
    //public class CapabilitieList : List<string>
    //{
    //}
}
