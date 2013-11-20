using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
   
    public partial class SpecialLogDirectory
    {

        private string containerField;

        private uint directoryQuotaInMBField;

        public SpecialLogDirectory()
        {
            this.directoryQuotaInMBField = ((uint)(0));
        }

        
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

        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        
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