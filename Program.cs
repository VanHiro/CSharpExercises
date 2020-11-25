using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine($"Your name is {myName.ToUpper()}"); 
        }
    }
}
