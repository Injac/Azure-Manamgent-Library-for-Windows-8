using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Specifies the subnet name for a 
    /// cloud service.
    /// </summary>
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames
    {
        private string subnetNameField;

        /// <summary>
        /// Gets or sets the name of the subnet.
        /// </summary>
        /// <value>The name of the subnet.</value>
        [XmlElement(ElementName = "SubnetName")]
        public string SubnetName
        {
            get
            {
                return this.subnetNameField;
            }
            set
            {
                this.subnetNameField = value;
            }
        }
    }
}