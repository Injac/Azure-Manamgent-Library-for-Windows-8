using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    /// <summary>
    /// Represents an extended property entry.
    /// </summary>
    [DataContract(Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class ExtendedProperty
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember(Name="Name",IsRequired=true,Order=0)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [DataMember(Name = "Value", IsRequired=true,Order=1)]
        public string Value { get; set; }
    }
}
