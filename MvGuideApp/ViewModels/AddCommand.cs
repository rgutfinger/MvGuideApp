﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvGuideApp.ViewModels
{
	public class AddCommand : ICommand
	{
		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			// how get to VM? .Add
			
		}

		public event EventHandler CanExecuteChanged;

	}

}
