using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AzureManamgentWinRT.Model.Storage
{
    [DataContract(Name="Capability",Namespace="http://schemas.microsoft.com/windowsazure")]
    public class CapabilityEntry
    {
        [DataMember(Name = "Capability")]
        public string Capability { get; set; }
    }
}
