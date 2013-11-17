using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// TAKEN FROM THE AZURE DOCUMENTATION
    /// This element contains definitions for both the special directories (CrashDumps, FailedRequestLogs, and IISLogs) and directories that you create (DataSources). 
    /// http://msdn.microsoft.com/en-us/library/windowsazure/hh411551.aspx
    /// </summary>
    [DataContract(Name = "Directories", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class Directories : LogsBase
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        [DataMember]
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