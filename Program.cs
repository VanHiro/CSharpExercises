using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstCustomer = new Customer(); OPPURE
            Customer firstCustomer = new Customer("Vanessa", "Maccherini");
            firstCustomer.Login();
            //Console.WriteLine("Enter your name: ");
            //string myName = Console.ReadLine();
            //Console.WriteLine($"Your name is {myName.ToUpper()}");  
        }
    }
}
