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
		List<string> InsertDetails = new List<string>();
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
			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [loginDetails] (
									loginId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									username TEXT NOT NULL,
									password TEXT NOT NULL
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [userDetails] (
									userId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									name	TEXT,
									companyname	TEXT NOT NULL,
									address	TEXT NOT NULL,
									landmark	TEXT NOT NULL,
									city	TEXT NOT NULL,
									state	TEXT,
									code	TEXT,
									pincode INTEGER,
									email	TEXT,
									phoneNumber	INTEGER NOT NULL,
									gstin	TEXT NOT NULL,	                                
									panno	TEXT,
									bankname	TEXT,
									branchname	TEXT,
									accountno	INTEGER,
									ifsccode	TEXT
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [paymentTerms] (
									termId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									termName	TEXT NOT NULL UNIQUE,
									isActive	BIT(1) DEFAULT 1
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [productDetails] (
									productId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									productName	TEXT NOT NULL,
									hsnCode		TEXT,
									productPrice	DECIMAL(8,2) NOT NULL,
									productUnit	TEXT,
									userId		INTEGER NOT NULL,
                                    FOREIGN KEY (userId) REFERENCES userDetails (userId)
									ON DELETE NO ACTION
									ON UPDATE NO ACTION
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [customerDetails] (
									custId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									custname	TEXT NOT NULL,
									custContactPerson TEXT,
									custaddress	TEXT NOT NULL,
									custlandmark	TEXT,
									custcity	TEXT,
									custstate	TEXT,
									custcode	TEXT,
									custpincode	INTEGER,
									custemail	TEXT,
									custphoneNumber	INTEGER,
									custgstin	TEXT NOT NULL,
									custAadharNo	TEXT,
									custPanno	TEXT,
									custpaymentTermName TEXT,
									shipname	TEXT NOT NULL,
									shipContactPerson TEXT,
									shipaddress	TEXT,
									shiplandmark	TEXT,
									shipcity	TEXT,
									shipstate	TEXT,
									shipcode	TEXT,
									shippincode	INTEGER,
									shipemail	TEXT,
									shipphoneNumber	INTEGER,
									shipgstin	TEXT NOT NULL,
									shipAadharNo	TEXT,
									shipPanno	TEXT,
									shippaymentTermName TEXT,
                                    userId		INTEGER NOT NULL,
                                    FOREIGN KEY (userId) REFERENCES userDetails (userId)
									ON DELETE NO ACTION
									ON UPDATE NO ACTION
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [invoiceDetails] (
									invoiceId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									invoiceNo	TEXT NOT NULL,
									invoiceDate	TEXT NOT NULL,
									custId		INTEGER NOT NULL,
									userId		INTEGER NOT NULL,
                                    poNo	    TEXT,
                                    poDate	    TEXT,
									termName	TEXT,
									shipName	TEXT,
									shipAddress	TEXT,
									shipLandmark TEXT,
									shipCity	TEXT,
									shipState	TEXT NOT NULL,
									shipCode	 TEXT,
									shipPinCode	TEXT,
									shipGstIn	TEXT,
									sgstPercent	INTEGER NOT NULL,
									cgstPercent	INTEGER NOT NULL,
									igstPercent	INTEGER NOT NULL,
									totalQnty	DECIMAL(6,2),
									totalAmount	DECIMAL(8,2),
									totaDiscount	DECIMAL(8,2),
                                    totalTaxColAmt  DECIMAL(8,2), 
									totalTaxAmount	DECIMAL(8,2),
									totalSGSTAmount	DECIMAL(8,2),
									totaCGSTAmount	DECIMAL(8,2),
									totalIGSTAmount	DECIMAL(8,2),
									totalBillAmount	DECIMAL(8,2),
									receivedAmount	DECIMAL(8,2),
									IsActive	BIT(1) DEFAULT 1,
                                    financialYear	TEXT NOT NULL,
									FOREIGN KEY (userId) REFERENCES userDetails (userId)
									ON DELETE NO ACTION
									ON UPDATE NO ACTION,
									FOREIGN KEY(custId) REFERENCES customerDetails ( custId ) 
									ON DELETE NO ACTION 
									ON UPDATE NO ACTION
								)");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [invoiceProductDetails] (
									productId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									invoiceId	INTEGER NOT NULL,
									productName	TEXT NOT NULL,
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
									chargeName	TEXT NOT NULL,
									chargeAmount	DECIMAL(8,2) NOT NULL,                                    
									FOREIGN KEY(invoiceId) REFERENCES invoiceDetails ( invoiceId ) 
									ON DELETE NO ACTION 
									ON UPDATE NO ACTION
                                )");

			CreateTableList.Add(@"CREATE TABLE IF NOT EXISTS [invoiceChallanDetails] (
									challanId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
									invoiceId	INTEGER NOT NULL,
									challanNo	TEXT NOT NULL,	                                 
									FOREIGN KEY(invoiceId) REFERENCES invoiceDetails ( invoiceId ) 
									ON DELETE NO ACTION 
									ON UPDATE NO ACTION
								)");


			string strQuery = "INSERT INTO paymentTerms(termName) VALUES ";
			InsertDetails.Add("DELETE FROM paymentTerms");
			InsertDetails.Add(strQuery + "('Immediately')");
			InsertDetails.Add(strQuery + "('Within 15 days')");
			InsertDetails.Add(strQuery + "('Within 30 days')");
			InsertDetails.Add(strQuery + "('Within 45 days')");
			InsertDetails.Add(strQuery + "('Within 60 days')");
			InsertDetails.Add(strQuery + "('Others')");

			strQuery = "";
			strQuery = "INSERT INTO loginDetails(username, password) VALUES ";
			InsertDetails.Add("DELETE FROM loginDetails");
			InsertDetails.Add(strQuery + "('admin', 'admin')");
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
									QueryLogger("-CreateDatabase->" + strQuery);
									com.CommandText = strQuery;
									com.ExecuteNonQuery();
								}

								foreach (string strQuery in InsertDetails)
								{
									QueryLogger("-InsertDetails->" + strQuery);
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
				InsertDetails.Clear();
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Something went wrong :" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return dt;
		}
	}
}
