using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleInstanceInstanceEndpoint
    {

        private string nameField;

        private string vipField;

        private string publicPortField;

        private string localPortField;

        private string protocolField;

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
        public string Vip
        {
            get
            {
                return this.vipField;
            }
            set
            {
                this.vipField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string PublicPort
        {
            get
            {
                return this.publicPortField;
            }
            set
            {
                this.publicPortField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string LocalPort
        {
            get
            {
                return this.localPortField;
            }
            set
            {
                this.localPortField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string Protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }
    }
}