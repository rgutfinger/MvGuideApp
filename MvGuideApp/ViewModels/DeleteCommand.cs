using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvGuideApp.ViewModels
{
	public class DeleteCommand : ICommand
	{
		OrderVM m_orderVM;

		public DeleteCommand(OrderVM orderVM)
		{
			m_orderVM = orderVM;
		}

		public bool CanExecute(object parameter)
		{	// selection based
			return m_orderVM.SelectedOrder!=null;
		}

		public void Execute(object parameter)
		{
			m_orderVM.DeleteSelected();			
		}

		public event EventHandler CanExecuteChanged;

		public void RaiseCanExecuteChanged()
		{
			CanExecuteChanged(this, EventArgs.Empty);
		}
	}

}
