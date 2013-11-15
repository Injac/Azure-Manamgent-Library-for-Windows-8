using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients.Helper
{
    /// <summary>
    /// Simple serialization helpers.
    /// </summary>
    public static class SerializationHelper
    {
        /// <summary>
        /// Datas the contract serialize.
        /// Credits go to
        /// http://ashishkelo.wordpress.com/2013/04/26/csharp-serialization-helper-class/
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static string DataContractSerialize(object item)
        {
            if (item != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    DataContractSerializer serializer = new DataContractSerializer(item.GetType());
                    serializer.WriteObject(memoryStream, item);
                    byte[] buffer = memoryStream.ToArray();
                    return Encoding.UTF8.GetString(buffer,0,buffer.Length);
                }
            }
            return null;
        }
    }
}
