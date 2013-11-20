using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// An extended property you can set to add addional 
    /// metadata to an cloud service.
    /// </summary>
    public partial class HostedServiceHostedServicePropertiesExtendedProperty
    {
        private string nameField;

        private string valueField;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement(ElementName = "Name", Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlElement(ElementName = "Value", Order = 1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}