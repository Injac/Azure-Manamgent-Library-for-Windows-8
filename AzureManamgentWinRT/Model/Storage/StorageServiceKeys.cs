using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    [DataContract(Name = "StorageServiceKeys", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class StorageServiceKeys
    {
        /// <summary>
        /// Gets or sets the primary storage account key.
        /// </summary>
        /// <value>The primary.</value>
        [DataMember(Name = "Primary")]
        public string Primary { get; set; }

        /// <summary>
        /// Gets or sets the secondary storage account key.
        /// </summary>
        /// <value>The secondary.</value>
        [DataMember(Name = "Secondary")]
        public string Secondary { get; set; }
    }
}
