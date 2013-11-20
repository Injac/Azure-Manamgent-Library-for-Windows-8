using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    /// <summary>
    /// Specifies the Virtual Hard-Disk data.
    /// </summary>
    public partial class HostedServiceDeploymentRoleDataVirtualHardDisks
    {
        private HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk dataVirtualHardDiskField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceDeploymentRoleDataVirtualHardDisks" /> class.
        /// </summary>
        public HostedServiceDeploymentRoleDataVirtualHardDisks()
        {
            this.dataVirtualHardDiskField = new HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk();
        }

        /// <summary>
        /// Contains the parameters that are used to add a data disk to a 
        /// Virtual Machine.
        /// </summary>
        /// <value>The data virtual hard disk.</value>
        [XmlElement(ElementName="DataVirtualHardDisk",Order = 0)]
        public HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk DataVirtualHardDisk
        {
            get
            {
                return this.dataVirtualHardDiskField;
            }
            set
            {
                this.dataVirtualHardDiskField = value;
            }
        }
    }
}