//Contains the private members to be
//sent over the wire when
//you want to add a RDP extension
namespace AzureManamgentWinRT.Models.ConfRDP.Private
{
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