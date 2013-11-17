using System.Runtime.Serialization;

//Diagnostic extension
namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "PublicConfigWadCfg", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class PublicConfigWadCfg
    {

        private DiagnosticMonitorConfiguration diagnosticMonitorConfigurationField;

        public PublicConfigWadCfg()
        {
            this.diagnosticMonitorConfigurationField = new DiagnosticMonitorConfiguration();
        }

        [DataMember]
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