using System;
using System.Linq;
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
            User pino = new User
        }
    }
}




        /* THE BIG PICTURE EXERCISE
        //Milestone 1
        //we can create new customers
        Customer mattia = new Customer("Mattia", "Basagli", 27);
        Customer maria = new Customer("Maria", "Tenti", 45);
        //we can create new articles
        SingleArticle mirtillo = new SingleArticle("Succo al Mirtillo", "Best drunk at room temperature", 2.50, "succo");
        SingleArticle aranciata = new SingleArticle("Aranciata", "Best drunk fresh", 3.00, "bevanda");
        SingleArticle limonata = new SingleArticle("Limonata", "Best served hot", 4.00, "bevanda");
        //we can create a list of articles
        Articles beverages = new Articles();
        //we can add items to the list
        beverages.Add(mirtillo);
        beverages.Add(aranciata);
        beverages.Add(limonata);
        //we can list all the articles
        beverages.List();

        //Milestone 2
        //we can search for an article by its description, and we can print its price
        beverages.SearchByDescr("brewed");

        //Milestone 3
        //we can create a cart and assign it to a user
        Cart cartMaria = new Cart(maria);
        SingleArticle fragolino = new SingleArticle("Fragolino", "Best served icy", 4.00, "bevanda");
        SingleArticle cedrata = new SingleArticle("Cedrata", "Best served cold", 2.00, "bevanda");

        //we can add each article to the cart
        cartMaria.Add(fragolino);
        cartMaria.Add(cedrata);

        //we can search an article by its description and add it to the cart
        SingleArticle found = beverages.SearchByDescr("brewed");
        if (found != null)
        {
            cartMaria.Add(found);
        } else
        {
            Console.WriteLine("Nessun articolo corrispondente ai criteri");
        }

        //we can show what's in the cart
        cartMaria.List();

        //we can provide the user with a total price of all the articles in the cart
        cartMaria.TotalPrice();
        */


        //TESTING PREVIOUS EXERCISES 
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