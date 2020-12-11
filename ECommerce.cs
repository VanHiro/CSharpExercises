using System;
using System.Collections.Generic;

namespace ECommerce
{
	class Customer
	{
		//attributes
		private int _id;
		private string _firstName;
		private string _lastName;
		private string _address;
		private int _cap;
		private string _city;
		private string _email;
		private string _password;
		private int _age;

		//properties
		public int Id { get => _id; set => _id = value; }
		public string FirstName { get => _firstName; set => _firstName = value; }
		public string LastName { get => _lastName; set => _lastName = value; }
		public string Email { get => _email; set => _email = value; }
		public int Age
		{
			get => _age;
			set
			{
				_age = value;
			}
		}

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
	class Customers
	{
		private List<Customer> _customersList;
		public List<Customer> CustomersList
		{
			get => _customersList;
		}

		public Customers()
		{
			//avendo le graffe non accetta le proprieta', un po'  comeget e set
			//private List<Customer> listedCustomers = new List<Customer>{ };
			this._customersList = new List<Customer>();
		}


		public void Add(Customer myCustomer)
		{
			//now this method is able to accept stuff from the outside (from program)
			this.CustomersList.Add(myCustomer);
		}

		public void Remove(Customer myCustomer)
		{
			this._customersList.Remove(myCustomer);
		}

		public void List()
		{
			foreach (Customer customer in this._customersList)
			{
				Console.WriteLine($"Id: {customer.Id}, Firstname: {customer.FirstName}, Lastname: {customer.LastName}, email: {customer.Email}");
			}
		}
	}

		class Article
		{
			public int Id { get; }
			public string NameArticle { get; set; }
			public string Description { get; set; }
			public double Price { get; set; }
			public string Beverage;

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
		class Articles
		{
			private List<Article> _articlesList;
			public List<Article> ArticlesList
			{
				get => _articlesList;
			}

			public Articles()
			{
				this._articlesList = new List<Article>();
			}

			public void List()
			{
				foreach (Article article in this._articlesList)
				{
					Console.Write($"Id: {article.Id}, Name Article: {article.NameArticle}, Description{article.Description}, Price: {article.Price}, Type of beverage: {article.Beverage}");
				}
			}
			public void Update(Article article)
			{
				Update(article);
			}

			public void Destroy(Article article)
			{
				Destroy(article);
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

		class OrderDetail
		{
			private int _id;
			private int _customerId;
			private int _price;
			private int _quantity;

			public int Id { get => _id; }
			//public int CustomerId { get => _customerId; set => _customerId = Customer.Id; }
			public int Price { get => _price; }
			public int Quantity { get => _quantity; }
		}

		class Cart
		{
			private int _id;
			private int _idArticle;
			private int _idUser;
			private int _nItems;

			public int Id { get => _id; }
			public int IdArticle { get => _idArticle; }
			public int IdUser { get => _idUser; }
			public int NItems { get => _nItems; set => _nItems = value; }

			public void List()
			{
				Console.WriteLine("Here are the items in your cart:");
			}
			public void Delete()
			{
				Console.WriteLine("The item has been deleted");
			}
			public void Buy()
			{
				Console.WriteLine("You successfully bought all the items");
			}
		}
		
	class Admin
	{
		protected string Administrator;

		public void ManageOrders()
		{
			Console.WriteLine("Here you can manage the orders on your e-commerce");
		}
		public void ManageArticles()
		{
			Console.WriteLine("Here you can manage the items being sold on your shop");
		}
		public void ManageCustomers()
		{
			Console.WriteLine("Here you can manage the customers that buy from your shop");
		}
	}
}

