using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvOrdersApp.ViewModels
{

	public class AddCommand : CommandBase
	{
		OrderVM m_orderVM;

		public AddCommand(OrderVM orderVM)
		{
			m_orderVM = orderVM;
		}

		public override bool CanExecute(object parameter)
		{
			return !string.IsNullOrWhiteSpace(m_orderVM.Desc);
			//return true;
		}

		public override void Execute(object parameter)
		{
			m_orderVM.Add();			
		}


	}

}
