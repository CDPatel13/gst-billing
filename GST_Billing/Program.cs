using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            string GUID = Assembly.GetExecutingAssembly().GetType().GUID.ToString();
            using (Mutex mutex = new Mutex(false, @"Global\" + GUID))
            {
                if(!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Instance already running");
                    return;
                }
   
                GC.Collect();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                SqliteDb objSqlLite = new SqliteDb();
                objSqlLite.CreateDatabase();

                Application.Run(new Login());
            }
        }
    }
}
