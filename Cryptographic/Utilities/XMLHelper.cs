using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cryptographic.Utilities
{
    class XMLHelper
    {

        public static string GetValueOf(string tagName)
        {
            XmlDocument document = new XmlDocument();
            document.Load("initialData.xml");
            return document.SelectSingleNode($"initialDirectories/{tagName}").InnerText;
        }
    }
}
