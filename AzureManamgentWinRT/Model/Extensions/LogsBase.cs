using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WindowsEventLog))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerformanceCounters))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Logs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Directories))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiagnosticInfrastructureLogs))]
    [DataContract(Name = "LogsBase", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
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
        [DataMember]
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
        [DataMember]
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