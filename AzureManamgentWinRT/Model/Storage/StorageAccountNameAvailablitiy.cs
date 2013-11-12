using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
