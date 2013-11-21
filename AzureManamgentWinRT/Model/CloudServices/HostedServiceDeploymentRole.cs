using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains the list of role instances in the deployment.
    /// </summary>
    public partial class HostedServiceDeploymentRole
    {
        private string roleNameField;

        private string oSVersionField;

        private string roleTypeField;

        private List<HostedServiceDeploymentRoleConfigurationSets> configurationSetsField;

        private string availabilitySetNameField;

        private HostedServiceDeploymentRoleDataVirtualHardDisks dataVirtualHardDisksField;

        private HostedServiceDeploymentRoleOSVirtualHardDisk oSVirtualHardDiskField;

        private string roleSizeField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRole" /> class.
        /// </summary>
        public HostedServiceDeploymentRole()
        {
            this.oSVirtualHardDiskField = new HostedServiceDeploymentRoleOSVirtualHardDisk();
            this.dataVirtualHardDisksField = new HostedServiceDeploymentRoleDataVirtualHardDisks();
            this.configurationSetsField = new List<HostedServiceDeploymentRoleConfigurationSets>();
        }

        /// <summary>
        /// Specifies the name of the role.
        /// </summary>
        /// <value>The name of the role.</value>
        [XmlElement(ElementName="RoleName")]
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

        /// <summary>
        /// Specifies the version of the operating system on which the role instances are running
        /// </summary>
        /// <value>The OS version.</value>
        [XmlElement(ElementName="OsVersion")]
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

        /// <summary>
        /// Specifies the type of the role. This element is only listed for Virtual Machine 
        /// deployments and by default is PersistentVMRole.
        /// </summary>
        /// <value>The type of the role.</value>
        [XmlElement(ElementName="RoleType")]
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

        /// <summary>
        /// Contains a collection of values that represents system or
        /// application configuration settings.
        /// </summary>
        /// <value>The configuration sets.</value>
        [XmlArray(ElementName = "ConfigurationSets")]
        [XmlArrayItem("ConfigurationSet")]
       public List<HostedServiceDeploymentRoleConfigurationSets> ConfigurationSets
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

        /// <summary>
        /// Specifies the name of a collection of virtual machines.
        /// </summary>
        /// <value>The name of the availability set.</value>
        [XmlElement(ElementName = "AvailabilitySetName")]
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

        /// <summary>
        /// Contains the parameters that are used 
        /// to add a data disk to a Virtaul Machine.
        /// </summary>
        /// <value>The data virtual hard disks.</value>
        [XmlElement(ElementName="DataVirtualHardDisks")]
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

        /// <summary>
        /// Contains parameters that are used to add a data disk to 
        /// Virtual Machine.
        /// </summary>
        /// <value>The OS virtual hard disk.</value>
        [XmlElement(ElementName = "OSVirtualHardDisk")]
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

        /// <summary>
        /// Specifies the size of the role instance.
        /// </summary>
        /// <value>The size of the role.</value>
        [XmlElement(ElementName="RoleSize")]
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