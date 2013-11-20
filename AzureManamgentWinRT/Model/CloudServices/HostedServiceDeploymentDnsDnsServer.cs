using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Represents a DNS server assigned to a 
    /// cloud service.
    /// </summary>
    public partial class HostedServiceDeploymentDnsDnsServer
    {
        private string nameField;

        private string addressField;

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
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [XmlElement(Order = 1)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }
}