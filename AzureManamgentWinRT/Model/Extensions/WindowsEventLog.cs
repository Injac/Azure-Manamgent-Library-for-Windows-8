using System.Collections.Generic;
using System.Runtime.Serialization;

///Handling windows event logging using Azure Diagnostics
namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "WindowsEventLog", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class WindowsEventLog : LogsBase
    {

        private List<DataSource> dataSourceField;

        private LogLevel scheduledTransferLogLevelFilterField;

        public WindowsEventLog()
        {
            this.dataSourceField = new List<DataSource>();
            this.scheduledTransferLogLevelFilterField = LogLevel.Undefined;
        }

        [DataMember]
        public List<DataSource> DataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(LogLevel.Undefined)]
        [DataMember]
        public LogLevel scheduledTransferLogLevelFilter
        {
            get
            {
                return this.scheduledTransferLogLevelFilterField;
            }
            set
            {
                this.scheduledTransferLogLevelFilterField = value;
            }
        }
    }
}