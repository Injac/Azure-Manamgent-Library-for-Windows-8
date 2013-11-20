using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
    /// <summary>
    /// Required. Represents a specific role to which the extension is added.
    /// </summary>
    
    public partial class ChangeConfigurationExtensionConfigurationNamedRolesRoleExtension
    {

        private string idField;

        /// <summary>
        //Required. The identifier of the extension. The identifier is created when the
        //extension is added to the cloud service. You can find the Id of an extension that 
        //was added to a cloud service by using List Extensions
        /// </summary>
        /// <value>The id.</value>
        [XmlElement(ElementName="Id", Order = 0)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}