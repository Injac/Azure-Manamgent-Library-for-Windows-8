using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/windowsazure")]
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSet
    {

        private string configurationSetTypeField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints inputEndpointsField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames subnetNamesField;

        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSet()
        {
            this.subnetNamesField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames();
            this.inputEndpointsField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints();
        }

        [XmlElement(Order = 0)]
        public string ConfigurationSetType
        {
            get
            {
                return this.configurationSetTypeField;
            }
            set
            {
                this.configurationSetTypeField = value;
            }
        }

        [XmlElement(Order = 1)]
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints InputEndpoints
        {
            get
            {
                return this.inputEndpointsField;
            }
            set
            {
                this.inputEndpointsField = value;
            }
        }

        [XmlElement(Order = 2)]
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames SubnetNames
        {
            get
            {
                return this.subnetNamesField;
            }
            set
            {
                this.subnetNamesField = value;
            }
        }
    }
}