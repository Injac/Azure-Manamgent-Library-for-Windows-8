using System.Xml.Serialization;

namespace AzureManamgentWinRT.Configuration
{
    /// <summary>
    /// Required. Represents and extension that is to be deoployed to a
    /// role in a cloud service.
    /// To get the id, listing of the available extensions (that not have been 
    /// deployed so far) List Extensions needs to be called.
    /// </summary>
   
    public partial class ChangeConfigurationExtensionConfigurationExtension
    {

        private string idField;

        /// <summary>
        /// Gets or sets the id.
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