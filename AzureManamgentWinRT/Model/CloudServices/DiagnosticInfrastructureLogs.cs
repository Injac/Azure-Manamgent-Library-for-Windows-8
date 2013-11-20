using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Subelement of WadCfg
    /// </summary>
   
    public partial class DiagnosticInfrastructureLogs : LogsBase
    {

        private LogLevel scheduledTransferLogLevelFilterField;

        public DiagnosticInfrastructureLogs()
        {
            this.scheduledTransferLogLevelFilterField = LogLevel.Undefined;
        }

        /// <summary>
        /// Gets or sets the scheduled transfer log level filter.
        /// </summary>
        /// <value>The scheduled transfer log level filter.</value>
       
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