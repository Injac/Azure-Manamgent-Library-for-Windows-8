using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeployment
    {

        private string nameField;

        private string deploymentSlotField;

        private string privateIDField;

        private string statusField;

        private string labelField;

        private string urlField;

        private string configurationField;

        private List<HostedServiceDeploymentRoleInstance> roleInstanceListField;

        private HostedServiceDeploymentUpgradeStatus upgradeStatusField;

        private string upgradeDomainCountField;

        private List<HostedServiceDeploymentRole> roleListField;

        private string sdkVersionField;

        private string lockedField;

        private string rollbackAllowedField;

        private string createdTimeField;

        private string lastModifiedTimeField;

        private string virtualNetworkNameField;

        private HostedServiceDeploymentDns dnsField;

        private List<HostedServiceDeploymentExtendedProperty> extendedPropertiesField;

        private HostedServiceDeploymentPersistentVMDowntime persistentVMDowntimeField;

        private List<HostedServiceDeploymentVirtualIP> virtualIPsField;

        public HostedServiceDeployment()
        {
            this.virtualIPsField = new List<HostedServiceDeploymentVirtualIP>();
            this.persistentVMDowntimeField = new HostedServiceDeploymentPersistentVMDowntime();
            this.extendedPropertiesField = new List<HostedServiceDeploymentExtendedProperty>();
            this.dnsField = new HostedServiceDeploymentDns();
            this.roleListField = new List<HostedServiceDeploymentRole>();
            this.upgradeStatusField = new HostedServiceDeploymentUpgradeStatus();
            this.roleInstanceListField = new List<HostedServiceDeploymentRoleInstance>();
        }

        [XmlElement(Order = 0)]
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

        [XmlElement(Order = 1)]
        public string DeploymentSlot
        {
            get
            {
                return this.deploymentSlotField;
            }
            set
            {
                this.deploymentSlotField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string PrivateID
        {
            get
            {
                return this.privateIDField;
            }
            set
            {
                this.privateIDField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        [XmlElement(Order = 5)]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        [XmlElement(Order = 6)]
        public string Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        [XmlArray(Order = 7)]
        [XmlArrayItem("RoleInstance", IsNullable = false)]
        public List<HostedServiceDeploymentRoleInstance> RoleInstanceList
        {
            get
            {
                return this.roleInstanceListField;
            }
            set
            {
                this.roleInstanceListField = value;
            }
        }

        [XmlElement(Order = 8)]
        public HostedServiceDeploymentUpgradeStatus UpgradeStatus
        {
            get
            {
                return this.upgradeStatusField;
            }
            set
            {
                this.upgradeStatusField = value;
            }
        }

        [XmlElement(Order = 9)]
        public string UpgradeDomainCount
        {
            get
            {
                return this.upgradeDomainCountField;
            }
            set
            {
                this.upgradeDomainCountField = value;
            }
        }

        [XmlArray(Order = 10)]
        [XmlArrayItem("Role", IsNullable = false)]
        public List<HostedServiceDeploymentRole> RoleList
        {
            get
            {
                return this.roleListField;
            }
            set
            {
                this.roleListField = value;
            }
        }

        [XmlElement(Order = 11)]
        public string SdkVersion
        {
            get
            {
                return this.sdkVersionField;
            }
            set
            {
                this.sdkVersionField = value;
            }
        }

        [XmlElement(Order = 12)]
        public string Locked
        {
            get
            {
                return this.lockedField;
            }
            set
            {
                this.lockedField = value;
            }
        }

        [XmlElement(Order = 13)]
        public string RollbackAllowed
        {
            get
            {
                return this.rollbackAllowedField;
            }
            set
            {
                this.rollbackAllowedField = value;
            }
        }

        [XmlElement(Order = 14)]
        public string CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
            }
        }

        [XmlElement(Order = 15)]
        public string LastModifiedTime
        {
            get
            {
                return this.lastModifiedTimeField;
            }
            set
            {
                this.lastModifiedTimeField = value;
            }
        }

        [XmlElement(Order = 16)]
        public string VirtualNetworkName
        {
            get
            {
                return this.virtualNetworkNameField;
            }
            set
            {
                this.virtualNetworkNameField = value;
            }
        }

        [XmlElement(Order = 17)]
        public HostedServiceDeploymentDns Dns
        {
            get
            {
                return this.dnsField;
            }
            set
            {
                this.dnsField = value;
            }
        }

        [XmlArray(Order = 18)]
        [XmlArrayItem("ExtendedProperty", IsNullable = false)]
        public List<HostedServiceDeploymentExtendedProperty> ExtendedProperties
        {
            get
            {
                return this.extendedPropertiesField;
            }
            set
            {
                this.extendedPropertiesField = value;
            }
        }

        [XmlElement(Order = 19)]
        public HostedServiceDeploymentPersistentVMDowntime PersistentVMDowntime
        {
            get
            {
                return this.persistentVMDowntimeField;
            }
            set
            {
                this.persistentVMDowntimeField = value;
            }
        }

        [XmlArray(Order = 20)]
        [XmlArrayItem("VirtualIP", IsNullable = false)]
        public List<HostedServiceDeploymentVirtualIP> VirtualIPs
        {
            get
            {
                return this.virtualIPsField;
            }
            set
            {
                this.virtualIPsField = value;
            }
        }
    }
}