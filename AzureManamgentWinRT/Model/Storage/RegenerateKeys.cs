using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// The KeyType xml fragment to 
    /// be sent to Azure to re-generate 
    /// keys.
    /// </summary>
    [DataContract(Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class RegenerateKeys 
    {
        /// <summary>
        /// Gets or sets the type of the key.
        /// </summary>
        /// <value>The type of the key.</value>
        [DataMember(Name="KeyType", IsRequired = true)]
        public string KeyType { get; set; }
        
    }
}
