using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Model.HostedServices
{
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/windowsazure")]
    public partial class HostedServiceHostedServiceProperties
    {

        private string descriptionField;

        private string affinityGroupField;

        private string locationField;

        private string labelField;

        private string statusField;

        private string dateCreatedField;

        private string dateLastModifiedField;

        private List<HostedServiceHostedServicePropertiesExtendedProperty> extendedPropertiesField;

        private string guestAgentTypeField;

        public HostedServiceHostedServiceProperties()
        {
            this.extendedPropertiesField = new List<HostedServiceHostedServicePropertiesExtendedProperty>();
        }

        [XmlElement(Order = 0)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string AffinityGroup
        {
            get
            {
                return this.affinityGroupField;
            }
            set
            {
                this.affinityGroupField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        [XmlElement(Order = 4)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        [XmlElement(Order = 5)]
        public string DateCreated
        {
            get
            {
                return this.dateCreatedField;
            }
            set
            {
                this.dateCreatedField = value;
            }
        }

        [XmlElement(Order = 6)]
        public string DateLastModified
        {
            get
            {
                return this.dateLastModifiedField;
            }
            set
            {
                this.dateLastModifiedField = value;
            }
        }

        [XmlArray(Order = 7)]
        [XmlArrayItem("ExtendedProperty", IsNullable = false)]
        public List<HostedServiceHostedServicePropertiesExtendedProperty> ExtendedProperties
        {
            get
            {
                return this.extendedPropertiesField;
            }
            set
            {
                this.extendedPropertiesField = value;
            }
        }

        [XmlElement(Order = 8)]
        public string GuestAgentType
        {
            get
            {
                return this.guestAgentTypeField;
            }
            set
            {
                this.guestAgentTypeField = value;
            }
        }
    }
}