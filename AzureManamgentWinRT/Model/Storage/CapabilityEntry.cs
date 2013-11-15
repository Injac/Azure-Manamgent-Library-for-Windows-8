using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Model.Storage
{
    [DataContract(Name="Capability",Namespace="http://schemas.microsoft.com/windowsazure")]
    public class CapabilityEntry
    {
        [DataMember(Name = "Capability")]
        public string Capability { get; set; }
    }
}
