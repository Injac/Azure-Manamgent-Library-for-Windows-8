using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// TODO: Document
    /// </summary>
    [DataContract(Name = "DirectoryLocalResource", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class DirectoryLocalResource : DirectoryBase
    {

        private string relativePathField;

        private string nameField;

        [DataMember]
        public string relativePath
        {
            get
            {
                return this.relativePathField;
            }
            set
            {
                this.relativePathField = value;
            }
        }

        [DataMember]
        public string name
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
    }
}