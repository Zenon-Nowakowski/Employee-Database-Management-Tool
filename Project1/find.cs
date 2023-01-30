using System;
using System.Linq;
using System.Xml.Linq;

namespace Program1
{
    class find
    {
        Worker W = new Worker();
        public void namegen(string[] lines)
        {//generates all names from provided txt file 
            Console.WriteLine("Retrieving names...");
            for(int i = 1; i < lines.Count(); i++)
            { 
                //names array splits along ',' lines 
                var names = lines[i].Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(names[3]);
            }
        }
        public void findPreHire(string[] lines)
        {   //for loop to go through list, pick out prehires 
            for(int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
                if(names[0] == "PreHire")
                {
                    Console.WriteLine(names[3]);
                }
            }
        }
        public void findEmployees(string[] lines)
        {   //create list element of type employee 
            var employee = new List<Employee>();
            //export line 0, the headers
            //for loop to go through list, pick out prehires 
            for(int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
                if(names[0] == "Employee")
                {
                    Console.WriteLine(names[3]);
                }
            }
        }
        public void findRetirees(string[] lines)
        {   //for loop to go through list, pick out prehires 
            for(int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
                if(names[0] == "Retiree")
                {
                    Console.WriteLine(names[3]);
                }
            }
        }
    }
}