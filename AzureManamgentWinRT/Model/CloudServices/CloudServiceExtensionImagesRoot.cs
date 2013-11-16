using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Model.CloudServices
{   
    /// <summary>
    /// ExtensionImages
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169559.aspx
    /// </summary>
    [CollectionDataContract(Name = "ExtensionImages", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class CloudServiceExtensionImagesRoot:List<CloudServiceExtensionImage>
    {
        
    }
}
