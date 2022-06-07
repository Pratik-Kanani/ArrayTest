class ArrayTest
{
    public static void Main()
    {
        string[] arrayOfNames = 
            {"Pam", "Jim", "Dwight", "Michael", "Stanley", "Phyllis", "Kelly", "Meridth", "Ryan"};

        foreach(string name in arrayOfNames)
        {
            System.Console.WriteLine(name + " using foreach loop");
        }
        for(int i = 0; i < arrayOfNames.Length; i++)
        {
            System.Console.WriteLine(arrayOfNames[i] + " using for loop");
        }
    }
}