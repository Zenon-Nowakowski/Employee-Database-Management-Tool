namespace Program1
{
    class sort
    {
        public static void bubbleSort(string[] lines)
        {
            string[] narray = new string[lines.Count()];
            //Create an array of names out of provided array of lines, break down into collumns
            for(int k = 0; k < lines.Count(); k++)
            {
                var names = lines[k].Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries);
                narray[k] = names[3];
            }
            //Using created name array, compare that and flip the lines array if name is not in correct spot, bubble sort array0 by using array1 essentially
            for(int j = 1; j < lines.Length; j++)
            {   
                for(int i = 1; i < lines.Length - 1; i++)
                {
                    //if narray[i] > narray[i+1] swap 
                    if(narray[i].CompareTo(narray[i+1]) > 0) 
                    {
                        //unfortuantly this ends up being really inneffeciant even for bubble sort, have to swap in both arrays 
                        Console.WriteLine("Switching " + narray[i] + " with " + narray[i+1]);
                        Console.WriteLine("\n\n");
                        var temp = lines[i];
                        lines[i] = lines[i+1];
                        lines[i+1] = temp;
                        temp = narray[i];
                        narray[i] = narray[i+1];
                        narray[i+1] = temp;
                        Console.WriteLine("\n\n");
                    }
                }
            }
        }
    }
}