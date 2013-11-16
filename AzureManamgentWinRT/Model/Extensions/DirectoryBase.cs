using System.Runtime.Serialization;

namespace AzureManamgentWinRT.Models.ConfDiag.Public
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectoryLocalResource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DirectoryAbsolute))]
    [DataContract(Name = "DirectoryBase", Namespace = "http://schemas.microsoft.com/ServiceHosting/2010/10/DiagnosticsConfiguration")]
    public partial class DirectoryBase
    {
    }
}