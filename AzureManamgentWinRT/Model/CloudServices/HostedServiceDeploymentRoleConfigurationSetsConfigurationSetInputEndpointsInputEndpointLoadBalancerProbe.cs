using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains the endpoint settings which the Windows Azure load balancer uses to monitor the availability of a 
    /// Virtual Machine before forwarding traffic to the endpoint.
    /// </summary>
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe
    {
        private string pathField;

        private string portField;

        private HostedServiceProtocolType protocolField;

        /// <summary>
        /// Specifies the realtive path name to inspect to determine the availability
        /// status. If Protocol is set to TCP, this value MUST be NULL.
        /// Example: path. The propbe will use https://example.com/path to perform the probe.
        /// </summary>
        /// <value>The path.</value>
        [XmlElement(ElementName = "Path", Order = 0)]
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

        /// <summary>
        /// Specifies the port to usde to inspect the avaialability status.
        /// </summary>
        /// <value>The port.</value>
        [XmlElement(ElementName = "Port", Order = 1)]
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

        /// <summary>
        /// Specifies the protocol to use to inspect hte availability status.
        /// Possible values are HTTP, TCP.
        /// </summary>
        /// <value>The protocol.</value>
        [XmlElement(ElementName = "Protocol", Order = 2)]
        public HostedServiceProtocolType Protocol
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