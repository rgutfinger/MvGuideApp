using MvGuideApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvGuideApp.ViewModels
{
	public class OrderVM
	{
		//public MyICommand DeleteCommand { get; set; }
		AddCommand m_addCommand;
		public AddCommand AddCmd { get { return m_addCommand; } }

		int m_num;

		public OrderVM()
		{
			m_addCommand = new AddCommand(this);

			Orders = new ObservableCollection<Order>();
			m_num = 1;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}",m_num)));
			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));
		}

		public ObservableCollection<Order> Orders { get; }

		public void Add()
		{
			//need model/prop Change...

			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));

			// onPropertyChange???
		}
	}
}
