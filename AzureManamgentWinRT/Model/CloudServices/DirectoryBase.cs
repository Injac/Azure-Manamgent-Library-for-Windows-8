using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectoryLocalResource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectoryAbsolute))]
    public partial class DirectoryBase
    {
    }
}