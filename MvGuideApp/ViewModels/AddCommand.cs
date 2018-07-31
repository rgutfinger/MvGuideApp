using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvGuideApp.ViewModels
{

	// **********next use the cmd base class

	public class AddCommand : ICommand
	{
		OrderVM m_orderVM;

		public AddCommand(OrderVM orderVM)
		{
			m_orderVM = orderVM;
		}

		public bool CanExecute(object parameter)
		{	// selection based
			return true;
		}

		public void Execute(object parameter)
		{
			m_orderVM.Add();			
		}


		//**to base
		public event EventHandler CanExecuteChanged;

		//**to base
		public void RaiseCanExecuteChanged()
		{
			CanExecuteChanged(this, EventArgs.Empty);
		}
	}

}
