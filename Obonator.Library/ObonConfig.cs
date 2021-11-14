using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Obonator.Library
{
    public class ObonConfig
    {
        private string _file_config;

        /// <summary>
        /// Xml file
        /// </summary>
        /// <param name="file_config">path to config xml file</param>
        public ObonConfig(string file_config)
        {
            _file_config = file_config;
            string directoryName = new FileInfo(_file_config).DirectoryName;
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        /// <summary>
        /// Create config template file
        /// </summary>
        /// <param name="path">Example: C:/PathToConfig/Config.xml</param>
        public static void CreateConfigFile(string path)
        {
            if (!File.Exists(path))
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, null))
                {
                    xmlTextWriter.WriteStartDocument();
                    xmlTextWriter.WriteStartElement("Configuration");
                    xmlTextWriter.WriteEndElement();
                    xmlTextWriter.WriteEndDocument();
                    xmlTextWriter.Close();
                }
            }
        }

        public string GetValue(string key)
        {
            key = key.Replace(" ", "");
            return GetValue(key, "");
        }

        public void SetValue(string key, string value)
        {
            key = key.Replace(" ", "");
            if (!File.Exists(_file_config))
            {
                CreateConfigFile(_file_config);
            }
            DeleteKey(key);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(_file_config);
            XmlNode xmlNode = xmlDocument.CreateNode(XmlNodeType.Element, key, null);
            xmlNode.InnerText = value;
            xmlDocument.DocumentElement.AppendChild(xmlNode);
            xmlDocument.Save(_file_config);
        }

        public void DeleteKey(string key)
        {
            key = key.Replace(" ", "");
            XmlTextReader xmlTextReader = new XmlTextReader(_file_config);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlTextReader);
            xmlTextReader.Close();
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.SelectSingleNode(key);
            if (xmlNode != null)
            {
                documentElement.RemoveChild(xmlNode);
                xmlDocument.Save(_file_config);
            }
        }

        public string GetValue(string key, string defaultvalue)
        {
            string result = defaultvalue;
            try
            {
                key = key.Replace(" ", "");
                if (File.Exists(_file_config))
                {
                    XmlTextReader xmlTextReader = new XmlTextReader(_file_config);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(xmlTextReader);
                    xmlTextReader.Close();
                    XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(key);
                    if (xmlNode != null)
                    {
                        result = xmlNode.InnerText;
                        return result;
                    }
                    return result;
                }
                return result;
            }
            catch
            {
                return result;
            }
        }
    }
}
