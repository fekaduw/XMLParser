using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL.XMLParser;

namespace UnitTestXMLParser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var fileName = "D:\\Office Files\\Documentation\\DUP\\MFR\\data\\Shape Files\\Region Shape Files - Copy\\Orgunit sources\\zones.xml";
            var result = Parser.GetDataTable(fileName);
            Assert.AreEqual(result.Rows.Count,0);
        }

        [TestMethod]
        public void TestMethod2()
        {

            var xmlName = "D:\\Office Files\\Documentation\\DUP\\MFR\\data\\Shape Files\\Region Shape Files - Copy\\Orgunit sources\\zones.xml";
            var gmlName = "D:\\Office Files\\Documentation\\DUP\\MFR\\data\\Shape Files\\Region Shape Files - Copy\\Zones (only 75).gml";
            var result = Parser.ReadXml("ogr:ZON_P_CODE", gmlName,Parser.GetDataTable(xmlName));

            Assert.AreEqual(result, true);}
    }
}
