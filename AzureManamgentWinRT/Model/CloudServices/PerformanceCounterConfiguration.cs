using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// The PerformanceCounterConfiguration class provides properties to configure a performance counter for a role instance.
    ///  When you create a PerformanceCounterConfiguration object, you add it to the DataSources collection of a DiagnosticMonitorConfiguration object.
    /// http://msdn.microsoft.com/en-us/library/microsoft.windowsazure.diagnostics.performancecounterconfiguration.aspx
    /// </summary>
    
    public partial class PerformanceCounterConfiguration
    {

        private string counterSpecifierField;

        private string sampleRateField;

        /// <summary>
        /// Gets or sets a performance counter specifier using Windows 
        /// performance counter syntax.
        /// </summary>
       
        [XmlAttribute]
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
      
        [XmlAttribute]
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