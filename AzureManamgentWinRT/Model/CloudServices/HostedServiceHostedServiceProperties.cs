using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Model.HostedServices
{
  
    /// <summary>
    /// Specifies the properties that are assigned to
    /// the cloud services.
    /// </summary>
    public partial class HostedServiceHostedServiceProperties
    {
        private string descriptionField;

        private string affinityGroupField;

        private string locationField;

        private string labelField;

        private HostedSerivceStatus statusField;

        private DateTime dateCreatedField;

        private string dateLastModifiedField;

        private List<HostedServiceHostedServicePropertiesExtendedProperty> extendedPropertiesField;

        private HostedServiceGuestAgentType guestAgentTypeField;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedServiceHostedServiceProperties" /> class.
        /// </summary>
        public HostedServiceHostedServiceProperties()
        {
            this.extendedPropertiesField = new List<HostedServiceHostedServicePropertiesExtendedProperty>();
        }

        /// <summary>
        /// Specifies the description of the cloud service.
        /// </summary>
        /// <value>The description.</value>
        [XmlElement(ElementName = "Description", Order = 0)]
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

        /// <summary>
        /// Specifies the name of the affinity group with which
        /// the cloud serivce is associated. If the cloud service is associated with an affinity 
        /// group, the location element is not returned.
        /// </summary>
        /// <value>The affinity group.</value>
        [XmlElement(ElementName = "AffinityGroup", Order = 1)]
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

        /// <summary>
        /// Specifies the geo-location of the cloud service in Windows Azure, if the
        /// cloud serivce is not associated with an affinity group. If a location has been specified, the AffinityGroup
        /// element is not returned.
        /// </summary>
        /// <value>The location.</value>
        [XmlElement(ElementName = "Location", Order = 2)]
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

        /// <summary>
        /// Specifies the base-64-encoded identifier of the cloud
        /// serivce for your tracking purpooses.
        /// </summary>
        /// <value>The label.</value>
        [XmlElement(ElementName = "Label", Order = 3)]
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

        /// <summary>
        /// Specifies the status of the cloud service.
        /// </summary>
        /// <value>The status.</value>
        [XmlElement(ElementName = "Status", Order = 4)]
        public HostedSerivceStatus Status
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

        /// <summary>
        /// Specifies the date that the cloud service was created.
        /// ]-[2DigitMonth]-[2DigitDay]T[2DigitHour]:[2DigitMinute]:
        /// [2DigitSecond]Z format. The date 2011-05-11T16:15:26Z is an 
        /// example that could be returned by the DateCreated or 
        /// DateLastModified elements.
        /// 
        /// </summary>
        /// <value>The date created.</value>
        [XmlElement(ElementName = "DateCreated", Order = 5)]
        public DateTime DateCreated
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

        /// <summary>
        /// Specifies the name of an extended cloud service property.
        /// </summary>
        /// <value>The date last modified.</value>
        [XmlElement(ElementName="DateLastModified",Order = 6)]
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

        /// <summary>
        /// Specifies the properties that are used to provide more
        /// information about a deployment.
        /// </summary>
        /// <value>The extended properties.</value>
        [XmlArray(ElementName = "ExtendedProperties", Order = 7)]
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

        /// <summary>
        /// Specifies the type of guest agent that is installed on the role instance.
        /// The guest agent configures the role instance and enables it to 
        /// communicate in Windows Azure. This element indicates wether the subscription is enabled to test new
        /// versions of the guest agent.
        /// </summary>
        /// <value>The type of the guest agent.</value>
        [XmlElement(ElementName = "GuestAgentType", Order = 8)]
        public HostedServiceGuestAgentType GuestAgentType
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