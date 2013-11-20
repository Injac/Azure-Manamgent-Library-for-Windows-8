using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// TAKEN FROM THE OFFICIAL DOCUMENTATION
    /// You configure the collection of different diagnostics data sources by specifying a diagnostics.wadcfg 
    /// configuration file, programmatically configuring the diagnostics monitor, or remotely changing the diagnostics 
    /// configuration. If you do not explicitly configure the diagnostics monitor, the default configuration will be used. 
    /// Only Windows Azure logs, IIS logs, and Windows Azure Diagnostics infrastructure logs are collected by the diagnostic monitor by default. 
    /// By setting configuration you can override the default behavior and explicitly add sources to collect specific types of diagnostic data. 
    /// The following table lists the types of diagnostic data that you can configure your application to collect.
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205075.aspx
    /// EventLogs
    /// </summary>
   public partial class DataSource
    {

        private string nameField;

       
        [XmlAttribute]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}