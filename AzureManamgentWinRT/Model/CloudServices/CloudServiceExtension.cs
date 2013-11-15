using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Add an extention to your Cloud Service
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169558.aspx
    /// </summary>
    [DataContract(Name = "Extension", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class CloudServiceExtension
    {
        [DataMember(Name = "ProviderNameSpace",IsRequired=true,Order=0)]
        public string ProviderNameSpace { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [DataMember(Name = "Type", IsRequired = true, Order = 1)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [DataMember(Name = "Id", IsRequired = true, Order = 2)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint.
        /// </summary>
        /// <value>The thumbprint.</value>
        [DataMember(Name = "Thumbprint", IsRequired = true, EmitDefaultValue = false, Order = 3)]
        public string Thumbprint { get; set; }
      
        /// <summary>
        /// Gets or sets the thumb print algorithm.
        /// </summary>
        /// <value>The thumb print algorithm.</value>
        [DataMember(Name = "ThumbPrintAlgorithm", IsRequired = false, EmitDefaultValue = false, Order = 4)]
        public string ThumbPrintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the public configuration.
        /// </summary>
        /// <value>The public configuration.</value>
        [DataMember(Name = "PublicConfiguration", IsRequired = false, EmitDefaultValue = false, Order = 5)]
        public string PublicConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the private configuration.
        /// </summary>
        /// <value>The private configuration.</value>
        [DataMember(Name = "PrivateConfiguration", IsRequired = false, EmitDefaultValue = false, Order = 6)]
        public string PrivateConfiguration { get; set; }
    }
}