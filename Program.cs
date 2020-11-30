using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Console.WriteLine("Enter your name"); 
           string myName = Console.ReadLine();
           string upperCased = myName.ToUpper();    
     
           Console.WriteLine($"Your name in capital letters is {upperCased}");
           */

            /*
            if(args.Length > 0 ){  
                Console.WriteLine($"The inserted parameter is {args[0]}");
            }   
            else{
                Console.WriteLine("Please, insert a parameter");
            }
            */

            /*
            //var firstCustomer = new Customer(); OPPURE
            Customer firstCustomer = new Customer("Vanessa", "Maccherini");

            //Richiamo il costruttore per un nuovo cliente e aggiungo la email

            Customer myCustomer = new Customer("Beatrice", "Sarti", "bea@gmail.com");
            Console.WriteLine(myCustomer.Login());
            */
            Article article = new Article("Face mask", 12.44, 2);
  
            article.Retrieve();
            article.Destroy();
        }
    }
}
