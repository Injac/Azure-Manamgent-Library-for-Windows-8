using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Specifies the deployments in the cloud service.
    /// </summary>
    
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

        private bool lockedField;

        private bool rollbackAllowedField;

        private DateTime createdTimeField;

        private DateTime lastModifiedTimeField;

        private string virtualNetworkNameField;

        private HostedServiceDeploymentDns dnsField;

        private List<HostedServiceDeploymentExtendedProperty> extendedPropertiesField;

        private HostedServiceDeploymentPersistentVMDowntime persistentVMDowntimeField;

        private List<HostedServiceDeploymentVirtualIP> virtualIPsField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeployment" /> class.
        /// </summary>
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

        /// <summary>
        /// Specifies the name of the deployment.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement(ElementName = "Name",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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
        /// Specifies the environment in which this deployment is running, 
        /// either staging or production.
        /// </summary>
        /// <value>The deployment slot.</value>
        [XmlElement(ElementName = "DeploymentSlot", Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the unique identifier for the deployment
        /// </summary>
        /// <value>The private ID.</value>
        [XmlElement(ElementName = "PrivateID",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the status of the deployment.Possible values are:
        /// Running, Suspended,RunningTransitioning,SupendedTransitioning,
        /// Starting,Suspending,Deploying,Deleting.
        /// </summary>
        /// <value>The status.</value>
        [XmlElement(ElementName = "Status",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the base-64-encoded identifier of the deployment. 
        /// The label can be used for your tracking purposes.
        /// </summary>
        /// <value>The label.</value>
        [XmlElement(ElementName="Label",Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the URL that can be used to access the cloud service.
        /// For example, if the service name is MyService you could access 
        /// the access the service by calling: http://MyService.cloudapp.net
        /// </summary>
        /// <value>The URL.</value>
        [XmlElement(ElementName="Url",Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the base-64-encoded configuration file of the deployment.
        /// You need this values to update the configuration of the cloud service.
        /// </summary>
        /// <value>The configuration.</value>
        [XmlElement(ElementName="Configuration")]
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

        /// <summary>
        /// Contains the list of role instances in the deployment.
        /// </summary>
        /// <value>The role instance list.</value>
        [XmlArray(ElementName = "RoleInstanceList")]
        [XmlArrayItem(ElementName = "RoleInstance")]
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

        /// <summary>
        /// Specifies information about an upgrade occurring on the deployment.
        /// </summary>
        /// <value>The upgrade status.</value>
        [XmlElement(ElementName = "UpgradeStatus",  IsNullable = true, Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the number of upgrade domains available to the cloud service.
        /// The UpgradeDomainCount element is only available using version 2011-06-01 or higher.
        /// </summary>
        /// <value>The upgrade domain count.</value>
        [XmlElement(ElementName = "UpgradeDomainCount",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Contains the list of roles in the deployment.
        /// </summary>
        /// <value>The role list.</value>
        [XmlArray(ElementName = "RoleList")]
        [XmlArrayItem(ElementName = "Role")]
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

        /// <summary>
        /// Specified the version of the Windows Azure SDK that was used to generate the package 
        /// for the deployment.The first two numerical components of the returned version represent
        ///  the version of the SDK that was used to create the package.The SdkVersion element is only 
        /// available using version 2011-06-01 or higher.
        /// </summary>
        /// <value>The SDK version.</value>
        [XmlElement(ElementName = "SdkVersion",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Indicates whether the deployment is locked for new write operations. 
        /// True if the deployment is locked because an existing operation is updating the deployment; 
        /// otherwise false.The Locked element is only available using version 2011-06-01 or higher.
        /// </summary>
        /// <value>The locked.</value>
        [XmlElement(ElementName = "Locked",  Namespace = "http://schemas.microsoft.com/windowsazure")]
        public bool Locked
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

        /// <summary>
        /// GIndicates whether the Rollback Update Or Upgrade operation is 
        /// allowed at this time. True if the operation is allowed; 
        /// otherwise false.
        /// </summary>
        /// <value>The rollback allowed.</value>
        [XmlElement(ElementName = "RollbackAllowed",  Namespace = "http://schemas.microsoft.com/windowsazure")]
        public bool RollbackAllowed
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

        /// <summary>
        /// Specifies the time that the deployment was created.
        /// </summary>
        /// <value>The created time.</value>
        [XmlElement(ElementName = "CreatedTime",  Namespace = "http://schemas.microsoft.com/windowsazure")]
        public DateTime CreatedTime
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

        /// <summary>
        /// Specifies the last time that the deployment was modified.
        /// </summary>
        /// <value>The last modified time.</value>
        [XmlElement(ElementName = "LastModifiedTime",  Namespace = "http://schemas.microsoft.com/windowsazure")]
        public DateTime LastModifiedTime
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

        /// <summary>
        /// Specifies the name of the Virtual Network 
        /// that the virtual machine connects to.The VirtualNetworkName element 
        /// is only available using version 2012-03-01 or higher.
        /// </summary>
        /// <value>The name of the virtual network.</value>
        [XmlElement(ElementName = "VirtualNetworkName",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the custom DNS settings that are specified for deployment.
        /// The Dns element is only available using version 2012-03-01 or higher.
        /// </summary>
        /// <value>The DNS.</value>
        [XmlElement(ElementName = "Dns",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Specifies the properties that are used to provide more information about a deployment.
        /// </summary>
        /// <value>The extended properties.</value>
        [XmlArray(ElementName = "ExtendedProperties")]
        [XmlArrayItem(ElementName = "ExtendedProperty")]
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

        /// <summary>
        /// GSpecifies information about when the Virtual Machine has been started and stopped.
        /// The PersistentVMDowntime element is only available using version 2012-03-01 or higher.
        /// </summary>
        /// <value>The persistent VM downtime.</value>
        [XmlElement(ElementName = "PersistentVMDowntime",  Namespace = "http://schemas.microsoft.com/windowsazure")]
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

        /// <summary>
        /// Contains the virtual IP addresses that are specified for the deployment.The VirtualIPs 
        /// element is only available using version 2012-03-01 or higher.
        /// </summary>
        /// <value>The virtual I ps.</value>
        [XmlArray(ElementName = "VirtualIPs")]
        [XmlArrayItem(ElementName = "VirtualIP")]
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