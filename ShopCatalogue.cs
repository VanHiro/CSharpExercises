using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
	class Articles
	{
		protected List<SingleArticle> _articlesList;
		public List<SingleArticle> ArticlesList
		{
			get => _articlesList;
		}

		public Articles()
		{
			_articlesList = new List<SingleArticle>();
		}
		public void SearchDescr(string searchFor)
		{
			foreach (SingleArticle article in _articlesList)
			{
				if (article.Description.Contains(searchFor) == true)
				{
					Console.WriteLine($"{article} ENDSEARCH\n\n");
				}
			}
		}
		public void Add(SingleArticle article)
		{
			_articlesList.Add(article);
		}
		public void List()
		{
			foreach (SingleArticle article in this._articlesList)
			{
				Console.Write($"Name Article: {article.NameArticle}, \nDescription: {article.Description}, \nPrice: {article.Price}, \nType of beverage: {article.Beverage} ENDLISTING\n\n");
			}
		}
		public void Update(SingleArticle article)
		{
			Update(article);
		}

		public void Destroy(SingleArticle article)
		{
			Destroy(article);
		}
	}
}