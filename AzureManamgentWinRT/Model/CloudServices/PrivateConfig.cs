using System.Runtime.Serialization;

//Contains the private members to be
//sent over the wire when
//you want to add a RDP extension
namespace AzureManamgentWinRT.Models.ConfRDP.Private
{
    [DataContract(Name = "PrivateConfig")]
    public partial class PrivateConfig
    {

        private string passwordField;

        [DataMember]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
}

namespace AzureManamgentWinRT.Models.ConfDiag.Private
{
    public partial class PrivateConfig
    {

        private string storageKeyField;

        public string StorageKey
        {
            get
            {
                return this.storageKeyField;
            }
            set
            {
                this.storageKeyField = value;
            }
        }
    }
}