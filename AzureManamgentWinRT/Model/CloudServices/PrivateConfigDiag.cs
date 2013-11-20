//Contains the private members to be
//sent over the wire when
//you want to add a RDP extension

using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfRDP.Private
{
}

namespace AzureManamgentWinRT.Models.ConfDiag.Private
{
    [DataContract(Namespace = "")]
    public partial class PrivateConfig
    {

        private string storageKeyField;

        [DataMember(Name = "StorageKey")]
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