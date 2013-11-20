using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WindowsEventLog))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerformanceCounters))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Logs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Directories))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiagnosticInfrastructureLogs))]
 
    
    public partial class LogsBase
    {

        private uint bufferQuotaInMBField;

        private string scheduledTransferPeriodField;

        public LogsBase()
        {
            this.bufferQuotaInMBField = ((uint)(0));
            this.scheduledTransferPeriodField = "PT0S";
        }

        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
       
        [XmlAttribute]
        public uint bufferQuotaInMB
        {
            get
            {
                return this.bufferQuotaInMBField;
            }
            set
            {
                this.bufferQuotaInMBField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute("PT0S")]
        
        [XmlAttribute]
        public string scheduledTransferPeriod
        {
            get
            {
                return this.scheduledTransferPeriodField;
            }
            set
            {
                this.scheduledTransferPeriodField = value;
            }
        }
    }
}