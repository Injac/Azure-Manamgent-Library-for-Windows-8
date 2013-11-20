using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Contains the parameters that are used to create the 
    /// operating system disk for a Virtual Machine.
    /// </summary>
    public partial class HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk
    {
        private HostedServiceHostCaching hostCachingField;

        private string diskNameField;

        private string lunField;

        private long logicalDiskSizeInGBField;

        private string mediaLinkField;

        /// <summary>
        /// Specifies the platform caching behaviour of the operting system
        /// disk blob for read/write efficiency. Possible values are: ReadOnly
        /// and ReadWrite.
        /// </summary>
        /// <value>The host caching.</value>
        [XmlElement(ElementName = "HostCaching", Order = 0)]
        public HostedServiceHostCaching HostCaching
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

        /// <summary>
        /// Specifies the name an opoerating system image in the image
        /// repository.
        /// </summary>
        /// <value>The name of the disk.</value>
        [XmlElement(ElementName = "DiskName", Order = 1)]
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

        /// <summary>
        /// Gets or sets the lun. The lun is a 
        /// Logical Unit Bumber for a disk drive.
        /// The LUN specifies the slot which the data drive apperears
        /// when mounted for usage by the Vritual Machine. This element
        /// is only listed when more than one data disk is attached.
        /// </summary>
        /// <value>The lun.</value>
        [XmlElement(ElementName = "Lun", Order = 2)]
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

        /// <summary>
        /// Specifies the logical disk size in GB.
        /// </summary>
        /// <value>The logical disk size in GB.</value>
        [XmlElement(ElementName = "LogicalDiskSizeInGB", Order = 3)]
        public long LogicalDiskSizeInGB
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

        /// <summary>
        /// Gets or sets the media link.
        /// </summary>
        /// <value>The media link.</value>
        [XmlElement(ElementName = "MediaLink", Order = 4)]
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