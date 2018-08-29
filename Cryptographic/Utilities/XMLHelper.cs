using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Cryptographic.Utilities
{
    class XMLDoc
    {
        XmlDocument document = new XmlDocument();
        readonly string _fileName;
        public XMLDoc(string fileName)
        {
            _fileName = fileName;
            document.Load(fileName);
            XDocument myxml = XDocument.Load(fileName);

        }
        public string GetValueOf(string tagName) =>
             document.SelectSingleNode($"initialDirectories/{tagName}").InnerText;

        public void SetValueOf(string tagName, string selectedPath)
        {
            document.SelectSingleNode($"initialDirectories/{tagName}").InnerText = selectedPath;
        }

        public void SaveDoc()
        {
            document.Save(_fileName);
        }
    }
}
