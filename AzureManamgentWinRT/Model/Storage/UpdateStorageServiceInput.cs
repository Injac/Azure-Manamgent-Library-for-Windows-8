using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// Used to update an existing storage service.
    /// </summary>
    [DataContract(Name = "UpdateStorageServiceInput", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class UpdateStorageServiceInput
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Description", Order = 0, IsRequired = false, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Label", Order = 1, IsRequired = false, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the geo replication enabled.
        /// </summary>
        /// <value>The geo replication enabled.</value>
        [DataMember(Name = "GeoReplicationEnabled", Order = 2, IsRequired = false)]
        public bool GeoReplicationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the extended properties.
        /// </summary>
        /// <value>The extended properties.</value>
        [DataMember(Name = "ExtendedProperties", Order = 3, IsRequired = false,EmitDefaultValue=false)]
        List<ExtendedProperty> ExtendedProperties { get; set; }
    }
}