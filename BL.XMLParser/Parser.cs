using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BL.XMLParser
{
    public class Parser
    {
        private static string FileName;
        private static string xmlNodeName;
        private static string outputFileName;
        private static double totalToProcess;
        private static double totalProcessed;
        private static DataTable table;

        public static bool ReadXml(string nodeName, string fileName, DataTable sourceDataTable)
        {
            xmlNodeName = nodeName;
            table = sourceDataTable;

            var doc = new XmlDocument();
            doc.Load(fileName);
            var nsMgr = new XmlNamespaceManager(doc.NameTable);
            nsMgr.AddNamespace("gml", "http://www.opengis.net/gml");
            nsMgr.AddNamespace("ogr", "http://ogr.maptools.org/");

            dynamic node = "";

            if (nodeName.ToLower().Contains("woreda"))
            {
                outputFileName = "parsedWoredas.gml";

                node = doc.SelectNodes("/ogr:FeatureCollection/gml:featureMember/ogr:Woredas__from_Seid_/" + nodeName,
                    nsMgr);
            }
            else
            {
                outputFileName = "parsedZones.gml";
                node = doc.SelectNodes("/ogr:FeatureCollection/gml:featureMember/ogr:Zones__only_75_/" + nodeName,
                    nsMgr);
            }

            foreach (XmlNode aNode in node)
            {
                totalToProcess++;
                var result = Search(aNode.InnerText);
                if (!string.IsNullOrEmpty(result))
                {
                    aNode.InnerText = result;
                    totalProcessed++;
                }
            }

            doc.Save("d:\\Office Files\\Documentation\\DUP\\MFR\\data\\Shape Files\\Region Shape Files - Copy\\Orgunit sources\\" + outputFileName);

            return totalToProcess == totalProcessed ? true : false;
        }

        public static DataTable GetDataTable(string fileName)
        {
            var table = new DataTable();

            table.Columns.Add("code", typeof (string));
            table.Columns.Add("uid", typeof (string));
            table.Columns.Add("name", typeof (string));

            var doc = XElement.Load(fileName);


            var orgunit = from ou in doc.Descendants("orgunit") select ou;
            foreach (var ou in orgunit)
            {
                var code = ou.Element("code");
                var uid = ou.Element("uid");
                var name = ou.Element("name");

                if (!string.IsNullOrEmpty(code.Value) && !string.IsNullOrEmpty(uid.Value) && !string.IsNullOrEmpty(name.Value))
                    table.Rows.Add(code.Value, uid.Value, name.Value);
            }
            
            return table;
        }

        private static string Search(string searchKey)
        {
            var result = table.Select("code='" + Convert.ToInt32(searchKey) + "'");
                //table.AsEnumerable().SingleOrDefault(r=>r["code"]==searchKey);

            if (result.Length == 0)
                return string.Empty;

            var code = result[0][0];
            var uid = result[0][1];
            var name = result[0][2];

            return uid.ToString();
        }
    }
}