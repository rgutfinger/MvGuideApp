using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace Util
{
	public static class ExceptionEx
	{
		static string BuildMessage(this Exception ex)
		{
			string message = ex.Message;
			Exception exNext = ex.InnerException;
			do
			{
				if (exNext != null)
				{
					message = string.Format(" {0}\r\n  {1}", message, exNext.Message);
					exNext = exNext.InnerException;
				}
			} while (exNext != null);

			return message;
		}


		public static void DisplayError(this Exception ex)
		{
			string message = ex.BuildMessage();
			MessageBox.Show(message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
		}

	}
}
