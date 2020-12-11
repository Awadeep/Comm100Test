using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Comm100Login
{
    class XMLHelper
    {
        public static XmlDocument LoadXML(string xmlPath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);
            return document;
        }

        public static string GetSingleElement(XmlDocument doc, string ElementName)
        {
            XmlNode element = doc.SelectSingleNode(ElementName);
            return element.InnerText;
        }
    }
}
