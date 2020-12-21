using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
	class Cart
	{
		private int _id;
		private int _idUser;
		protected List<SingleArticle> _shoppingList;
		public List<SingleArticle> ShoppingList
		{
			get => _shoppingList;
		}
		public int Id { get => _id; }
		public int IdUser { get => _idUser; }
		public Cart(Customer customer)
		{
			this._shoppingList = new List<SingleArticle>();
			this._idUser = customer.Id;
		}
		public void AddToCart(SingleArticle article)
		{
			_shoppingList.Add(article);
		}
		public void ListCart()
		{
			foreach (SingleArticle article in this._shoppingList)
			{
				Console.Write($"Name Article: {article.NameArticle}, \nDescription: {article.Description}, \nPrice: {article.Price} ENDCART\n\n");
			}
		}
		public void TotalPrice()
		{
				double total = _shoppingList.Aggregate(0.00, (acc, val) => acc + val.Price);
				Console.WriteLine($"The total value of your cart is: {total} ENDTOTALPRICE\n\n");
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
}
