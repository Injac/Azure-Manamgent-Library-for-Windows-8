using System.ComponentModel;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Directoryconfiguration is the direct child of
    /// DataSources and conatains the AbsolutePath 
    /// element.
    /// </summary>
    [DataContract(Name = "DirectoryConfiguration", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class DirectoryConfiguration
    {

        private DirectoryBase itemField;

        private string containerField;

        private uint directoryQuotaInMBField;

        public DirectoryConfiguration()
        {
            this.itemField = new DirectoryBase();
            this.directoryQuotaInMBField = ((uint)(0));
        }

        /// <summary>
        /// Absolute Path.
        /// </summary>
        [DataMember]
        public DirectoryBase Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        /// Storage container.
        /// </summary>
        [DataMember]
        public string container
        {
            get
            {
                return this.containerField;
            }
            set
            {
                this.containerField = value;
            }
        }

        /// <summary>
        /// Directory quota for the 
        /// storage container in MB.
        /// </summary>
        [DefaultValue(typeof(uint), "0")]
        [DataMember]
        public uint directoryQuotaInMB
        {
            get
            {
                return this.directoryQuotaInMBField;
            }
            set
            {
                this.directoryQuotaInMBField = value;
            }
        }
    }
}