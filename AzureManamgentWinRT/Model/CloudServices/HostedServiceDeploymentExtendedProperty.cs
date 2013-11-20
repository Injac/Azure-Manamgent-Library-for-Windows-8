using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Extended cloud service properties.
    /// This properties have to be set manually
    /// and can be used to save specific metadata
    /// for every cloud service.
    /// </summary>
    public partial class HostedServiceDeploymentExtendedProperty
    {
        private string nameField;

        private string valueField;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement(Order = 0)]
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
        [XmlElement(Order = 1)]
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