using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvOrdersApp.ViewModels
{
	public class DeleteCommand : CommandBase
	{
		OrderVM m_orderVM;

		public DeleteCommand(OrderVM orderVM)
		{
			m_orderVM = orderVM;
		}

		public override bool CanExecute(object parameter)
		{	// selection based
			return m_orderVM.SelectedOrder!=null;
		}

		public override void Execute(object parameter)
		{
			m_orderVM.DeleteSelected();			
		}
	}

}
