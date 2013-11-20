using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
        /// XMLs the serialize.
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="toSerilaze">To serilaze.</param>
        /// <returns></returns>
        public static async Task<string> XmlSerialize<T>(T toSerilaze)
        {
            if (toSerilaze != null)
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    MemoryStream s = new MemoryStream();

                    ser.Serialize(s, toSerilaze);

                    s.Position = 0;
                    StreamReader sr = new StreamReader(s);

                    var xml = await sr.ReadToEndAsync();

                    return xml;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return string.Empty;
        }
       
        /// <summary>
        /// Datas the contract serializer fragment.
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static async Task<string> DataContractSerializerFragment<T>(T item)
        {
            var ser = new DataContractSerializer(typeof(T));

            StringBuilder b = new StringBuilder();

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Async = true,
                Encoding = Encoding.UTF8,
                NamespaceHandling = NamespaceHandling.OmitDuplicates,
                ConformanceLevel = ConformanceLevel.Fragment
            };

            using (XmlWriter documentWriter = XmlWriter.Create(b, xmlWriterSettings))
            {
                ser.WriteObject(documentWriter, item);

                await documentWriter.FlushAsync();
            }

            var content = b.ToString().Replace("xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"", "");

            return content;
        }

        /// <summary>
        /// Datas the contract serializer document.
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static async Task<string> DataContractSerializerDocument<T>(T item)
        {
            var ser = new DataContractSerializer(typeof(T));

            StringBuilder b = new StringBuilder();

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

            xmlWriterSettings.Async = true;
            xmlWriterSettings.Encoding = Encoding.UTF8;
            xmlWriterSettings.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            xmlWriterSettings.ConformanceLevel = ConformanceLevel.Document;

            using (XmlWriter documentWriter = XmlWriter.Create(b, xmlWriterSettings))
            {
                ser.WriteObject(documentWriter, item);

                await documentWriter.FlushAsync();
            }

            return b.ToString().Replace("utf-16", "utf-8");;
        }

        /// <summary>
        /// Datas the contract serializer auto.
        /// </summary>
        /// <typeparam name="T">The type of the T.</typeparam>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static async Task<string> DataContractSerializerAuto<T>(T item)
        {
            var ser = new DataContractSerializer(typeof(T));

            StringBuilder b = new StringBuilder();

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();

            xmlWriterSettings.Async = true;
            xmlWriterSettings.Encoding = Encoding.UTF8;
            xmlWriterSettings.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            xmlWriterSettings.ConformanceLevel = ConformanceLevel.Auto;

            using (XmlWriter documentWriter = XmlWriter.Create(b, xmlWriterSettings))
            {
                ser.WriteObject(documentWriter, item);

                await documentWriter.FlushAsync();
            }

            return b.ToString();
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
