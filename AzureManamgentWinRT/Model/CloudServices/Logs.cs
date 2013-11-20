using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Main logs element.
    /// The ScheduledTransferLogLevelFilter property is used to specify a LogLevel for diagnostics logs. When you specify a LogLevel, 
    /// all events greater than or equal to the specified severity are transferred to persistent storage. 
    /// For example, if you specify LogLevel = Warning, Error and Critical logs will also be transferred to persistent storage.
    /// Critical Value: 1. Indicates logs for a critical alert. 
    ///Error Value: 2. Indicates logs for an error. 
    //Information Value: 4. Indicates logs for an informational message. 
    //Undefined Value: 0. Indicates logs at all levels. 
    //Verbose Value: 5. Indicates logs at all levels. 
    ///arning Value: 3. Indicates logs for a warning. 
    ///http://msdn.microsoft.com/en-us/library/microsoft.windowsazure.diagnostics.loglevel.aspx
    /// </summary>
  
    public partial class Logs : LogsBase
    {

        private LogLevel scheduledTransferLogLevelFilterField;

        /// <summary>
        /// Standard constructor.
        /// </summary>
        public Logs()
        {
            this.scheduledTransferLogLevelFilterField = LogLevel.Undefined;
        }
        /// <summary>
        /// Gets or sets the logging level by which to filter 
        /// records when performing a scheduled transfer. 
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(LogLevel.Undefined)]
      
        [XmlAttribute]
        public LogLevel scheduledTransferLogLevelFilter
        {
            get
            {
                return this.scheduledTransferLogLevelFilterField;
            }
            set
            {
                this.scheduledTransferLogLevelFilterField = value;
            }
        }
    }
}