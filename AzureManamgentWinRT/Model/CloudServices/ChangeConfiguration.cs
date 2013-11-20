using System.Collections.Generic;
using System.Xml.Serialization;
using AzureManamgentWinRT.Model.CloudServices;

namespace AzureManamgentWinRT.Configuration
{
    /// <summary>
    /// The Change Deployment Configuration operation initiates a change to the deployment 
    /// configuration.
    /// The Change Deployment Configuration operation is an asynchronous operation. 
    /// determine whether the Management service has finished processing the request, call Get 
    /// 
    /// </summary>
  
    [XmlRoot(Namespace = "http://schemas.microsoft.com/windowsazure", IsNullable = false)]
    public partial class ChangeConfiguration
    {

        private string configurationField;

        private string treatWarningsAsErrorField;

        private ChangeConfigurationModes modeField;

        private List<ChangeConfigurationExtendedProperty> extendedPropertiesField;

        private ChangeConfigurationExtensionConfiguration extensionConfigurationField;

       
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns></returns>
        public static ChangeConfiguration Initialize()
        {
            var config = new ChangeConfiguration();

            return config;
        }

      
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfiguration" /> class.
        /// </summary>
        public ChangeConfiguration()
        {
            this.extensionConfigurationField = new ChangeConfigurationExtensionConfiguration();
            this.extendedPropertiesField = new List<ChangeConfigurationExtendedProperty>();
        }

        /// <summary>
        /// Gets or sets the configuration. (required)
        /// Required. Specifies the base-64 encoded service
        /// configuration file for the deployment.
        /// </summary>
        /// <value>The configuration.</value>
        [XmlElement(Order = 0)]
        public string Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <summary>
        /// Gets or sets the treat warnings as error. (optional)
        /// Optional. Indicates whether warnings should be treated as errors.
        /// Possible values are: true or false
        /// If not specified, the default value is false. If 
        /// set to true the update will be blocked when
        /// warnings are encountered.
        /// </summary>
        /// <value>The treat warnings as error.</value>
        [XmlElement(ElementName = "TreatWarningsAsError",Order=1)]
        public string TreatWarningsAsError
        {
            get
            {
                return this.treatWarningsAsErrorField;
            }
            set
            {
                this.treatWarningsAsErrorField = value;
            }
        }

        /// <summary>
        /// Gets or sets the mode. (optional)
        /// Possible values Auto, Manual, Simultaneous
        /// </summary>
        /// <value>The mode.</value>
        [XmlElement(ElementName="Mode",Order = 2)]
        public ChangeConfigurationModes Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <summary>
        /// Gets or sets the extended properties. (optional)
        /// Change the extended properties, if any.
        /// </summary>
        /// <value>The extended properties.</value>
        [XmlArray(Order = 3)]
        [XmlArrayItem("ExtendedProperty", IsNullable = false)]
        public List<ChangeConfigurationExtendedProperty> ExtendedProperties
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
        /// Gets or sets the extension configuration. (optional)
        /// Optional. Represents an extension that is added to the cloud service. 
        // In Windows Azure, a process can run as an extension of a cloud service. 
        // For example, Remote Desktop Access or the Windows Azure Diagnostics Agent 
        // can run as extensions to the cloud service. You must add an extension 
        // to the cloud service by using Add Extension before it can be 
        // added to the deployment during a configuration change.
        // The ExtensionConfiguration element is 
        // only available using version 2013-03-01 or higher.
        /// </summary>
        /// <value>The extension configuration.</value>
        [XmlElement(ElementName="ExtensionConfiguration",  Order = 4)]
        public ChangeConfigurationExtensionConfiguration ExtensionConfiguration
        {
            get
            {
                return this.extensionConfigurationField;
            }
            set
            {
                this.extensionConfigurationField = value;
            }
        }
    }
}