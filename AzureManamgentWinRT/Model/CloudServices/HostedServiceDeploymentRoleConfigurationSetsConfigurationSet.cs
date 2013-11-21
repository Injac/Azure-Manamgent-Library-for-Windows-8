using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains a collection of values that represents system or application configuration settings.
    /// </summary>
    [XmlType(AnonymousType = false, Namespace = "http://schemas.microsoft.com/windowsazure",TypeName = "NetworkConfigurationSet")]
    public partial class HostedServiceDeploymentRoleConfigurationSetsConfigurationSet
    {
        private string configurationSetTypeField;

        private List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints> inputEndpointsField;

        private List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames> subnetNamesField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleConfigurationSetsConfigurationSet" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSet()
        {
            this.subnetNamesField = new List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames>();
            this.inputEndpointsField = new List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints>();
        }

        /// <summary>
        /// Specifies the configuration type for the configuration set.
        /// This is currently always set to NetworkConfiguration.
        /// </summary>
        /// <value>The type of the configuration set.</value>
        [XmlElement(ElementName = "ConfigurationSetType")]
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
        [XmlElement(ElementName = "InputEndpoints")]
        public List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetInputEndpoints> InputEndpoints
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
        [XmlArray(ElementName = "SubnetNames")]
        [XmlArrayItem(ElementName = "SubnetName")]
        public List<HostedServiceDeploymentRoleConfigurationSetsConfigurationSetSubnetNames> SubnetNames
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