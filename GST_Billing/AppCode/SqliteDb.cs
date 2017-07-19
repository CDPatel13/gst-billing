using GST_Billing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaneshLogistics.AppCode
{
    public class SqliteDb
    {
        List<string> CreateTableList = new List<string>();
        List<string> InsertExpenseDetails = new List<string>();
        string ConnectionString = "";//data source=MyDatabase.sqlite

        DataTable dt;
        SQLiteDataAdapter da;
        string databasePath = "";
        string path = @"D:\GST\";    //GaneshLogistics, GaneshSales
        string path1 = @"C:\GST\";

        public SqliteDb()
        {
            getDatabasePath();
        }

        private void CreateTables()
        {
            CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [userDetails] (
	                                userId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                name	TEXT NOT NULL UNIQUE,
	                                address	TEXT NOT NULL,
	                                email	TEXT,
	                                phoneNumber	INTEGER NOT NULL,
	                                gstin	TEXT NOT NULL,
	                                state	TEXT,
	                                code	TEXT
                                )");

            CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [customerDetails] (
	                                custId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                custname	TEXT NOT NULL UNIQUE,
	                                custaddress	TEXT NOT NULL,
                                    custemail	TEXT,
	                                custphoneNumber	INTEGER NOT NULL,
	                                custstate	TEXT,
	                                custcode	TEXT,
	                                custgstin	TEXT NOT NULL,
									shipname	TEXT NOT NULL,
									shipaddress	TEXT,
									shipemail	TEXT,
									shipphoneNumber	INTEGER NOT NULL,
									shipstate	TEXT,
									shipcode	TEXT,
									shipgstin	TEXT NOT NULL
                                )");

            CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [invoiceDetails] (
	                                invoiceId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                invoiceNo	TEXT NOT NULL UNIQUE,
	                                invoiceDate	DATETIME NOT NULL,
	                                custId	INTEGER NOT NULL,
                                    userId INTEGER NOT NULL,
	                                shipPartyName	TEXT,
	                                shipPartyAddress	TEXT,
	                                shipGstIn	TEXT,
	                                shipState	TEXT NOT NULL,
	                                shipCode	TEXT,
	                                totalQnty	DECIMAL(6,2),
	                                totalAmount	DECIMAL(8,2),
	                                totaDiscount	DECIMAL(8,2),
	                                totalTaxAmount	DECIMAL(8,2),
	                                totalSGSTAmount	DECIMAL(8,2),
	                                totaCGSTAmount	DECIMAL(8,2),
	                                totalIGSTAmount	DECIMAL(8,2),
	                                totalBillAmount	DECIMAL(8,2),
	                                IsActive	BIT(1) DEFAULT 1,
	                                FOREIGN KEY(custId) REFERENCES customerDetails ( custId ) 
                                    ON DELETE NO ACTION 
                                    ON UPDATE NO ACTION
                                )");

            CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [invoiceProductDetails] (
	                                productId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                invoiceId	INTEGER NOT NULL,
	                                productName	TEXT NOT NULL UNIQUE,
	                                productCode	TEXT NOT NULL,
	                                productQnty	DECIMAL(8,2) NOT NULL,
	                                ProductUnit	TEXT,
	                                productUnitPrice	DECIMAL(8,2) NOT NULL,
	                                productAmount	DECIMAL(8,2),
	                                productDiscount	DECIMAL(8,2),
	                                productTaxAmount	DECIMAL(8,2),
	                                FOREIGN KEY(invoiceId) REFERENCES invoiceDetails ( invoiceId ) 
                                    ON DELETE NO ACTION 
                                    ON UPDATE NO ACTION
                                )");

            CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [additionalCharges] (
	                                chargeNo	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	                                invoiceId	INTEGER NOT NULL,
	                                chargeName	TEXT NOT NULL UNIQUE,
	                                chargeAmount	DECIMAL(8,2) NOT NULL,
	                                FOREIGN KEY(invoiceId) REFERENCES invoiceDetails ( invoiceId ) 
                                    ON DELETE NO ACTION 
                                    ON UPDATE NO ACTION
                                )");
        }

        public void CreateDatabase()
        {
            try
            {
                if (!File.Exists(databasePath))
                {
                    SQLiteConnection.CreateFile(databasePath);
                    CreateTables();

                    using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                    {
                        con.Open();
                        using (SQLiteTransaction tr = con.BeginTransaction())
                        {
                            using (SQLiteCommand com = new SQLiteCommand(con))
                            {
                                foreach (string strQuery in CreateTableList)
                                {
                                    com.CommandText = strQuery;
                                    com.ExecuteNonQuery();
                                }                              
                            }
                            tr.Commit();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
            }
            finally
            {
                CreateTableList.Clear();
                InsertExpenseDetails.Clear();
            }
        }

        private void getDatabasePath()
        {
            if (Directory.Exists(@"D:\"))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                databasePath = path + "MyDatabase.sqlite";
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path1));
                databasePath = path1 + "MyDatabase.sqlite";
            }
            ConnectionString = "data source=" + databasePath;
        }

        public void QueryLogger(string strSql)
        {
            //StreamWriter sr = null;
            try
            {
                //if (!Directory.Exists("sqllog.log"))
                //    File.Create("sqllog.log");    
                string filePath = "";
                if (Directory.Exists(@"D:\"))
                    filePath += path + "sqllog.log";
                else
                    filePath += path1 + "sqllog.log";

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                using (StreamWriter stream = new StreamWriter(filePath, true))
                {
                    //sr = new StreamWriter("sqllog.log", true);
                    stream.WriteLine(System.DateTime.Now.ToString() + strSql + ";");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
            /*finally
            {
                if(sr != null)
                    sr.Close();
            }*/
        }

        public DataSet selectData(string sqlstr)
        {
            QueryLogger("-selectData->" + sqlstr);

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    DataSet ds = new System.Data.DataSet();
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        com.CommandText = sqlstr;
                        SQLiteDataAdapter da = new SQLiteDataAdapter(com);
                        da.Fill(ds);
                    }
                    con.Close();
                    return ds;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
            return null;
        }

        public int Ins_Upd_Del(string sqlstr)
        {
            QueryLogger("-Ins_Upd_Del->" + sqlstr);

            try
            {
                int numberOfRows = 0;
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    using (SQLiteTransaction tr = con.BeginTransaction())
                    {
                        using (SQLiteCommand com = new SQLiteCommand(con))
                        {
                            com.CommandText = sqlstr;
                            numberOfRows = com.ExecuteNonQuery();
                        }
                        tr.Commit();
                    }
                    con.Close();
                    return numberOfRows;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message); ;
            }
            return 0;
        }

        public string scaler(string sqlstr)
        {
            QueryLogger("-scaler->" + sqlstr);

            try
            {
                string s1;
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        com.CommandText = sqlstr;
                        s1 = Convert.ToString(com.ExecuteScalar());
                    }
                    con.Close();
                    return s1;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
            return null;
        }

        public InvoiceDetails selectDataAdapter(string sqlstr, int tableIndex)
        {
            QueryLogger("-selectDataTable->" + sqlstr);
            InvoiceDetails dsInvoiceDetails = new InvoiceDetails();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        com.CommandText = sqlstr;
                        da = new SQLiteDataAdapter(com);

                        if (tableIndex == 1)
                            da.Fill(dsInvoiceDetails.invoiceBill);
                    }
                    con.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
            return dsInvoiceDetails;
        }

        public DataTable selectDataTable(string sqlstr)
        {
            QueryLogger("-selectDataTable->" + sqlstr);

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        com.CommandText = sqlstr;

                        da = new SQLiteDataAdapter(com);
                        SQLiteCommandBuilder commandbuilder = new SQLiteCommandBuilder(da);
                        dt = new DataTable();

                        dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        da.Fill(dt);
                    }
                    con.Close();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Something went wrong :" + ex.Message);
            }
            return dt;
        }
    }
}
