using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// Sub-Element of the the directories element.
    /// </summary>
   
    public partial class DataSources
    {

        private List<DirectoryConfiguration> directoryConfigurationField;

        public DataSources()
        {
            this.directoryConfigurationField = new List<DirectoryConfiguration>();
        }

        /// <summary>
        /// Gets or sets the directory configuration.
        /// </summary>
        /// <value>The directory configuration.</value>
      
        [XmlArray]
        public List<DirectoryConfiguration> DirectoryConfiguration
        {
            get
            {
                return this.directoryConfigurationField;
            }
            set
            {
                this.directoryConfigurationField = value;
            }
        }
    }
}