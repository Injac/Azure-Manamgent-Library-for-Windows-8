using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Directoryconfiguration is the direct child of
    /// DataSources and conatains the AbsolutePath 
    /// element.
    /// </summary>
  
    public partial class DirectoryConfiguration
    {

        private DirectoryAbsolute itemField;

        private string containerField;

        private uint directoryQuotaInMBField;

        public DirectoryConfiguration()
        {
            this.itemField = new DirectoryAbsolute();
            this.directoryQuotaInMBField = ((uint)(0));
        }

        /// <summary>
        /// Absolute Path.
        /// </summary>
        
        [XmlElement(ElementName = "Absolute")]
        public DirectoryAbsolute Item
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
        
        [XmlAttribute]
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
        
        [XmlAttribute]
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