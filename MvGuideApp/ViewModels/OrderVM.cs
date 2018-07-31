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
		DeleteCommand m_deleteCommand;
		public AddCommand AddCmd { get { return m_addCommand; } }
		public DeleteCommand DeleteCmd { get { return m_deleteCommand; } }


		int m_num;

		public OrderVM()
		{
			m_addCommand = new AddCommand(this);
			m_deleteCommand = new DeleteCommand(this);

			Orders = new ObservableCollection<Order>();
			m_num = 1;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}",m_num)));
			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));
		}

		private Order _selectedOrder;

		public Order SelectedOrder
		{
			get { return _selectedOrder; }
			set { _selectedOrder = value;
				m_deleteCommand.RaiseCanExecuteChanged(); 
			}
		}

		internal void DeleteSelected()
		{
			//try/catch
			Orders.Remove(SelectedOrder);
		}

		public ObservableCollection<Order> Orders { get; }

		public void Add()
		{
			m_num++;
			Orders.Add(new Order(m_num.ToString(),
				string.Format("test {0}", m_num)));
		}
	}
}
