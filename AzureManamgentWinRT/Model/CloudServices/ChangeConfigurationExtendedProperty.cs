using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
   public partial class ChangeConfigurationExtendedProperty
    {

        private string nameField;

        private string valueField;

        [XmlElement(ElementName="Name", Order = 0)]
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

        [XmlElement(ElementName="Value", Order = 1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}