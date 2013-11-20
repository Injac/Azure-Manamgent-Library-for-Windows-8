using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints
    {

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint inputEndpointField;

        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints()
        {
            this.inputEndpointField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint();
        }

        [XmlElement(Order = 0)]
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint InputEndpoint
        {
            get
            {
                return this.inputEndpointField;
            }
            set
            {
                this.inputEndpointField = value;
            }
        }
    }
}