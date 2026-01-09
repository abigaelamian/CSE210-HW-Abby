using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("you are an adult");
        }
        else
        {
            Console.WriteLine("you are a minor");
        }
    }
}