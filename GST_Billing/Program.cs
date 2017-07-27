using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_Billing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SqliteDb objSqlLite = new SqliteDb();
            objSqlLite.CreateDatabase();

            Application.Run(new MainWindow());
            //Application.Run(new Home());
        }
    }
}
