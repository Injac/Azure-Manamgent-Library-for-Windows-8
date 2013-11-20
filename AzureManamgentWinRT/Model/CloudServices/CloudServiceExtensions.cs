using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{
    /// <summary>
    /// The cloud service extensions 
    /// delevired by the ListExtensions operation.
    /// </summary>
    [CollectionDataContract(Name = "Extensions", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class CloudServiceExtensions : List<CloudServiceExtension>
    {
    }
}
