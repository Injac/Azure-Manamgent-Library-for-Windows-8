using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe
    {

        private string pathField;

        private string portField;

        private string protocolField;

        [XmlElement(Order = 0)]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        [XmlElement(Order = 1)]
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

        [XmlElement(Order = 2)]
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
    }
}