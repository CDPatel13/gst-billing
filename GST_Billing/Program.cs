using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace GST_Billing
{
    static class Program
    {
        static List<String> GetMACAddress()
        {
            List<String> MacList = new List<string>();
            NetworkInterface[] mac_list = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ne in mac_list)
            {
                String mac = ne.GetPhysicalAddress().ToString();
                if (!String.IsNullOrEmpty(mac))
                    MacList.Add(mac);
            }

            return MacList;
        }

        static String ReadKey(String pKey)
        {
            String KEY_SOFTWARE = "Software";
            String KEY_GST_BILLING = "GST_Billing";
            String KEY_ENCRYPTION = "E_keys";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(KEY_SOFTWARE, true);
            key.CreateSubKey(KEY_GST_BILLING);
            key = key.OpenSubKey(KEY_GST_BILLING, true);

            key.CreateSubKey(KEY_ENCRYPTION);
            key = key.OpenSubKey(KEY_ENCRYPTION, true);

            String value = key.GetValue(pKey,"").ToString();
            return value;
        }
        
        static Boolean Proceed()
        {
            return true;
            Boolean proceed = false;
            try
            {
                string plaintext = "Chaitany@Darpan@Nirav";
                List<String> MacList = GetMACAddress();
               
                foreach (String mac in MacList)
                {
                    String encrypted_value = ReadKey(mac);

                    if (String.IsNullOrEmpty((encrypted_value)))
                    {
                        continue;
                    }
                    String decrypted_value = StringCipher.Decrypt(encrypted_value, mac);

                    if (plaintext.Equals(decrypted_value))
                    {
                        proceed = true;
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                proceed = false;
            }
            return proceed;            
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            if (!Proceed())
            {
                MessageBox.Show("Unlicensed Product. \nCall on : 9879539134 to get valid license", "Unlicensed Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
         
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
