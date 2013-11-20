using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// External endpoint for a
    /// Virtual Machine.
    /// </summary>
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints
    {
        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint inputEndpointField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints()
        {
            this.inputEndpointField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpointsInputEndpoint();
        }

        /// <summary>
        /// Gets or sets the input endpoint.
        /// </summary>
        /// <value>The input endpoint.</value>
        [XmlElement(ElementName="InputEndpoint",Order = 0)]
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