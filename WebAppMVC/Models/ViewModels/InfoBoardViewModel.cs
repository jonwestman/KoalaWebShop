﻿namespace WebAppMVC.Models.ViewModels
{
	public class InfoBoardViewModel
	{
		public ICollection<Order> Orders { get; set; }
	    public ICollection<OrderItem> Items { get; set; }
		public ICollection<Product> Products { get; set; }
		public ICollection<KoalaCustomer> Customers { get; set; }
	}
}
