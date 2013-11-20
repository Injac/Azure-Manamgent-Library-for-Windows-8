using System.Runtime.Serialization;
//Diagnostic extension
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    
    public partial class PublicConfigWadCfg
    {

        private DiagnosticMonitorConfiguration diagnosticMonitorConfigurationField;

        public PublicConfigWadCfg()
        {
            this.diagnosticMonitorConfigurationField = new DiagnosticMonitorConfiguration();
        }

       
        [XmlElement("DiagnosticMonitorConfiguration",Order=0)]
        public DiagnosticMonitorConfiguration DiagnosticMonitorConfiguration
        {
            get
            {
                return this.diagnosticMonitorConfigurationField;
            }
            set
            {
                this.diagnosticMonitorConfigurationField = value;
            }
        }
    }
}