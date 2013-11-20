using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint
    {

        private string loadBalancedEndpointSetNameField;

        private string localPortField;

        private string nameField;

        private string portField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe loadBalancerProbeField;

        private string protocolField;

        private string vipField;

        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint()
        {
            this.loadBalancerProbeField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe();
        }

        [XmlElement(Order = 0)]
        public string LoadBalancedEndpointSetName
        {
            get
            {
                return this.loadBalancedEndpointSetNameField;
            }
            set
            {
                this.loadBalancedEndpointSetNameField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string LocalPort
        {
            get
            {
                return this.localPortField;
            }
            set
            {
                this.localPortField = value;
            }
        }

        [XmlElement(Order = 2)]
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

        [XmlElement(Order = 3)]
        public string Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        [XmlElement(Order = 4)]
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe LoadBalancerProbe
        {
            get
            {
                return this.loadBalancerProbeField;
            }
            set
            {
                this.loadBalancerProbeField = value;
            }
        }

        [XmlElement(Order = 5)]
        public string Protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        [XmlElement(Order = 6)]
        public string Vip
        {
            get
            {
                return this.vipField;
            }
            set
            {
                this.vipField = value;
            }
        }
    }
}