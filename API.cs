using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Linq;
using Formatting = Newtonsoft.Json.Formatting;

namespace XMLtoISO {
    
    public class Entrada
    {
        public bool doc { get; internal set; }

        //container class
        public class API
        {
            public static string Xml => @"<?xml version='1.0'?>
    <SquidGame>
      <Genre>Thriller</Genre>
      <Rating Type='Imdb'>8.1</Rating>
      <Stars>Lee Jung-jae</Stars>
      <Stars>Park Hae-soo</Stars>
      <Budget />
    </SquidGame>";
        }
        //utilidade
        public static class JsonXmlUtils
        {
            public static string XmlToJson(string xml)
            {
                var doc = XDocument.Parse(xml);

                return JsonConvert.SerializeXNode(doc);
            }
            //var json = JsonXmlUtils.XmlToJson(API.Xml);

            public static string XmlToJsonWithoutRoot(string xml)
            {
                var doc = XDocument.Parse(xml);

                return JsonConvert.SerializeXNode(doc, Formatting.None, omitRootObject: true);
            }

        }
    }
    /*
    public class API {
    

        string xml = @"<?xml version='1.0' standalone='no'?>
<root>
  <person id='1'>
    <name>Alan</name>
    <url>http://www.google.com</url>
  </person>
  <person id='2'>
    <name>Louis</name>
    <url>http://www.yahoo.com</url>
  </person>
</root>";

        XmlDocument Doc = new XmlDocument();
        object docxml = new XmlDocument();

        public string JsonText { get; set; } = JsonConvert.SerializeXmlNode(docxml);
        //{
        //  "?xml": {
        //    "@version": "1.0",
        //    "@standalone": "no"
        //  },
        //  "root": {
        //    "person": [
        //      {
        //        "@id": "1",
        //        "name": "Alan",
        //        "url": "http://www.google.com"
        //      },
        //      {
        //        "@id": "2",
        //        "name": "Louis",
        //        "url": "http://www.yahoo.com"
        //      }
        //    ]
        //  }
        //}
        /*
                StreamReader Doc = new StreamReader(stream);
                readonly string doc = @"<?xml version='1.0' standalone='no'?>
             <root>
             <person id='1'>
             <name>Alan</name>
             <url>http://www.google.com</url>
             </person>
             <person id='2'>
             <name>Louis</name>
             <url>http://www.yahoo.com</url>
             </person>
             </root>";

                XmlDocument Doc = new XmlDocument();
                Doc.LoadXml(xml);

                string json = JsonConvert.SerializeXmlNode(doc.ToString());
    Console.WriteLine(doc);
    */


}


