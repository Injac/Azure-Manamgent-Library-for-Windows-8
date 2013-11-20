using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleOSVirtualHardDisk
    {

        private string hostCachingField;

        private string diskNameField;

        private string mediaLinkField;

        private string sourceImageNameField;

        private string osField;

        [XmlElement(Order = 0)]
        public string HostCaching
        {
            get
            {
                return this.hostCachingField;
            }
            set
            {
                this.hostCachingField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string DiskName
        {
            get
            {
                return this.diskNameField;
            }
            set
            {
                this.diskNameField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string MediaLink
        {
            get
            {
                return this.mediaLinkField;
            }
            set
            {
                this.mediaLinkField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string SourceImageName
        {
            get
            {
                return this.sourceImageNameField;
            }
            set
            {
                this.sourceImageNameField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string OS
        {
            get
            {
                return this.osField;
            }
            set
            {
                this.osField = value;
            }
        }
    }
}