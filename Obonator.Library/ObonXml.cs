using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Obonator.Library
{
    public class ObonXml
    {
        private static string lastErrorMsg;

        /// <summary>
        /// Get last error message from this class
        /// </summary>
        /// <returns></returns>
        public static string GetLastErrorMsg()
        {
            return lastErrorMsg;
        }

        private static void SetLastErrorMsg(string value)
        {
            lastErrorMsg = value;
        }

        public static class XmlHelper
        {
            //https://xmltocsharp.azurewebsites.net/
            public static T DeserializeObject<T>(string value) where T : class
            {
                T result = default;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (var strReader = new StringReader(value))
                    {
                        using (XmlReader reader = XmlReader.Create(strReader, new XmlReaderSettings() { XmlResolver = null }))
                        {
                            result = serializer.Deserialize(reader) as T;
                        }
                    }
                }
                catch (Exception ex)
                {
                    SetLastErrorMsg(ex.ToString());
                }
                return result;
            }
            public static string SerializeObject<T>(T value) where T : class
            {
                string result = string.Empty;
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    using (StringWriter textWriter = new StringWriter())
                    {
                        xmlSerializer.Serialize(textWriter, value);
                        result = textWriter.ToString();
                    }
                }
                catch (Exception ex)
                {
                    SetLastErrorMsg(ex.ToString());
                }

                return result;
            }

            public static string FormatXml(string inputXml)
            {
                string result = "";
                try
                {
                    //XmlDocument document = new XmlDocument();
                    //document.LoadXml(inputXml);
                    XmlDocument document = new XmlDocument() { XmlResolver = null };
                    //StringReader sreader = new StringReader(inputXml);
                    //XmlReader reader = XmlReader.Create(sreader, new XmlReaderSettings() { XmlResolver = null });
                    StringBuilder builder = new StringBuilder();

                    using (XmlReader reader = XmlReader.Create(inputXml, new XmlReaderSettings() { XmlResolver = null }))
                    {
                        document.Load(reader);
                        using (XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder)))
                        {
                            writer.Formatting = Formatting.Indented;
                            document.Save(writer);
                        }
                    }

                    return builder.ToString();
                }
                catch (Exception ex)
                {
                    SetLastErrorMsg(ex.ToString());
                }
                return result;
            }
        }
    }
}
