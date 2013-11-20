using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentUpgradeStatus
    {

        private string upgradeTypeField;

        private string currentUpgradeDomainStateField;

        private string currentUpgradeDomainField;

        [XmlElement(Order = 0)]
        public string UpgradeType
        {
            get
            {
                return this.upgradeTypeField;
            }
            set
            {
                this.upgradeTypeField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string CurrentUpgradeDomainState
        {
            get
            {
                return this.currentUpgradeDomainStateField;
            }
            set
            {
                this.currentUpgradeDomainStateField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string CurrentUpgradeDomain
        {
            get
            {
                return this.currentUpgradeDomainField;
            }
            set
            {
                this.currentUpgradeDomainField = value;
            }
        }
    }
}