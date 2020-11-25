using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            string upperCase = name.ToUpper(); 
            Console.WriteLine(upperCase); 
        }
    }
}
