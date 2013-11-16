using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "SpecialLogDirectory", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class SpecialLogDirectory
    {

        private string containerField;

        private uint directoryQuotaInMBField;

        public SpecialLogDirectory()
        {
            this.directoryQuotaInMBField = ((uint)(0));
        }

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

        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
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