using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Holds the properties for a hosted service.
    /// </summary>
    public partial class HostedService
    {
        private string urlField;

        private string serviceNameField;

        private HostedServiceHostedServiceProperties hostedServicePropertiesField;

        private List<HostedServiceDeployment> deploymentsField;

        private string defaultWinRmCertificateThumbprintField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedService" /> class.
        /// </summary>
        public HostedService()
        {
            this.deploymentsField = new List<HostedServiceDeployment>();
            this.hostedServicePropertiesField = new HostedServiceHostedServiceProperties();
        }

        /// <summary>
        ///Specifies the URL that is assigned to the cloud 
        /// serivce.
        /// </summary>
        /// <value>The URL.</value>
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

        /// <summary>
        /// Specifies the name of the cloud service. This name 
        /// is the DNS prefix name and can be used to access 
        /// the cloud service.
        /// For example, if the cloud service name is MyService
        /// you could access the access the cloud service 
        /// by calling: http://MyService.cloudapp.net
        /// </summary>
        /// <value>The name of the service.</value>
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

        /// <summary>
        /// GSpecifies the properties that are assigned to the cloud service.
        /// </summary>
        /// <value>The hosted service properties.</value>
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

        /// <summary>
        /// Specifies the deployments in the cloud service.
        /// </summary>
        /// <value>The deployments.</value>
        [XmlElement(Namespace = "Deployments", Order = 3)]
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

        /// <summary>
        /// Specifies the SSL certificate thumbprint that was generated 
        /// when WinRM was defined with an HTTPS listener and a certificate 
        /// was not included in the definition. 
        /// The value of this property is read only and does not change 
        /// if a running role instance is updated to use a new SSL certificate.
        /// </summary>
        /// <value>The default win rm certificate thumbprint.</value>
        [XmlElement(ElementName = "DefaultWinRmCertificateThumbprint", Order = 4)]
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