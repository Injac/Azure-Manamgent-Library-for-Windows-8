using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    [DataContract]
    public class StorageAccountPropertiesPropCall
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name = "Description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the affinity group.
        /// </summary>
        /// <value>The affinity group.</value>
        [DataMember(Name = "AffinityGroup")]
        public string AffinityGroup { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        [DataMember(Name = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [DataMember(Name = "Label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
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
        /// Gets or sets the status of secondary.
        /// </summary>
        /// <value>The status of secondary.</value>
        [DataMember(Name = "StatusOfPrimary")]
        public object StatusOfPrimary { get; set; }

        [DataMember(Name = "LastGeoFailoverTime")]
        public string LastGeoFailoverTime { get; set; }

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

               


    }
}