using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// Used to create a new storage service.
    /// </summary>
    [DataContract(Namespace="http://schemas.microsoft.com/windowsazure")]
    public class CreateStorageServiceInput
    {
        /// <summary>
        /// Gets or sets the name of the service.
        /// Required.
        /// </summary>
        /// <value>The name of the service.</value>
        [DataMember(Name = "ServiceName", IsRequired = true, Order = 0)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// The description may be up to 1024 characters in length.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Description", IsRequired = false, Order = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// A base64-encoded string. The name may be up to 100 characters in length, good
        /// for tracking purposes.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Label", IsRequired = true, Order = 2)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the affinity group.
        /// Required if Location is not specified. 
        /// The name of an existing affinity group in the specified subscription
        /// </summary>
        /// <value>The affinity group.</value>
        [DataMember(Name = "AffinityGroup", IsRequired = false, Order = 3,EmitDefaultValue=false)]
        public string AffinityGroup { get; set; }

        /// <summary>
        /// Required if AffinityGroup is not specified. 
        /// The location where the storage account is created.
        /// </summary>
        /// <value>The location.</value>
        [DataMember(Name = "Location", IsRequired = false, Order = 4,EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the geo replication enabled.
        /// ATTENTION: Optional. Specifies whether the storage account is 
        /// created with the geo-replication enabled.
        /// </summary>
        /// <value>The geo replication enabled.</value>
        [DataMember(Name = "GeoReplicationEnabled", IsRequired = false, Order = 5)]
        public bool GeoReplicationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the extended properties.
        /// Each extended property must have both a defined name and value. 
        /// You can have a maximum of 50 extended property name/value pairs, and each extended property value has a maximum length 
        /// of 255 characters..
        /// </summary>
        /// <value>The extended properties.</value>
        [DataMember(Name = "ExtendedProperties", IsRequired = false, Order = 6)]
        public List<ExtendedProperty> ExtendedProperties { get; set; }
    }
}
