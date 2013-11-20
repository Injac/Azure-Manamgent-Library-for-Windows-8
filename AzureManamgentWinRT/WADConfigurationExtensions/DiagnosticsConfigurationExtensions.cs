using AzureManamgentWinRT.Models.ConfDiag.Public;

namespace AzureManamgentWinRT.WADConfigurationExtensions
{
    /// <summary>
    /// Extension methods to chain the configuration
    /// of the public diagnostics element.
    /// </summary>
    public static class DiagnosticsConfigurationExtensions
    {
        /// <summary>
        /// Adds the storage account.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="connectionQualifiers">The connection qualifiers.</param>
        /// <param name="defaultEndpointsProtocol">The default endpoints protocol.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig AddStorageAccount(this PublicDiagnosticsConfig config,
            string connectionQualifiers, string defaultEndpointsProtocol, string name)
        { 
            config.StorageAccount = new StorageAccount()
            {
                ConnectionQualifiers = connectionQualifiers,
                DefaultEndpointsProtocol = defaultEndpointsProtocol,
                Name = name
            };

            return config;
        }

        /// <summary>
        /// Adds the WadCfg element to the configuration.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig AddWadCfg(this PublicDiagnosticsConfig config)
        {
            config.WadCfg = new PublicConfigWadCfg();

            return config;
        }

