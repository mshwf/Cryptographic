using System;
using System.Xml;
using System.Xml.Linq;

namespace Cryptographic.UI.Utilities
{
    public class XMLDoc
    {
        XDocument document;
        readonly string _fileName;
        public XMLDoc(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            document = XDocument.Load(fileName);
        }
        public string GetValueOf(string tagName) =>
             (string)document.Root.Element(tagName);

        public void SetValueOf(string tagName, string tagValue) =>
            document.Root.SetElementValue(tagName, tagValue);


        public void SaveDoc() =>
            document.Save(_fileName);

    }
}
