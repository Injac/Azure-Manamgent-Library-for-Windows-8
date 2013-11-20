using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
    /// <summary>
    /// Required. Represents a specific role to which the extension is added.
    /// </summary>
    
    public partial class ChangeConfigurationExtensionConfigurationNamedRoles
    {

        private ChangeConfigurationExtensionConfigurationNamedRolesRole roleField;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfigurationExtensionConfigurationNamedRoles" /> class.
        /// </summary>
        public ChangeConfigurationExtensionConfigurationNamedRoles()
        {
            this.roleField = new ChangeConfigurationExtensionConfigurationNamedRolesRole();
        }

        /// <summary>
        /// Gets or sets the role. Required
        /// </summary>
        /// <value>The role.</value>
        [XmlElement(ElementName="Role",Order = 0)]
        public ChangeConfigurationExtensionConfigurationNamedRolesRole Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }
}