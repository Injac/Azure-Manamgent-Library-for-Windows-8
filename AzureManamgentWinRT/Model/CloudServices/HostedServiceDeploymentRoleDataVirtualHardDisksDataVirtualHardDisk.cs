using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk
    {

        private string hostCachingField;

        private string diskNameField;

        private string lunField;

        private string logicalDiskSizeInGBField;

        private string mediaLinkField;

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
        public string Lun
        {
            get
            {
                return this.lunField;
            }
            set
            {
                this.lunField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string LogicalDiskSizeInGB
        {
            get
            {
                return this.logicalDiskSizeInGBField;
            }
            set
            {
                this.logicalDiskSizeInGBField = value;
            }
        }

        [XmlElement(Order = 4)]
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
    }
}