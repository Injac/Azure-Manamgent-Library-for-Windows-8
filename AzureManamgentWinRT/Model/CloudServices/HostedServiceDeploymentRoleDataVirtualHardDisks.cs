using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceDeploymentRoleDataVirtualHardDisks
    {

        private HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk dataVirtualHardDiskField;

        public HostedServiceDeploymentRoleDataVirtualHardDisks()
        {
            this.dataVirtualHardDiskField = new HostedServiceDeploymentRoleDataVirtualHardDisksDataVirtualHardDisk();
        }

        [XmlElement(Order = 0)]
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