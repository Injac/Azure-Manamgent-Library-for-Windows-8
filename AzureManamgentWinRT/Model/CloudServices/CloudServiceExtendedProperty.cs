using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// Represents an extended property entry.
    /// </summary>
    
    public class ExtendedProperty
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
       [XmlElement(ElementName = "Name",Order = 0)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlElement(ElementName = "Value",Order = 1)]
        public string Value { get; set; }
    }
}
