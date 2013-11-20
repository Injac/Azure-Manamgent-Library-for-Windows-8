using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames
    {

        private string subnetNameField;

        [XmlElement(Order = 0)]
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