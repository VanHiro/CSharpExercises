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
		public SingleArticle SearchByDescr(string target)
		{
			//foreach (SingleArticle article in _articlesList)
			//{
				//article.Description.Find sarebbe stato meglio
				//if (article.Description.Contains(target))
				if(_articlesList.Find(article => article.Description.Contains(target )))
				{
					Console.WriteLine($"{article} ENDSEARCH\n\n");
					return article;
				}
			//}
			//return "null";
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