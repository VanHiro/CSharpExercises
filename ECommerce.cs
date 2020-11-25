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
			Console.WriteLine($"Hi, {this.FirstName} you are now logged in");
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
}
