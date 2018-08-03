using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvOrdersApp.ViewModels
{
	public abstract class CommandBase : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public void RaiseCanExecuteChanged()
		{
			CanExecuteChanged(this, EventArgs.Empty);
		}

		public abstract bool CanExecute(object parameter);
		public abstract void Execute(object parameter);
	}


}
