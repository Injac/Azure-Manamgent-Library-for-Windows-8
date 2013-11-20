using System.Runtime.Serialization;
///Diagnostic extension
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
   
    [XmlRoot("PublicConfig",Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class PublicDiagnosticsConfig
    {
        private PublicConfigWadCfg wadCfgField;

        private StorageAccount storageAccountField;

        /// <summary>
        /// Fluent configuration of the public 
        /// Diagnostics element.
        /// </summary>
        public static PublicDiagnosticsConfig Initialize()
        {
            var config = new PublicDiagnosticsConfig();

            return config;
        }
        
        public PublicDiagnosticsConfig()
        {
            this.storageAccountField = new StorageAccount();
            this.wadCfgField = new PublicConfigWadCfg();
        }

        
        [XmlElement("WadCfg",Order=1)]
        public PublicConfigWadCfg WadCfg
        {
            get
            {
                return this.wadCfgField;
            }
            set
            {
                this.wadCfgField = value;
            }
        }

        
        [XmlElement("StorageAccount",Order = 0)]
        public StorageAccount StorageAccount
        {
            get
            {
                return this.storageAccountField;
            }
            set
            {
                this.storageAccountField = value;
            }
        }
    }
}

namespace AzureManamgentWinRT.Models.ConfRDP.Public
{
    [DataContract(Name = "PublicConfig")]
    public partial class PublicConfig
    {
        private string userNameField;

        private string expirationField;

        
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        
        public string Expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }
    }
}