using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// ExtensionImage
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169559.aspx
    /// </summary>
    [DataContract(Name = "ExtensionImage", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class CloudServiceExtensionImage
    {
        /// <summary>
        /// Gets or sets the provider name space.
        /// </summary>
        /// <value>The provider name space.</value>
        [DataMember(Name = "ProviderNameSpace",Order=0)]
        public string ProviderNameSpace { get; set; }
    
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Type", Order = 1)]
        public string Type { get; set; }
      
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Version", Order = 2)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Label", Order = 3)]
        public string Label { get; set; }
       
      
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Description", Order = 4)]
        public string Description { get; set; }
        
      
        /// <summary>
        /// Gets or sets the hosting resources.
        /// </summary>
        /// <value>The hosting resources.</value>
        [DataMember(Name = "HostingResources", Order = 5)]
        public string HostingResources { get; set; }
       
      
        /// <summary>
        /// Gets or sets the thumbprint algorithm.
        /// </summary>
        /// <value>The thumbprint algorithm.</value>
        [DataMember(Name = "ThumbprintAlgorithm", Order = 6)]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the public configuration schema.
        /// </summary>
        /// <value>The public configuration schema.</value>
        [DataMember(Name = "PublicConfigurationSchema", Order = 7)]
        public string PublicConfigurationSchema { get; set; }

        /// <summary>
        /// Gets or sets the private configuration schema.
        /// </summary>
        /// <value>The private configuration schema.</value>
        [DataMember(Name = "PrivateConfigurationSchema", Order = 8)]
        public string PrivateConfigurationSchema { get; set; }
    }
}