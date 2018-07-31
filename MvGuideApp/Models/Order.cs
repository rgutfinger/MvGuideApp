using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvGuideApp.Models
{
	public class Order
	{
		public string OrderID { get; set; }
		public string Desc { get; set; }
		public DateTime DeliveryDate { get; set; }

		public Order(string id, string desc)
		{
			OrderID = id;
			Desc = desc;
			DeliveryDate = DateTime.Now;
		}
	}
}
