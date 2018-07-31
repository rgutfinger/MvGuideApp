using MvGuideApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvGuideApp.ViewModels
{
	public class OrderVM
	{
		static List<Order> s_orders=new List<Order>();

		public OrderVM()
		{
			s_orders.Add(new Order("1", "test 1"));
			s_orders.Add(new Order("2", "test 2"));
		}

		public List<Order> Orders { get { return s_orders; } }
	}
}
