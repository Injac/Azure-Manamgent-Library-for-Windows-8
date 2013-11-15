using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{   
    /// <summary>
    /// Avail
    /// </summary>
    [DataContract]
    public class StorageAccountNameAvailablitiy
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>The result.</value>
        [DataMember(Name = "Result")]
        public bool Result { get; set; }
        [DataMember(Name = "Reason")]
        public string Reason { get; set; }
    }
}
