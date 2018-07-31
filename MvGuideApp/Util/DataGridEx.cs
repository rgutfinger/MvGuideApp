using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Util
{
    public static class DataGridEx
    {
        public static void RenameColumns(this DataGrid grid, string[] cols,string[] newCols)
        {
            ObservableCollection<DataGridColumn> cols0 =grid.Columns;
            for (int ix = 0; ix < cols.Length; ix++)
            {
                string col = cols[ix];
                DataGridColumn gcol= cols0.Where(c => c.Header.Equals(col)).FirstOrDefault();
                if (gcol != null)
                    gcol.Header = newCols[ix];
            }
        }


    }
}
