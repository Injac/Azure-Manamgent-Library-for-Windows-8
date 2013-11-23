using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Represents a hosted service. This class is used to create a new service.
    /// </summary>
    [XmlRoot(ElementName = "CreateHostedService", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class CreateHostedService
    {
        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        [XmlElement(ElementName = "ServiceName", Order = 0)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [XmlElement(ElementName = "Label", Order = 1)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [XmlElement(ElementName = "Description", Order = 2)]
        public string Description { get; set; }

        [XmlElement(ElementName="Location", Order = 3)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the extended properties.
        /// </summary>
        /// <value>The extended properties.</value>
       
        [XmlArray(ElementName = "ExtendedProperties",Order=4)]
        [XmlArrayItem(ElementName = "ExtendedProperty")]
        public List<ExtendedProperty> ExtendedProperties { get; set; } 
    }
}