        /// <summary>
        /// Adds the diagnostics monitor configuration.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="configurationChangePollINterval">
        /// Optional. Specifies the interval at which the diagnostic monitor polls for diagnostic configuration changes.
        /// The default is PT1M.  
        /// If you need more informations about the interval format, please see
        /// http://en.wikipedia.org/wiki/ISO_8601 (section durations)
        ///</param>
        /// <param name="overallQuotaInMB">
        /// Optional. The total amount of file system storage allocated for all logging buffers.
        /// The default is 4000 MB and if you provide a value for this attribute, it must not exceed this amount.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig AddDiagnosticsMonitorConfiguration(this PublicDiagnosticsConfig config,
            string configurationChangePollINterval, uint overallQuotaInMB)
        {
            config.WadCfg.DiagnosticMonitorConfiguration = new DiagnosticMonitorConfiguration()
            {
                configurationChangePollInterval = configurationChangePollINterval,
                overallQuotaInMB = overallQuotaInMB
            };

            return config;
        }

        /// <summary>
        /// Adds the WindowsEventLog element to the configuration.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="scheduledTransferLogLevelFilter">
        /// Optional. Specifies the minimum severity level for log entries that are transferred. T
        /// the default value is Undefined. Other possible values are Verbose, Information, Warning, Error, and Critical.
        /// <param name="bufferQuotaInMB">
        /// Optional. Specifies the maximum amount of file system storage that is available for the specified data.
        /// The default is 0.
        /// </param>
        /// <param name="scheduledTransferPeriod">
        /// Optional. Specifies the interval between scheduled transfers of data, rounded up to the nearest minute.
        /// The default is PT0S.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnosticsMonitorConfAddWindowsEventLog(this PublicDiagnosticsConfig config,
            LogLevel scheduledTransferLogLevelFilter, uint bufferQuotaInMB, string scheduledTransferPeriod)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.WindowsEventLog = new WindowsEventLog()
            {
                bufferQuotaInMB = bufferQuotaInMB,
                scheduledTransferLogLevelFilter = scheduledTransferLogLevelFilter,
                scheduledTransferPeriod = scheduledTransferPeriod
            };
            var sb = new System.Text.StringBuilder(194);
            
            return config;
        }

        /// <summary>
        /// Adds a DataSource element to the WindowsEventLog element.
        /// The DataSource element defines the event log to monitor. The parent of this element is the 
        /// WindowsEventLog element.
        /// Required. An XPath expression specifying the log to collect.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnosticMonitorConfAddWindowsEventLogItem(this PublicDiagnosticsConfig config,
            string name)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.WindowsEventLog.DataSource.Add(new DataSource()
            {
                name = name
            });

            return config;
        }

        /// <summary>
        /// Adds a PerformanceCounters element to the configuration.
        /// The PerformanceCounters element defines the path to the performance counter to collect. The parent of this element is
        /// the DiagnosticsMonitorConfiguration Element. This element tis the parent elemetn of the PerformanceCounterConfiguration
        /// element.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="bufferQuotaInMB">
        /// Optional. Specified the maximum amount of file system storage that is available for the specified data. The default is 0.
        /// </param>
        /// <param name="scheduledTransferPeriod">
        /// Optional. Specifies the interval between scheduled transfers of data, rounded up to the nearest minute. The default is
        /// PT0S.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnosticsMonitorConfAddPerformanceCounters(this PublicDiagnosticsConfig config,
            uint bufferQuotaInMB, string scheduledTransferPeriod)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.PerformanceCounters = new PerformanceCounters()
            {
                bufferQuotaInMB = bufferQuotaInMB,
                scheduledTransferPeriod = scheduledTransferPeriod
            };

            return config;
        }

        /// <summary>
        /// Adds a PerformanceCountersConfigurationItem
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="counterSpecifier">The counter specifier.</param>
        /// <param name="sampleRate">The sample rate.</param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig PerformanceCountersAddPerfCounterConfigItem(this PublicDiagnosticsConfig config,
            string counterSpecifier, string sampleRate)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.PerformanceCounters.PerformanceCounterConfiguration.Add(
                new PerformanceCounterConfiguration()
                {
                    counterSpecifier = counterSpecifier,
                    sampleRate = sampleRate
                });

            return config;
        }

        /// <summary>
        /// Adds a Logs element
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="scheduledTransferLogLevelFilter">The scheduled transfer log level filter.</param>
        /// <param name="bufferQuotaInMB">
        /// Optional. Specifies the maximum amount of file system storage that is available for the specified data. The default is 0.
        /// </param>
        /// <param name="scheduledTransferPeriod">
        /// Optional. Specifies the minimum severity level for log entries that are transferred. 
        /// The default value is Undefined. Other possible values are Verbose, Information, Warning, Error, and Critical.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnosticsMonitorConfAddLogs(this PublicDiagnosticsConfig config,
            LogLevel scheduledTransferLogLevelFilter, uint bufferQuotaInMB, string scheduledTransferPeriod)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Logs = new Logs()
            {
                bufferQuotaInMB = bufferQuotaInMB,
                scheduledTransferPeriod = scheduledTransferPeriod,
                scheduledTransferLogLevelFilter = scheduledTransferLogLevelFilter
            };

            return config;
        }

        /// <summary>
        /// Add a Directories Element
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="bufferQuotaInMB">
        /// Optional. Specifies the maximum amount of file system storage that is available for the specified data. The default is 0.
        /// </param>
        /// <param name="scheduledTransferPeriod">
        /// Optional. Specifies the interval between scheduled transfers of data, rounded up to the nearest minute. The default is
        /// PT0S.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnosticsMonitorConfAddDirectories(this PublicDiagnosticsConfig config,
            uint bufferQuotaInMB, string scheduledTransferPeriod)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Directories = new Directories()
            {
                bufferQuotaInMB = bufferQuotaInMB,
                scheduledTransferPeriod = scheduledTransferPeriod
                
            };

            return config;
        }

        /// <summary>
        /// Adds a DirectoryConfiguration Element.
        /// The DataSources element defines zero or more additional log directories. The parent of this element is the Directories Element.
        ///  This element is the parent element of the DirectoryConfiguration Element. This method adds DirectoryConfiguration elements
        /// to the DataSources element.
        /// **DirectoryConfiguration Element*
        /// The DirectoryConfiguration element defines the directory of log files to monitor. The parent of this element is the DataSources Element. 
        /// This element is the parent element of the Absolute Element and LocalResource Elementt.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="container">
        /// The name of the container where the contents of the directory is to be transferred.
        /// </param>
        /// <param name="directoryQuotaInMB">
        /// Optional. Specifies the maximum amount of file system storage that is available for the specified data. Default is 0.
        /// </param>
        /// <param name="path">The path.</param>
        /// <param name="expandEnvironment">The expand environment.</param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DirectoriesAddDataSourcesItem(this PublicDiagnosticsConfig config,
            string container, uint directoryQuotaInMB, string path, bool expandEnvironment)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Directories.DataSources.Add(new DirectoryConfiguration()
            {
                Item = new DirectoryAbsolute()
                {
                    expandEnvironment = expandEnvironment,
                    path = path
                },
                container = container
            });

            return config;
        }

        /// <summary>
        /// Adds a CrashDumps element
        /// The CrashDumps element defines the crash dumps directory. The parent of this element is the Directories Element.
        /// The following table describes the attributes of the CrashDumps element
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="container">
        /// The name of the container where the contents of the directory is to be transferred.
        /// </param>
        /// <param name="directoryQuotaInMB">
        /// Optional. Specifies the maximum size of the directory in megabytes. The default is 0.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DirectoriesAddCrashDumps(this PublicDiagnosticsConfig config,
            string container, uint directoryQuotaInMB)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Directories.CrashDumps = new SpecialLogDirectory()
            {
                container = container,
                directoryQuotaInMB = directoryQuotaInMB
            };
            
            return config;
        }

        /// <summary>
        /// Adds a FailedRequestLogs Element.
        /// Diagnosticses the monitor conf performance counters logs directories add failed request logs.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="container">
        /// The name of the container where the contents of the directory is to be transferred.
        /// </param>
        /// <param name="directoryQuotaInMB">
        /// Optional. Specifies the maximum size of the directory in megabytes. The default is 0.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DirectoriesAddFailedRequestLogs(this PublicDiagnosticsConfig config, string container, uint directoryQuotaInMB)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Directories.FailedRequestLogs = new SpecialLogDirectory()
            {
                container = container,
                directoryQuotaInMB = directoryQuotaInMB
            };

            return config;
        }

        /// <summary>
        /// Adds an IISLogs element
        /// The IISLogs element defines the IIS log directory. The parent of this element is the Directories Element.
        /// The following table describes the attributes of the IISLogs element.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="container">
        /// The name of the container where the contents of the directory is to be transferred.The default is 0.
        /// </param>
        /// <param name="directoryQuotaInMB">
        /// Optional. Specifies the maximum size of the directory in megabytes.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DirectoriesAddIISLogs(this PublicDiagnosticsConfig config, string container, uint directoryQuotaInMB)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.Directories.IISLogs = new SpecialLogDirectory()
            {
                container = container,
                directoryQuotaInMB = directoryQuotaInMB
            };

            return config;
        }

        /// <summary>
        /// Adds an Diagnostics infrastructureLogs element.
        /// The DiagnosticInfrastructureLogs element defines the buffer configuration for the logs that are generated by the underlying diagnostics 
        /// infrastructure. The parent of this element is the DiagnosticMonitorConfiguration Element.
        /// </summary>
        /// <param name="config">The config.</param>
        /// <param name="container">
        /// The name of the container where the contents of the directory is to be transferred.The default is 0.
        /// </param>
        /// <param name="scheduledTransferLogLevelFilter">
        /// Optional. Specifies the minimum severity level for log entries that are transferred. 
        /// The default value is Undefined. Other possible values are Verbose, Information, 
        /// Warning, Error, and Critical.
        /// </param>
        /// <param name="bufferQuotaInMB">
        /// Optional. Specifies the maximum amount of file system storage that is available for 
        /// the specified data.
        /// The default is 0.
        /// </param>
        /// <param name="scheduledTransferPeriod">
        /// Optional. Specifies the interval between scheduled transfers of data, rounded up to
        /// the nearest minute. The default is PT0S.
        /// </param>
        /// <returns></returns>
        public static PublicDiagnosticsConfig DiagnostictsMonoitorConfigurationAddDiagnosticsInfrastructureLogs(this PublicDiagnosticsConfig config,
            LogLevel scheduledTransferLogLevelFilter, uint bufferQuotaInMB, string scheduledTransferPeriod)
        {
            config.WadCfg.DiagnosticMonitorConfiguration.DiagnosticInfrastructureLogs = new DiagnosticInfrastructureLogs()
            {
                scheduledTransferLogLevelFilter = scheduledTransferLogLevelFilter,
                bufferQuotaInMB = bufferQuotaInMB,
                scheduledTransferPeriod = scheduledTransferPeriod,
               
            };

            return config;
        }


    }
}