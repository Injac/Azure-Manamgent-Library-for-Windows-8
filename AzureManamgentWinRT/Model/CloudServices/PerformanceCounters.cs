using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    
    public partial class PerformanceCounters : LogsBase
    {

        private List<PerformanceCounterConfiguration> performanceCounterConfigurationField;

        public PerformanceCounters()
        {
            this.performanceCounterConfigurationField = new List<PerformanceCounterConfiguration>();
        }

       
        [XmlElement]
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