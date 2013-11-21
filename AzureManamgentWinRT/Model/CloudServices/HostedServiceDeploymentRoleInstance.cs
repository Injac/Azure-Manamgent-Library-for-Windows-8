using System.Collections.Generic;
using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// A role instance in the instance list
    /// of the deployment.
    /// </summary>
    public partial class HostedServiceDeploymentRoleInstance
    {
        private string roleNameField;

        private string instanceNameField;

        private HostedServiceRoleInstanceStatus instanceStatusField;

        private string instanceUpgradeDomainField;

        private string instanceFaultDomainField;

        private VirtualMachineRoleSize instanceSizeField;

        private string instanceStateDetailsField;

        private string instanceErrorCodeField;

        private string ipAddressField;

        private List<HostedServiceDeploymentRoleInstanceInstanceEndpoint> instanceEndpointsField;

        private HostedServicePowerState powerStateField;

        private string hostNameField;

        private string remoteAccessCertificateThumbprintField;

        public HostedServiceDeploymentRoleInstance()
        {
            this.instanceEndpointsField = new List<HostedServiceDeploymentRoleInstanceInstanceEndpoint>();
        }

        /// <summary>
        /// Specifies the name of the role.
        /// </summary>
        /// <value>The name of the role.</value>
        [XmlElement(ElementName = "RoleName")]
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
        /// Specifies the name of a specific role intante, if an 
        /// instance of the role is running.
        /// </summary>
        /// <value>The name of the instance.</value>
        [XmlElement(ElementName = "InstanceName")]
        public string InstanceName
        {
            get
            {
                return this.instanceNameField;
            }
            set
            {
                this.instanceNameField = value;
            }
        }

        /// <summary>
        /// Specifies the current status of a role instance. 
        /// </summary>
        /// <value>The instance status.</value>
        [XmlElement(ElementName = "InstanceStatus")]
        public HostedServiceRoleInstanceStatus InstanceStatus
        {
            get
            {
                return this.instanceStatusField;
            }
            set
            {
                this.instanceStatusField = value;
            }
        }
        
        /// <summary>
        /// Specifies the update domain that the role instance 
        /// belongs to. Durin an upgrade deplyoment, all role
        /// instances in the same update domain are updated
        /// at the same time.
        /// </summary>
        /// <value>The instance upgrade domain.</value>
        [XmlElement(ElementName="InstanceUpgradeDomain")]
        public string InstanceUpgradeDomain
        {
            get
            {
                return this.instanceUpgradeDomainField;
            }
            set
            {
                this.instanceUpgradeDomainField = value;
            }
        }

        /// <summary>
        /// Specifies the fault domain that the role instance belongs
        /// to. Role instances that are part of the same fault domain
        /// may all be vulnerable to the failure of the the same piece
        /// of shared hardware.
        /// </summary>
        /// <value>The instance fault domain.</value>
        [XmlElement(ElementName = "InstanceFaultDomain")]
        public string InstanceFaultDomain
        {
            get
            {
                return this.instanceFaultDomainField;
            }
            set
            {
                this.instanceFaultDomainField = value;
            }
        }

        /// <summary>
        /// Specifies the size of the role instance.
        /// </summary>
        /// <value>The size of the instance.</value>
        [XmlElement(ElementName = "InsanceSize")]
        public VirtualMachineRoleSize InstanceSize
        {
            get
            {
                return this.instanceSizeField;
            }
            set
            {
                this.instanceSizeField = value;
            }
        }

        /// <summary>
        /// Provides a snapshot of the state of the role instance at
        /// the time that the operation was called.
        /// </summary>
        /// <value>The instance state details.</value>
        [XmlElement(ElementName = "InstanceStateDetails")]
        public string InstanceStateDetails
        {
            get
            {
                return this.instanceStateDetailsField;
            }
            set
            {
                this.instanceStateDetailsField = value;
            }
        }

        /// <summary>
        /// For Virtual Machines the error codes are: 
        /// WaitTimeout - The role insance did not communicate within 25 minutes. Typically this
        /// indicated that it did not start, or that the gues agent is not installed.
        /// VhdTooLarge - The VHD image selected was too large for the role instance.
        /// AzureInternalErrror - An internal error has occured, that has caused the
        /// role instance start. Contact support for additional assistance.
        /// For web and worker roles this field returns an error code
        /// that can be provided to Azure support.
        /// </summary>
        /// <value>The instance error code.</value>
        [XmlElement(ElementName = "InstanceErrorCode")]
        public string InstanceErrorCode
        {
            get
            {
                return this.instanceErrorCodeField;
            }
            set
            {
                this.instanceErrorCodeField = value;
            }
        }

        /// <summary>
        /// Specifies the IP-Address of the role instance (DIP)
        /// </summary>
        /// <value>The ip address.</value>
        [XmlElement(ElementName = "IpAddress")]
        public string IpAddress
        {
            get
            {
                return this.ipAddressField;
            }
            set
            {
                this.ipAddressField = value;
            }
        }

        /// <summary>
        /// Contains a list aof all endpoints for the role.
        /// </summary>
        /// <value>The instance endpoints.</value>
        [XmlElement(ElementName = "InstanceEndpoints")]
        public List<HostedServiceDeploymentRoleInstanceInstanceEndpoint> InstanceEndpoints
        {
            get
            {
                return this.instanceEndpointsField;
            }
            set
            {
                this.instanceEndpointsField = value;
            }
        }

        /// <summary>
        /// Indicates the running state of the role instance.
        /// </summary>
        /// <value>The state of the power.</value>
        [XmlElement(ElementName = "PowerState")]
        public HostedServicePowerState PowerState
        {
            get
            {
                return this.powerStateField;
            }
            set
            {
                this.powerStateField = value;
            }
        }

        /// <summary>
        /// Specifies the DNS host name of the cloud service in which
        /// the role instance is running. This element is
        /// listed for Virtual Machine deployments.
        /// </summary>
        /// <value>The name of the host.</value>
        [XmlElement(ElementName = "HostName")]
        public string HostName
        {
            get
            {
                return this.hostNameField;
            }
            set
            {
                this.hostNameField = value;
            }
        }

        /// <summary>
        /// Specifies the thumbprint of the RDP server certificate
        /// (Windows) or SSH server certificate (Linux). The thumbprint
        /// is only used for Virtual Machines that have been created from an 
        /// image.
        /// </summary>
        /// <value>The remote access certificate thumbprint.</value>
        [XmlElement(ElementName = "RemoteAccessCertificateThumbprint")]
        public string RemoteAccessCertificateThumbprint
        {
            get
            {
                return this.remoteAccessCertificateThumbprintField;
            }
            set
            {
                this.remoteAccessCertificateThumbprintField = value;
            }
        }
    }
}