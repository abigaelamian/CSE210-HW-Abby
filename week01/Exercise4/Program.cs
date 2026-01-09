using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("Abigail");
        names.Add("Masitsa");
        names.Add("Malina");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}