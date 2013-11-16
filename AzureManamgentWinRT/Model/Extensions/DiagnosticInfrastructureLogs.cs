using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Subelement of WadCfg
    /// </summary>
    [DataContract(Name = "DiagnosticInfrastructureLogs", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
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