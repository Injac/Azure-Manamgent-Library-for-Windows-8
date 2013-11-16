using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

       


        /// <summary>
        /// Datas the contract deserialize.
        /// Credits go to
        /// http://ashishkelo.wordpress.com/2013/04/26/csharp-serialization-helper-class/
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static T DataContractDeserialize<T>(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                XmlDictionaryReader xmlDictionaryReader = null;
                try
                {
                    xmlDictionaryReader = XmlDictionaryReader.CreateTextReader(Encoding.UTF8.GetBytes(item), XmlDictionaryReaderQuotas.Max);
                    DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                    return (T)serializer.ReadObject(xmlDictionaryReader, false);
                }
                finally
                {
                    if (xmlDictionaryReader != null)
                    {
                        xmlDictionaryReader.Dispose();
                    }
                }
            }
            return default(T);
        }

        /// <summary>
        /// Datas the contract desirialize XML fragment.
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static T DataContractDesirializeXmlFragment<T>(string item,string rootElement,string rootNameSpace)
        {
            if (!string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
            {
                try
                {
                    XmlReaderSettings readerSettings = new XmlReaderSettings();
                    readerSettings.Async = true;
                    readerSettings.ConformanceLevel = ConformanceLevel.Fragment;
                    DataContractSerializerSettings settings = new DataContractSerializerSettings();
                   
                    DataContractSerializer ser = new DataContractSerializer(typeof(T),rootElement,rootNameSpace);

                    byte[] byteArray = Encoding.UTF8.GetBytes(item);
                    MemoryStream stream = new MemoryStream(byteArray);
                    stream.Position = 0;

                    using (XmlReader documentReader = XmlReader.Create(stream, readerSettings))
                    {
                        return (T)ser.ReadObject(documentReader);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                } 
            }

            return default(T);
        }

    }
}
