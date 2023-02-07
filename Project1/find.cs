using System;

namespace Program1
{
    class find
    {
        toXML toXML = new toXML();
        public void namegen(string[] lines)
        {//generates all names from provided txt file 
            Console.WriteLine("Retrieving names...");
            for (int i = 1; i < lines.Count(); i++)
            {
                //names array splits along ',' lines 
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(names[3]);
            }
        }
        public void findPreHire(string[] lines, string xmlname)
        {   //declare list of prehires 
            List<PreHired> preHiredList = new List<PreHired>();
            //init header of list 
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "PreHire")
                {
                    preHiredList.Add(new PreHired
                    (
                        //workType
                        names[0],
                        //ID
                        names[1],
                        //fName
                        names[2],
                        //lName
                        names[3],
                        //employDate
                        names[4],
                        //extended
                        names[6],
                        //accepted
                        names[7]
                    ));
                }
            }
            foreach (var hire in preHiredList)
            {
                Console.WriteLine(hire);
            } 
            Console.WriteLine("PreHires found! Exporting to " + xmlname + ".xml...");
            toXML.preHireExport(preHiredList, xmlname);
        }
        public void findEmployees(string[] lines, string xmlname)
        {   //create list of objects: employees
            List<Employee> employeeList = new List<Employee>();
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "Employee")
                {
                    employeeList.Add(new Employee
                    (
                        //workType
                        names[0],
                        //ID
                        names[1],
                        //fName
                        names[2],
                        //lName
                        names[3],
                        //employDate
                        names[4],
                        //title
                        names[5],
                        //salary
                        names[8]
                    ));
                }
            }
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee);
            } 
            Console.WriteLine("Employees found! Exporting to " + xmlname + ".xml...");
            toXML.employeeExport(employeeList, xmlname);
        }
        public void findRetirees(string[] lines, string xmlname)
        {   //create list of retirees as objects 
            List<Retiree> retireeList = new List<Retiree>();
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "Retiree")
                {
                    retireeList.Add(new Retiree
                    (
                        //workType
                        names[0],
                        //ID
                        names[1],
                        //fName
                        names[2],
                        //lName
                        names[3],
                        //employDate
                        names[4],
                        //program 
                        names[9],
                        //retirement
                        names[10]
                    ));
                }
            }
            foreach (var retiree in retireeList)
            {
                Console.WriteLine(retiree);
            } 
            Console.WriteLine("Retirees found! Exporting to " + xmlname + ".xml...");
            toXML.retireeExport(retireeList, xmlname);
        }
    }
}