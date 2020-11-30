using System;

namespace ECommerce
{
	class Customer {
		//proprietà
		protected int Id;
		protected string FirstName;
		protected string LastName;
		protected string Address;
		protected int Cap;
		protected string City;
		protected string Email;
		protected string Password;

		public Customer(string firstName, string lastName) 
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
		//prints something
		public void Login()
		{
			Console.WriteLine($"Hi, {this.FirstName} {this.LastName} you are now logged in");
		}
		public void AddToCart()
		{
			Console.WriteLine("Congratulations, the order was placed");
		}
		public void MyOrders()
		{
			Console.WriteLine("Your previous orders are:");
		}
		public void WishList()
		{
			Console.WriteLine("The items you wish you'd have are:");
		}
		public void Cart()
		{
			Console.WriteLine("The items on your cart are:");
		}
		public void SignUp()
		{
			Console.WriteLine("To sign up enter your information here");
		}
	}
	class Article
	{
		public int Id { get; }
		public string NameArticle { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		//DO I NEED THE SET TO BE ABLE TO EDIT THE STOCK? OR IS IT AUTOMATIC?
		public int Stock 
		{ 
			get
			{
				return 20;
			}		
				
		}
		public int TaxRate { get; }

		// Questo public Article serve ad Inizializzare i campi
		// della classe quando creiamo un nuovo oggetto.
		//Stabilisce cosa questa nuova istanza deve contenere
		public Article(string nameArticle, double price, int id)
		{
			//This can be written also withouth the THIS
			//NameArticle = nameArticle;
			this.NameArticle = nameArticle;
			this.Price = price;
			this.Id = id;
		}

		/*public void UpdateStock ()
		{
			this.Stock = stock + 20;
		}*/

		public void List()
		{
			Console.WriteLine($"The articole you just insereted is {this.NameArticle}, the price is {this.Price} euro.");
		}

		public void Retrieve()
		{
			Console.WriteLine($"The id of this article is: {this.Id}");
		}

		public void Destroy()
		{
			Console.WriteLine($"The article with id {this.Id} has been deleted");
		}
	}
}
