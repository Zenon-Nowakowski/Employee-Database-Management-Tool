using System;
using System.Xml.Serialization;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //set default path name
            string path = "default.txt"; 
            string xmlname = "";
            //declare variables, initialize classes
            Program p = new Program();
            consoleTables ct = new consoleTables();
            find find = new find();
            Worker W = new Worker();
            sort sort = new sort();
            toXML toXML = new toXML();

            //try and catch incase of nonexistent of file, reads file
            Console.WriteLine("Please enter file path (leave blank to use default file): ");
            try
            {
                path = Console.ReadLine();
                if(path == "")
                {
                    path = "default.txt";
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            Console.WriteLine("Pulling data... \n");
            //input file data into string array 
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Found data! \n");
            ct.genAll(lines);
            Console.WriteLine("It looks like you have " + lines.Count() + " Data entries!\nGetting that all sorted for you!");
            sort.bubbleSort(lines);
            Console.WriteLine("Sorted!: \n");
            ct.genAll(lines);

            Console.WriteLine("Please input a name for the PreHires output file: ");
            xmlname = Console.ReadLine();
            Console.WriteLine("Prehires:");
            find.findPreHire(lines,xmlname);

            Console.WriteLine("Please input a name for the Employees output file: ");
            xmlname = Console.ReadLine();
            Console.WriteLine("Employees:");
            find.findEmployees(lines, xmlname);

            Console.WriteLine("Please input a name for the Retirees output file: ");
            xmlname = Console.ReadLine();
            Console.WriteLine("Retirees:");
            find.findRetirees(lines, xmlname);
        }
    }
}