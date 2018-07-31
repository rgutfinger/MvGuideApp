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
		int m_num;

		public OrderVM()
		{
			Orders = new List<Order>();
			m_num = 1;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}",m_num)));
			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));
		}

		public List<Order> Orders { get; }

		public void Add()
		{
			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));

			// onPropertyChange???
		}
	}
}
