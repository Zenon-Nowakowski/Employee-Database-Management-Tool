using System;

namespace Program1
{
    public class Worker
    {
        public string workType {get; set;} = default!;
        public string ID {get; set;} = default!;
        public string fName {get; set;} = default!;
        public string lName {get; set;} = default!;
        public string employDate {get; set;} = default!;
    }
    public class PreHired : Worker
    {
        public string extended {get; set;} = default!;
        public string accepted {get; set;} = default!;
        
        public PreHired(string workType,string ID,string fName,
        string lName, string employDate, string extended, string accepted)
        {
            this.workType = workType;
            this.ID = ID; 
            this.fName = fName;
            this.lName = lName;
            this.employDate = employDate;
            this.extended = extended;
            this.accepted = accepted;
        }
        public PreHired()
        {}
        public override string ToString()
        {
            return ("workType: " + workType + " ID: " + ID + " fName: " + fName + 
            " lName: " + lName + " employDate: " + employDate + 
            " extended: " + extended + " accepted: " + accepted);
        }
    }
    public class Employee : Worker
    {
        public string title {get; set;} = default!;
        public string salary {get; set;} = default!;
        public Employee(string workType,string ID,string fName,
        string lName, string employDate, string extended, string accepted)
        {
            this.workType = workType;
            this.ID = ID; 
            this.fName = fName;
            this.lName = lName;
            this.employDate = employDate;
            this.title = extended;
            this.salary = accepted;
        }
        public Employee()
        {}
        public override string ToString()
        {
            return ("workType: " + workType + " ID: " + ID + " fName: " + fName + 
            " lName: " + lName + " employDate: " + employDate + 
            " title: " + title + " salary: " + salary);
        }
    }
    public class Retiree : Worker
    {
        public string prog {get; set;} = default!;
        public string retirement {get; set;} = default!;
        public Retiree(string workType,string ID,string fName,
        string lName, string employDate, string extended, string accepted)
        {
            this.workType = workType;
            this.ID = ID; 
            this.fName = fName;
            this.lName = lName;
            this.employDate = employDate;
            this.prog = extended;
            this.retirement = accepted;
        }
        public Retiree()
        {}
        public override string ToString()
        {
            return ("workType: " + workType + " ID: " + ID + " fName: " + fName + 
            " lName: " + lName + " employDate: " + employDate + 
            " program: " + prog + " retirement: " + retirement);
        }
    }
}