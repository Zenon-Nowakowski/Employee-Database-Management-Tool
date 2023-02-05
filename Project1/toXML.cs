using System;
using System.Xml;
namespace Program1
{
    class toXML
    {
        public static void exportXML(string filename)
        {
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
            writer.WriteStartElement("empty");  
            //writer.WriteElementString("title");
            writer.WriteEndElement();  
            writer.Flush();  
            }
        }
    }
}