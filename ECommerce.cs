using System;
using System.Collections.Generic;

namespace ECommerce
{
	class Customer
	{
		//proprietà
		protected int Id;
		protected string FirstName;
		protected string LastName;
		protected string Address;
		protected int Cap;
		protected string City;
		protected string Email;
		protected string Password;

		public int Age { get; set; }

		public Customer(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		//prints something
		public void Login()
		{
			Console.WriteLine($"Hi, {this.FirstName} {this.LastName} you are now logged in");
		}

		//This one checks that the age is correct. Below i do it with the order
		public void CheckAge()
		{
			if (Age < 18)
			{
				Console.WriteLine("You may not be able to purchase certain items.");
			}
			else
			{
				Console.WriteLine("");
			}
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
	public class Customers
	{
		private List<Customer> listedCustomers = new List<Customer>();
	}


	class Article
	{
		public int Id { get; }
		public string NameArticle { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		private string Beverage;

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
		public Article(string nameArticle, double price, string beverage)
		{
			//This can be written also withouth the THIS
			//NameArticle = nameArticle;
			this.NameArticle = nameArticle;
			this.Price = price;
			this.Beverage = beverage;
		}

		/*public void UpdateStock ()
		{
			this.Stock = stock + 20;
		}*/

		public bool IsOver(Customer customer)
		{
			if (this.Beverage == "alcool" && customer.Age < 18)
			{
				return false;
			}

			return true;
		}
		public void AddToCart(Customer customer)
		{
			if (this.IsOver(customer))
			{
				Console.WriteLine($"{this.NameArticle} has been added to your cart.");
			}
			else
			{
				Console.WriteLine("The item you are trying to order can only be bought by people who are 18 years old or older.");
			}
		}
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
	class OrderHeader
	{
		private int Id;
		private DateTime Date;
		private int OrderNumber;
		private int IdCustomer;

		public OrderHeader(int orderNumber, int idCustomer)
		{
			this.OrderNumber = orderNumber;
			this.IdCustomer = idCustomer;
		}

		public void Create()
		{
			Console.WriteLine($"The order number {this.OrderNumber} has been placed in date {this.Date}. To find the order look for the ID {this.Id}");
		}

		public void Cancel()
		{
			Console.WriteLine($"The order number {this.OrderNumber} has been successfully canceled");
		}

		public void List()
		{
			Console.WriteLine("Here you can find the order's history");
		}
	}
}
