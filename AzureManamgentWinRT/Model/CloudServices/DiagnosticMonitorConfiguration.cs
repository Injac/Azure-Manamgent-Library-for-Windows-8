using System.ComponentModel;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// First sub-element of WadCfg, main element
    /// of the diagnostics monitor configuration.
    /// </summary>
    [DataContract(Name = "DiagnosticMonitorConfiguration", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class DiagnosticMonitorConfiguration
    {

        private DiagnosticInfrastructureLogs diagnosticInfrastructureLogsField;

        private Directories directoriesField;

        private Logs logsField;

        private PerformanceCounters performanceCountersField;

        private WindowsEventLog windowsEventLogField;

        private string configurationChangePollIntervalField;

        private uint overallQuotaInMBField;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticMonitorConfiguration" /> class.
        /// </summary>
        public DiagnosticMonitorConfiguration()
        {
            this.windowsEventLogField = new WindowsEventLog();
            this.performanceCountersField = new PerformanceCounters();
            this.logsField = new Logs();
            this.directoriesField = new Directories();
            this.diagnosticInfrastructureLogsField = new DiagnosticInfrastructureLogs();
            this.configurationChangePollIntervalField = "PT1M";
            this.overallQuotaInMBField = ((uint)(4000));
        }

        /// <summary>
        /// Gets or sets the diagnostic infrastructure logs.
        /// </summary>
        /// <value>The diagnostic infrastructure logs.</value>
        [DataMember]
        public DiagnosticInfrastructureLogs DiagnosticInfrastructureLogs
        {
            get
            {
                return this.diagnosticInfrastructureLogsField;
            }
            set
            {
                this.diagnosticInfrastructureLogsField = value;
            }
        }

        /// <summary>
        /// Gets or sets the directories.
        /// </summary>
        /// <value>The directories.</value>
        [DataMember]
        public Directories Directories
        {
            get
            {
                return this.directoriesField;
            }
            set
            {
                this.directoriesField = value;
            }
        }

        /// <summary>
        /// Gets or sets the logs.
        /// </summary>
        /// <value>The logs.</value>
        [DataMember]
        public Logs Logs
        {
            get
            {
                return this.logsField;
            }
            set
            {
                this.logsField = value;
            }
        }

        /// <summary>
        /// Gets or sets the performance counters.
        /// </summary>
        /// <value>The performance counters.</value>
        [DataMember]
        public PerformanceCounters PerformanceCounters
        {
            get
            {
                return this.performanceCountersField;
            }
            set
            {
                this.performanceCountersField = value;
            }
        }

        /// <summary>
        /// Gets or sets the windows event log.
        /// </summary>
        /// <value>The windows event log.</value>
        [DataMember]
        public WindowsEventLog WindowsEventLog
        {
            get
            {
                return this.windowsEventLogField;
            }
            set
            {
                this.windowsEventLogField = value;
            }
        }

        /// <summary>
        /// Gets or sets the configuration change poll interval.
        /// </summary>
        /// <value>The configuration change poll interval.</value>
        [DefaultValue("PT1M")]
        [DataMember]
        public string configurationChangePollInterval
        {
            get
            {
                return this.configurationChangePollIntervalField;
            }
            set
            {
                this.configurationChangePollIntervalField = value;
            }
        }

        /// <summary>
        /// Gets or sets the overall quota in MB.
        /// </summary>
        /// <value>The overall quota in MB.</value>
        [DefaultValue(typeof(uint), "4000")]
        [DataMember]
        public uint overallQuotaInMB
        {
            get
            {
                return this.overallQuotaInMBField;
            }
            set
            {
                this.overallQuotaInMBField = value;
            }
        }
    }
}