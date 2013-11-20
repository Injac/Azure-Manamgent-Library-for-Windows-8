using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// TAKEN FROM THE AZURE DOCUMENTATION
    /// This element contains definitions for both the special directories (CrashDumps, FailedRequestLogs, and IISLogs) and directories that you create (DataSources). 
    /// http://msdn.microsoft.com/en-us/library/windowsazure/hh411551.aspx
    /// </summary>
    
    public partial class Directories :LogsBase
    {


        private SpecialLogDirectory iISLogsField;

        private SpecialLogDirectory failedRequestLogsField;

        private SpecialLogDirectory crashDumpsField;

        private List<DirectoryConfiguration> dataSourcesField;


        /// <summary>
        /// Initializes a new instance of the <see cref="Directories" /> class.
        /// </summary>
        public Directories()
        {
            this.dataSourcesField = new List<DirectoryConfiguration>();
            this.crashDumpsField = new SpecialLogDirectory();
            this.failedRequestLogsField = new SpecialLogDirectory();
            this.iISLogsField = new SpecialLogDirectory();
        }
        /// <summary>
        /// Gets or sets the IISLogs
        /// </summary>
        
        [XmlElement("IISLogs",Order=3)]
        public SpecialLogDirectory IISLogs
        {
            get
            {
                return this.iISLogsField;
            }
            set
            {
                this.iISLogsField = value;
            }
        }

        /// <summary>
        /// Gets or sets the FailedRequestLogs.
        /// </summary>

        [XmlElement("FailedRequestLogs", Order = 2)]
        public SpecialLogDirectory FailedRequestLogs
        {
            get
            {
                return this.failedRequestLogsField;
            }
            set
            {
                this.failedRequestLogsField = value;
            }
        }

        /// <summary>
        /// Gets or sets the CrashDumps special directory.
        /// </summary>
       
        [XmlElement("CrashDumps", Order = 1)]
        public SpecialLogDirectory CrashDumps
        {
            get
            {
                return this.crashDumpsField;
            }
            set
            {
                this.crashDumpsField = value;
            }
        }

        /// <summary>
        /// Gets or sets the DataSources, 
        /// containing the Directory Configurations.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
       
       public List<DirectoryConfiguration> DataSources
        {
            get
            {
                return this.dataSourcesField;
            }
            set
            {
                this.dataSourcesField = value;
            }
        }


       

     
    }
}