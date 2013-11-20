using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/windowsazure")]
    public partial class HostedServiceDeploymentRoleConfigurationSets
    {

        private HostedServiceDeploymentRoleConfigurationSetsConfigurationSet configurationSetField;

        public HostedServiceDeploymentRoleConfigurationSets()
        {
            this.configurationSetField = new HostedServiceDeploymentRoleConfigurationSetsConfigurationSet();
        }

        [XmlElement(Order = 0)]
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