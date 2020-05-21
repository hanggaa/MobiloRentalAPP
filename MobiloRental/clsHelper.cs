using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using Library;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobiloRental
{
    public class clsHelper
    {
        public static void setGridMasterSelected(GridView gridView, string colname, string findValue)
        {
            try
            {
                int i = gridView.LocateByValue(colname, findValue);

                gridView.FocusedRowHandle = i;
                gridView.SelectRow(i);
                gridView.MakeRowVisible(i, false);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
