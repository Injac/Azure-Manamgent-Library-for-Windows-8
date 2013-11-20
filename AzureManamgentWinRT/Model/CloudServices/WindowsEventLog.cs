using System.Collections.Generic;
using System.Runtime.Serialization;
///Handling windows event logging using Azure Diagnostics
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
   
    public partial class WindowsEventLog : LogsBase
    {

        private List<DataSource> dataSourceField;

        private LogLevel scheduledTransferLogLevelFilterField;

        public WindowsEventLog()
        {
            this.dataSourceField = new List<DataSource>();
            this.scheduledTransferLogLevelFilterField = LogLevel.Undefined;
        }

        
        [XmlElement]
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
        
        [XmlAttribute]
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