using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
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
}