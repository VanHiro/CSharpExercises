using System.Diagnostics;
using System.Linq;
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