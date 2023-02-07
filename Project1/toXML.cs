using System;
using System.IO;
using System.Xml.Serialization;

namespace Program1
{
    class toXML
    {
        public static void preHireExport(List<PreHired> preHireList, string xmlname)
        {
            XmlSerializer inst = new XmlSerializer(typeof(PreHired));
            TextWriter writer = new StreamWriter(@xmlname);
            foreach(var hire in preHireList)
            {
                inst.Serialize(writer,hire as PreHired);
            }
            writer.Close();
        }
        public static void employeeExport(List<Employee> preHireList, string xmlname)
        {
            XmlSerializer inst = new XmlSerializer(typeof(Employee));
            TextWriter writer = new StreamWriter(@xmlname);
            foreach(var emp in preHireList)
            {
                inst.Serialize(writer,emp as Employee);
            }
            writer.Close();
        }
        public static void retireeExport(List<Retiree> preHireList, string xmlname)
        {
            XmlSerializer inst = new XmlSerializer(typeof(Retiree));
            TextWriter writer = new StreamWriter(@xmlname);
            foreach(var retire in preHireList)
            {
                inst.Serialize(writer,retire as Retiree);
            }
            writer.Close();
        }
    }
}