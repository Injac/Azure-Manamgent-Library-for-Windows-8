using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRole
    {

        private string roleNameField;

        private string oSVersionField;

        private string roleTypeField;

        private HostedServiceDeploymentRoleConfigurationSets configurationSetsField;

        private string availabilitySetNameField;

        private HostedServiceDeploymentRoleDataVirtualHardDisks dataVirtualHardDisksField;

        private HostedServiceDeploymentRoleOSVirtualHardDisk oSVirtualHardDiskField;

        private string roleSizeField;

        public HostedServiceDeploymentRole()
        {
            this.oSVirtualHardDiskField = new HostedServiceDeploymentRoleOSVirtualHardDisk();
            this.dataVirtualHardDisksField = new HostedServiceDeploymentRoleDataVirtualHardDisks();
            this.configurationSetsField = new HostedServiceDeploymentRoleConfigurationSets();
        }

        [XmlElement(Order = 0)]
        public string RoleName
        {
            get
            {
                return this.roleNameField;
            }
            set
            {
                this.roleNameField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string OSVersion
        {
            get
            {
                return this.oSVersionField;
            }
            set
            {
                this.oSVersionField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string RoleType
        {
            get
            {
                return this.roleTypeField;
            }
            set
            {
                this.roleTypeField = value;
            }
        }

        [XmlElement(Order = 3)]
        public HostedServiceDeploymentRoleConfigurationSets ConfigurationSets
        {
            get
            {
                return this.configurationSetsField;
            }
            set
            {
                this.configurationSetsField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string AvailabilitySetName
        {
            get
            {
                return this.availabilitySetNameField;
            }
            set
            {
                this.availabilitySetNameField = value;
            }
        }

        [XmlElement(Order = 5)]
        public HostedServiceDeploymentRoleDataVirtualHardDisks DataVirtualHardDisks
        {
            get
            {
                return this.dataVirtualHardDisksField;
            }
            set
            {
                this.dataVirtualHardDisksField = value;
            }
        }

        [XmlElement(Order = 6)]
        public HostedServiceDeploymentRoleOSVirtualHardDisk OSVirtualHardDisk
        {
            get
            {
                return this.oSVirtualHardDiskField;
            }
            set
            {
                this.oSVirtualHardDiskField = value;
            }
        }

        [XmlElement(Order = 7)]
        public string RoleSize
        {
            get
            {
                return this.roleSizeField;
            }
            set
            {
                this.roleSizeField = value;
            }
        }
    }
}