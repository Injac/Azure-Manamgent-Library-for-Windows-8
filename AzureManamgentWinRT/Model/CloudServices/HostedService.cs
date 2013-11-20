using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedService
    {

        private string urlField;

        private string serviceNameField;

        private HostedServiceHostedServiceProperties hostedServicePropertiesField;

        private List<HostedServiceDeployment> deploymentsField;

        private string defaultWinRmCertificateThumbprintField;

        public HostedService()
        {
            this.deploymentsField = new List<HostedServiceDeployment>();
            this.hostedServicePropertiesField = new HostedServiceHostedServiceProperties();
        }

        [XmlElement(Order = 0)]
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

        [XmlElement(Order = 1)]
        public string ServiceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }

        [XmlElement(Order = 2)]
        public HostedServiceHostedServiceProperties HostedServiceProperties
        {
            get
            {
                return this.hostedServicePropertiesField;
            }
            set
            {
                this.hostedServicePropertiesField = value;
            }
        }

        [XmlArray(Order = 3)]
        [XmlArrayItem("Deployment", IsNullable = false)]
        public List<HostedServiceDeployment> Deployments
        {
            get
            {
                return this.deploymentsField;
            }
            set
            {
                this.deploymentsField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string DefaultWinRmCertificateThumbprint
        {
            get
            {
                return this.defaultWinRmCertificateThumbprintField;
            }
            set
            {
                this.defaultWinRmCertificateThumbprintField = value;
            }
        }
    }
}