using System.Runtime.Serialization;
//Storage accounts to be used with Azure Diagnostic
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
   
    public partial class StorageAccount
    {

        private string nameField;

        private string defaultEndpointsProtocolField;

        private string connectionQualifiersField;

        
        public StorageAccount()
        {
            this.defaultEndpointsProtocolField = "https";
        }

        [XmlElement("Name",Order = 2)]
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
        
        [XmlElement("DefaultEndpointsProtocol",Order = 1)]
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

       
        [XmlElement("ConnectionQualifiers",Order = 0)]
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