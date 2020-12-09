using System;
using ECommerce;

namespace CSharpExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new Customers();

            var marco = new Customer("Marco", "Bellucci", 23);
            var stella = new Customer("Stella", "Marchi", 34);

            list.Add(marco);
            list.Add(stella);



            /*
            Customer customer = new Customer("Chiara", "Bianchi", 17);
            Customer customer2 = new Customer("Chiara", "Bianchi", 27);

            Article spumante = new Article("spumante", 32, "alcool");


            customer.CheckAge();
            customer2.CheckAge();

            spumante.AddToCart(customer);
            spumante.AddToCart(customer2);


            OrderHeader order = new OrderHeader(4545, 12);

            order.Cancel();
            order.Create();
            order.List();
            */


            //Article article = new Article("Face mask", 12.44, 2);

            //Console.WriteLine($"The actual stock is up to: {article.Stock + 20}");
            //article.NameArticle = "changed";
            /*
            article.List();
            article.Retrieve();
            article.Destroy();
            */

            //Console.WriteLine(article.NameArticle);
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
        }
    }
}
