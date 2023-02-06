using System;
using System.Linq;

namespace Program1
{
    class find
    {
        Employee employ = new Employee();
        public override string ToString()
        {
            return
            employ.workType +
            employ.ID +
            employ.fName +
            employ.lName + 
            employ.employDate;
        }
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
        public void findPreHire(string[] lines)
        {   //declare list of prehires 
            List<PreHired> preHiredList = new List<PreHired>();
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "PreHire")
                {
                    Console.WriteLine("Added " + names[3]);
                    preHiredList.Add(new PreHired
                    {
                        workType = names[0],
                        ID = names[1],
                        fName = names[2],
                        lName = names[3],
                        employDate = names[4],
                        extended = "",
                        accepted = ""
                    });
                }
            }
        }
        public void findEmployees(string[] lines)
        {   //create list of objects: employees
            var employeeList = new List<Employee>();
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "Employee")
                {
                    Console.WriteLine("Added " + names[3]);
                    employeeList.Add(new Employee
                    {
                        workType = names[0],
                        ID = names[1],
                        fName = names[2],
                        lName = names[3],
                        employDate = names[4],
                        title = names[5],
                        salary = names[8]
                    });
                }
            }
        }
        public void findRetirees(string[] lines)
        {   //create list of retirees as objects 
            List<Retiree> retireeList = new List<Retiree>();
            //for loop to go through list, pick out prehires 
            for (int i = 1; i < lines.Count(); i++)
            {
                var names = lines[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (names[0] == "Retiree")
                {
                    Console.WriteLine("Added " + names[3]);
                    retireeList.Add(new Retiree
                    {
                        workType = names[0],
                        ID = names[1],
                        fName = names[2],
                        lName = names[3],
                        employDate = names[4],
                    });
                }
            }
        }
    }
}