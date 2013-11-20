using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleInstance
    {

        private string roleNameField;

        private string instanceNameField;

        private string instanceStatusField;

        private string instanceUpgradeDomainField;

        private string instanceFaultDomainField;

        private string instanceSizeField;

        private string instanceStateDetailsField;

        private string instanceErrorCodeField;

        private string ipAddressField;

        private List<HostedServiceDeploymentRoleInstanceInstanceEndpoint> instanceEndpointsField;

        private string powerStateField;

        private string hostNameField;

        private string remoteAccessCertificateThumbprintField;

        public HostedServiceDeploymentRoleInstance()
        {
            this.instanceEndpointsField = new List<HostedServiceDeploymentRoleInstanceInstanceEndpoint>();
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

        [XmlElement(Order = 2)]
        public string InstanceStatus
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

        [XmlElement(Order = 3)]
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

        [XmlElement(Order = 4)]
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

        [XmlElement(Order = 5)]
        public string InstanceSize
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

        [XmlElement(Order = 6)]
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

        [XmlElement(Order = 7)]
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

        [XmlElement(Order = 8)]
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

        [XmlArray(Order = 9)]
        [XmlArrayItem("InstanceEndpoint", IsNullable = false)]
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

        [XmlElement(Order = 10)]
        public string PowerState
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

        [XmlElement(Order = 11)]
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

        [XmlElement(Order = 12)]
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