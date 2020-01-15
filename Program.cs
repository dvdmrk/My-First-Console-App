using System;

namespace My_First_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine($"Hello {name}");
            var age = GetAge();
            Console.WriteLine($"{name} is {age} years old.");
        }
        static string GetName()
        {
            Console.WriteLine("Please input name:");
            return Console.ReadLine();
        }
        static string GetAge()
        {
            Console.WriteLine("Please input your age:");
            return Console.ReadLine();
        }
    }
}
