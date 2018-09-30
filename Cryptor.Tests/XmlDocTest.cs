using System;
using System.CodeDom;
using Cryptor.UI.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cryptor.Tests
{
    [TestClass]
    public class XmlDocTest
    {
        XMLDoc doc;
        private void InitGoodXmlDoc() => doc = new XMLDoc("Settings.xml");
        
        [TestMethod]
        public void Test_All_Paths_Are_Set()
        {
            InitGoodXmlDoc();
            var value = doc.GetValueOf("pubKeyFile");
            Assert.AreEqual(value, "");
        }

        [TestMethod]
        public void Test_Set_And_Get_Tag_Value()
        {
            InitGoodXmlDoc();
            doc.SetValueOf("pubKeyFile", "dummyFile.txt");
            var value = doc.GetValueOf("pubKeyFile");
            Assert.AreEqual(value, "dummyFile.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_XMLDoc_Throws_ArgNullExc()
        {
            doc = new XMLDoc(null);
        }
    }
}
