using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentDns
    {

        private List<HostedServiceDeploymentDnsDnsServer> dnsServersField;

        public HostedServiceDeploymentDns()
        {
            this.dnsServersField = new List<HostedServiceDeploymentDnsDnsServer>();
        }

        [XmlArray(Order = 0)]
        [XmlArrayItem("DnsServer", IsNullable = false)]
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