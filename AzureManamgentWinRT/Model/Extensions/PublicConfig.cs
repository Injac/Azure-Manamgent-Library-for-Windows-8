using System.Runtime.Serialization;

///Diagnostic extension
namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "PublicConfig", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class PublicConfig
    {

        private PublicConfigWadCfg wadCfgField;

        private StorageAccount storageAccountField;

        public PublicConfig()
        {
            this.storageAccountField = new StorageAccount();
            this.wadCfgField = new PublicConfigWadCfg();
        }

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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