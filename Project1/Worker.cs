namespace Program1
{
    public class Worker
    {
        public string workType {get; set;} = default!;
        public int ID {get; set;} = default!;
        public string fName {get; set;} = default!;
        public string lName {get; set;} = default!;
        public string lemployDate {get; set;} = default!;
    }
    public class PreHired : Worker
    {
        public string extended {get; set;} = default!;
        public string accepted {get; set;} = default!;
    }
    public class Employee : Worker
    {
        public string title {get; set;} = default!;
        public double salary {get; set;} = default!;
    }
    public class Retiree : Worker
    {
        public string prog {get; set;} = default!;
        public string retirement {get; set;} = default!;
    }
}