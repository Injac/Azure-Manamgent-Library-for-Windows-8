using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
    /// <summary>
    /// Required. Represents a specific role to which the extension is added.
    /// </summary>
    
    public partial class ChangeConfigurationExtensionConfigurationNamedRolesRole
    {

        private string roleNameField;

        private List<ChangeConfigurationExtensionConfigurationNamedRolesRoleExtension> extensionsField;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfigurationExtensionConfigurationNamedRolesRole" /> class.
        /// </summary>
        public ChangeConfigurationExtensionConfigurationNamedRolesRole()
        {
            this.extensionsField = new List<ChangeConfigurationExtensionConfigurationNamedRolesRoleExtension>();
        }

        /// <summary>
        /// Gets or sets the name of the role. (required)
        /// </summary>
        /// <value>The name of the role.</value>
        [XmlElement(ElementName="RoleName", Order = 0)]
        public string RoleName
        {
            get
            {
                return this.roleNameField;
            }
            set
            {
                this.roleNameField = value;
            }
        }

        /// <summary>
        /// Gets or sets the extensions. (required)
        /// </summary>
        /// <value>The extensions.</value>
        [XmlElement(ElementName="Extensions",Order = 1)]
        public List<ChangeConfigurationExtensionConfigurationNamedRolesRoleExtension> Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }
}