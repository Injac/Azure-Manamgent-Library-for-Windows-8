using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    public partial class HostedServiceHostedServicePropertiesExtendedProperty
    {

        private string nameField;

        private string valueField;

        [XmlElement(Order = 0)]
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

        [XmlElement(Order = 1)]
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