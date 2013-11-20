using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// DNS servers element.
    /// </summary>
    public partial class HostedServiceDeploymentDns
    {
        private List<HostedServiceDeploymentDnsDnsServer> dnsServersField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentDns" /> class.
        /// </summary>
        public HostedServiceDeploymentDns()
        {
            this.dnsServersField = new List<HostedServiceDeploymentDnsDnsServer>();
        }

        /// <summary>
        /// List of DNS servers.
        /// </summary>
        /// <value>The DNS servers.</value>
        [XmlElement(ElementName = "DnsServers", Order = 0)]
        public List<HostedServiceDeploymentDnsDnsServer> DnsServers
        {
            get
            {
                return this.dnsServersField;
            }
            set
            {
                this.dnsServersField = value;
            }
        }
    }
}