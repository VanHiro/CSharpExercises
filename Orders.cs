using System.Diagnostics;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ECommerce
{
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
}