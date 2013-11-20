using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    /// <summary>
    /// TODO: Document
    /// </summary>
   
    public partial class DirectoryLocalResource : DirectoryBase
    {

        private string relativePathField;

        private string nameField;

        
        [XmlAttribute]
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

        
        [XmlAttribute]
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