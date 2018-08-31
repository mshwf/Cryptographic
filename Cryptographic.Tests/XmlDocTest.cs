using System;
using Cryptographic.UI.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cryptographic.Tests
{
    [TestClass]
    public class XmlDocTest
    {
        [TestMethod]
        public void Test_All_Paths_Are_Set()
        {
            XMLDoc doc = new XMLDoc("initialData.xml");
            var value = doc.GetValueOf("pubKeyFile");
            Assert.AreEqual(value, "");
        }

        [TestMethod]
        public void Test_Set_And_Get_Tag_Value()
        {
            XMLDoc doc = new XMLDoc("initialData.xml");
            doc.SetValueOf("pubKeyFile", "dummyFile.txt");
            var value = doc.GetValueOf("pubKeyFile");
            Assert.AreEqual(value, "dummyFile.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_XMLDoc_Throws_ArgNullExc()
        {
            XMLDoc doc = new XMLDoc(null);
        }
    }
}
