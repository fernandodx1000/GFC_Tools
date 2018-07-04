using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GFC_Tools
{
    class StartUp
    {
        public void Main()
        {
            var variables = new Variables();
            variables.Main();



        }
        private string ReadSiteXml()//string url, string node1
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("http://gfcdownloads.co.nf/test.xml");
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//gfc/test");

            string nodestring;
            foreach (XmlNode node in nodes)
            {
                nodestring = node["version"].InnerText;

                return nodestring;
            }
            return null;
        }
    }
}
