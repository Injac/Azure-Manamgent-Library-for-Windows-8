using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AzureManamgentWinRT.Model.Storage;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// The root element of the storage
    /// information returned by Windows
    /// Azure.
    /// </summary>
    [DataContract]
    public class StorageServiceRoot
    {
        /// <summary>
        /// Gets or sets the storage services.
        /// </summary>
        /// <value>The storage services.</value>
        [DataMember(Name = "StorageServices")]
        public List<StorageService> StorageServices { get; set; }
    }
}
