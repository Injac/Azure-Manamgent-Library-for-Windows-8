using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Detailed version of an 
    /// Instance endpoint.
    /// </summary>
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint
    {
        private string loadBalancedEndpointSetNameField;

        private string localPortField;

        private string nameField;

        private string portField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe loadBalancerProbeField;

        private HostedServiceProtocolType protocolField;

        private string vipField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint()
        {
            this.loadBalancerProbeField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpointLoadBalancerProbe();
        }

        /// <summary>
        /// Specifies a name of a set of load-balanced endpoints.
        /// This element is only listed for Virtual Machine
        /// deployments.
        /// </summary>
        /// <value>The name of the load balanced endpoint set.</value>
        [XmlElement(ElementName = "LoadBalancedEndpointSetName", Order = 0)]
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

        /// <summary>
        /// Specifies the internal port on which the Virtual Machine is
        /// listening to server the endpoint. This element is only 
        /// listed for VirtualMachine deployments.
        /// </summary>
        /// <value>The local port.</value>
        [XmlElement(ElementName = "LocalPort", Order = 1)]
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

        /// <summary>
        /// Specifies the name of the external endpoint.
        /// This element is only listed for Virtual Machine
        /// deployments.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement(ElementName = "Name", Order = 2)]
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
        /// Specifies the external port to use for the
        /// endpoint.
        /// </summary>
        /// <value>The port.</value>
        [XmlElement(ElementName = "Port", Order = 3)]
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
        /// Contains the endpoint settings which the Windows
        /// Azure load balance uses to monitor the availabitlity ofa
        /// Virtual Machine, before forwarding the trafiic to the
        /// endpoint.
        /// </summary>
        /// <value>The load balancer probe.</value>
        [XmlElement(ElementName = "LoadBalancerProbe", Order = 4)]
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

        /// <summary>
        ///Specifies the transport protocol for the endpoint.
        /// Possible values are UDP or TCP.
        /// </summary>
        /// <value>The protocol.</value>
        [XmlElement(ElementName="Protocol",Order = 5)]
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

        /// <summary>
        /// Specifies the virtual IP address for the endpoint.
        /// </summary>
        /// <value>The vip.</value>
        [XmlElement(ElementName = "Vip", Order = 6)]
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