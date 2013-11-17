using System.Runtime.Serialization;

//Storage accounts to be used with Azure Diagnostic
namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [DataContract(Name = "StorageAccount", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class StorageAccount
    {

        private string nameField;

        private string defaultEndpointsProtocolField;

        private string connectionQualifiersField;

        public StorageAccount()
        {
            this.defaultEndpointsProtocolField = "https";
        }

        [DataMember]
        public string Name
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

        [System.ComponentModel.DefaultValueAttribute("https")]
        [DataMember]
        public string DefaultEndpointsProtocol
        {
            get
            {
                return this.defaultEndpointsProtocolField;
            }
            set
            {
                this.defaultEndpointsProtocolField = value;
            }
        }

        [DataMember]
        public string ConnectionQualifiers
        {
            get
            {
                return this.connectionQualifiersField;
            }
            set
            {
                this.connectionQualifiersField = value;
            }
        }
    }
}