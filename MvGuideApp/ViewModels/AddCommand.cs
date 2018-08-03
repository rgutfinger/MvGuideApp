using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvGuideApp.ViewModels
{

	public class AddCommand : CommandBase
	{
		OrderVM m_orderVM;

		public AddCommand(OrderVM orderVM)
		{
			m_orderVM = orderVM;
		}

		public override bool CanExecute(object parameter)
		{	// always available
			return true;
		}

		public override void Execute(object parameter)
		{
			m_orderVM.Add();			
		}


	}

}
