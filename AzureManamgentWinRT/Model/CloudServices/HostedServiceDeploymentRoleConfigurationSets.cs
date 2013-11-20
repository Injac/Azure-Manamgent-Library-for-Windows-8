using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains a collection of values that represents system or application configuration settings.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/windowsazure")]
    public partial class HostedServiceDeploymentRoleConfigurationSets
    {

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSet configurationSetField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleConfigurationSets" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleConfigurationSets()
        {
            this.configurationSetField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSet();
        }

        /// <summary>
        /// Gets or sets the configuration set.
        /// </summary>
        /// <value>The configuration set.</value>
        [XmlElement(ElementName="ConfigurationSet",Order = 0)]
        public HostedServiceDeploymentRoleConfigurationSetsConfigurationSet ConfigurationSet
        {
            get
            {
                return this.configurationSetField;
            }
            set
            {
                this.configurationSetField = value;
            }
        }
    }
}