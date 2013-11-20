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
        [XmlElement(Order = 0)]
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