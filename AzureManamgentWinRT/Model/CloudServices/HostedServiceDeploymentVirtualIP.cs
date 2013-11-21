using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// The virtual IP assigned to the service.
    /// </summary>
    public partial class HostedServiceDeploymentVirtualIP
    {
        private string addressField;

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [XmlElement(ElementName = "Address")]
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
        
        /// <summary>
        /// Gets or sets the is DNS programmed.
        /// </summary>
        /// <value>The is DNS programmed.</value>
        [XmlElement(ElementName = "IsDnsProgrammed")]
        public bool IsDnsProgrammed { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }
}