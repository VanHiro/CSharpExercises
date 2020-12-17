using System;
using System.Collections.Generic;
using ExLinq;
using Examples;
using ECommerce;
using CSharpExercises;

namespace CSharpExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Milestone 1
            //we can create new customers
            Customer mattia = new Customer("Mattia", "Basagli", 27);
            Customer maria = new Customer("Maria", "Tenti", 45);
            //we can create new articles
            Article mirtillo = new Article("Succo al Mirtillo", "Best drunk fresh", 2.50, "succo");
            Article aranciata = new Article("Aranciata", "Best drunk fresh", 3.00, "bevanda");
            Article limonata = new Article("Limonata", "Best served hot", 4.00, "bevanda");
            //we can add each article to Articles
            Articles beverages = new Articles();

            beverages.Add(mirtillo);
            beverages.Add(aranciata);
            beverages.Add(limonata);

            //we can list all the articles 
            beverages.List();

            //Milestone 2
            //we can search for an article by its description, and we can print its price
            //SEARCH DRAFT
            beverages.SearchDescr("fresh");
           

            //var peaksList = Mountains.ParseNames("Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano");

            //var city = FilteringUtils.Search("Arezzo");

            //let firstChar = --- (usato per congelare quel dato e usarlo piu' avanti (utile per l'esercizio))

            /*
             * EXAMPLE*
            string city = FilteringUtils.Search("Siena");
            Console.WriteLine(city);
            */

            /*
            var list = new Customers();

            var marco = new Customer("Marco", "Bellucci", 23);
            var stella = new Customer("Stella", "Marchi", 34);

            list.Add(marco);
            list.Add(stella);
            */


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
