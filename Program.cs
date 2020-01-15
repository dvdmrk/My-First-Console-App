using System;

namespace My_First_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = GetName();
            //String interpolation - by prefacing a string with a '$' we can use '{}' to insert variables 
            Console.WriteLine($"Hello {name}");
            // TODO: Step 2
            /* Assign the value of the GetAge method to a variable named age then uncomment the following line. */
            // Console.WriteLine$("{name} is {age} years old.");
        }
        //Method construction consists of an access modifier, a return type, a name, and paramaters.
        /*Modifier: private
        Return Type: string
        Name: GetName
        Parameters: none */
        static string GetName() {
            Console.WriteLine("Please input name:");
            return Console.ReadLine();
        }
        // TODO: Step 1
        /* static ? GetAge {
        Complete this function so that it will prompt a user for their 
        age, then return their age. 
        } */
    }
}
