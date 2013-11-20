using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains a collection of values that represents system or application configuration settings.
    /// </summary>
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSet
    {
        private string configurationSetTypeField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints inputEndpointsField;

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames subnetNamesField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleConfigurationSetsConfigurationSet" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSet()
        {
            this.subnetNamesField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames();
            this.inputEndpointsField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints();
        }

        /// <summary>
        /// Specifies the configuration type for the configuration set.
        /// This is currently always set to NetworkConfiguration.
        /// </summary>
        /// <value>The type of the configuration set.</value>
        [XmlElement(ElementName = "ConfigurationSetType", Order = 0)]
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

        /// <summary>
        /// Contains a collection of external endpoints
        /// for a virtual machine.
        /// </summary>
        /// <value>The input endpoints.</value>
        [XmlElement(ElementName = "InputEndpoints", Order = 1)]
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

        /// <summary>
        /// Contains a list Virtual Network subnet names to which the
        /// deployment belongs.
        /// </summary>
        /// <value>The subnet names.</value>
        [XmlElement(ElementName = "SubnetNames", Order = 2)]
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