using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// The PerformanceCounterConfiguration class provides properties to configure a performance counter for a role instance.
    ///  When you create a PerformanceCounterConfiguration object, you add it to the DataSources collection of a DiagnosticMonitorConfiguration object.
    /// http://msdn.microsoft.com/en-us/library/microsoft.windowsazure.diagnostics.performancecounterconfiguration.aspx
    /// </summary>
    [DataContract(Name = "PerformanceCounterConfiguration", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class PerformanceCounterConfiguration
    {

        private string counterSpecifierField;

        private string sampleRateField;

        /// <summary>
        /// Gets or sets a performance counter specifier using Windows 
        /// performance counter syntax.
        /// </summary>
        [DataMember]
        public string counterSpecifier
        {
            get
            {
                return this.counterSpecifierField;
            }
            set
            {
                this.counterSpecifierField = value;
            }
        }

        /// <summary>
        /// Gets or sets the rate at which to sample the performance counter, 
        /// rounded up to the nearest second.
        /// </summary>
        [DataMember]
        public string sampleRate
        {
            get
            {
                return this.sampleRateField;
            }
            set
            {
                this.sampleRateField = value;
            }
        }
    }
}