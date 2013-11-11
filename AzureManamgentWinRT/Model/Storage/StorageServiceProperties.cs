using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// The service properties that are returned
    /// for every storage service from Windows
    /// Azure.
    /// </summary>
    [DataContract]
    public class StorageServiceProperties
    {
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        [DataMember(Name = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the end points.
        /// </summary>
        /// <value>The end points.</value>
        [DataMember(Name = "EndPoints")]
        public List<string> EndPoints { get; set; }

        /// <summary>
        /// Gets or sets the geo replication enabled.
        /// </summary>
        /// <value>The geo replication enabled.</value>
        [DataMember(Name = "GeoReplicationEnabled")]
        public bool GeoReplicationEnabled { get; set; }

        /// <summary>
        /// Gets or sets the geo primary region.
        /// </summary>
        /// <value>The geo primary region.</value>
        [DataMember(Name = "GeoPrimaryRegion")]
        public string GeoPrimaryRegion { get; set; }

        /// <summary>
        /// Gets or sets the geo secondary region.
        /// </summary>
        /// <value>The geo secondary region.</value>
        [DataMember(Name = "GeoSecondaryRegion")]
        public string GeoSecondaryRegion { get; set; }

        /// <summary>
        /// Gets or sets the status of secondary.
        /// </summary>
        /// <value>The status of secondary.</value>
        [DataMember(Name = "StatusOfSecondary")]
        public object StatusOfSecondary { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>The created.</value>
        [DataMember(Name = "Created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the extended properties.
        /// </summary>
        /// <value>The extended properties.</value>
        [DataMember(Name = "ExtendedProperties")]
        public Dictionary<string, object> ExtendedProperties { get; set; }
    }
}