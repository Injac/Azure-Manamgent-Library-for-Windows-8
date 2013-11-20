using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
  
    public partial class ChangeConfigurationExtensionConfiguration
    {

        private List<ChangeConfigurationExtensionConfigurationExtension> allRolesField;

        private List<ChangeConfigurationExtensionConfigurationNamedRolesRole> namedRolesField;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfigurationExtensionConfiguration" /> class.
        /// </summary>
        public ChangeConfigurationExtensionConfiguration()
        {
            this.namedRolesField = new List<ChangeConfigurationExtensionConfigurationNamedRolesRole>();
            this.allRolesField = new List<ChangeConfigurationExtensionConfigurationExtension>();
        }

        /// <summary>
        /// Gets or sets all roles. (optional)
        /// Specifies a list of extensions that are applied to all roles in a deployment.
        /// </summary>
        /// <value>All roles.</value>
        [XmlArray(ElementName="AllRoles", Order = 0)]
       public List<ChangeConfigurationExtensionConfigurationExtension> AllRoles
        {
            get
            {
                return this.allRolesField;
            }
            set
            {
                this.allRolesField = value;
            }
        }

        /// <summary>
        /// Gets or sets the named roles. (optional)
        /// Specifies a list of extensions that are applied to specific roles in a deployment.
        /// </summary>
        /// <value>The named roles.</value>
        [XmlElement(ElementName="NamedRoles",Order = 1)]
        public List<ChangeConfigurationExtensionConfigurationNamedRolesRole> NamedRoles
        {
            get
            {
                return this.namedRolesField;
            }
            set
            {
                this.namedRolesField = value;
            }
        }
    }
}