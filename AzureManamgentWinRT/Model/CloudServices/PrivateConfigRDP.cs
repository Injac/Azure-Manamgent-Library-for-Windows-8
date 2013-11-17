using System.Runtime.Serialization;

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