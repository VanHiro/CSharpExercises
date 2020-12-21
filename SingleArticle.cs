using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
	class SingleArticle
	{
		public int IdArticle { get; }
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

		// Questo public Article serve ad Inizializzare i campi della classe quando creiamo un nuovo oggetto.
		//Stabilisce cosa questa nuova istanza deve contenere
		public SingleArticle(string nameArticle, string description, double price, string beverage)
		{
			//This can be written also withouth the THIS
			//NameArticle = nameArticle;
			this.NameArticle = nameArticle;
			this.Description = description;
			this.Price = price;
			this.Beverage = beverage;
		}
		public bool IsOver(Customer customer)
		{
			if (this.Beverage == "alcool" && customer.Age < 18)
			{
				return false;
			}

			return true;
		}
		public void CheckAge(Customer customer)
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
		public void ListItem()
		{
			Console.WriteLine($"The articole you just insereted is {this.NameArticle}, the price is {this.Price} euro.ENDLISTITEM\n\n");
		}
		public void Retrieve()
		{
			Console.WriteLine($"The id of this article is: {this.IdArticle}");
		}
		public void Destroy()
		{
			Console.WriteLine($"The article with id {this.IdArticle} has been deleted");
		}
	}
}