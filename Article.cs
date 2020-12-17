using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
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
		public Article(string nameArticle, string description, double price, string beverage)
		{
			//This can be written also withouth the THIS
			//NameArticle = nameArticle;
			this.NameArticle = nameArticle;
			this.Description = description;
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
		public void SearchDescr(string searchFor)
		{
			foreach (Article article in _articlesList)
			{
				if (article.Description.Contains(searchFor) == true)
				{
					Console.WriteLine($"Name article: {article.NameArticle}, price: {article.Price}\n\n");
				}
				else
				{
					Console.WriteLine("Non sono stati trovati articoli per le parole chiave di ricerca scelte");
				}
			}
		}
		public void Add(Article article)
		{
			this._articlesList.Add(article);
		}
		public void List()
		{
			foreach (Article article in this._articlesList)
			{
				Console.Write($"Name Article: {article.NameArticle}, \nDescription: {article.Description}, \nPrice: {article.Price}, \nType of beverage: {article.Beverage}\n\n");
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
}