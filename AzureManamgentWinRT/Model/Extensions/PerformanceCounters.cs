using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "PerformanceCounters", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class PerformanceCounters : LogsBase
    {

        private List<PerformanceCounterConfiguration> performanceCounterConfigurationField;

        public PerformanceCounters()
        {
            this.performanceCounterConfigurationField = new List<PerformanceCounterConfiguration>();
        }

        [DataMember]
        public List<PerformanceCounterConfiguration> PerformanceCounterConfiguration
        {
            get
            {
                return this.performanceCounterConfigurationField;
            }
            set
            {
                this.performanceCounterConfigurationField = value;
            }
        }
    }
}