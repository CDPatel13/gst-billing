using System;
using System.Data;
using System.Configuration;
//using System.Web;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for MyClass
/// </summary>
public class MyClass
{
    //MySqlConnection connection;
    //MySqlCommand cmd;
    //MySqlDataReader dr;
    string connectionString;
    string server;
    string database;
    string uid;
    string password;

    string sqlstr;
    DataTable dt;
    //MySqlDataAdapter da;
    string constr;

    public MyClass()
    {
        Initialize();
    }

    private void Initialize()
    {
        server = "localhost";
        database = "ganeshlogistics";
        uid = "root";
        password = "root";
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Allow User Variables=True";

        //connection = new MySqlConnection(connectionString);
    }

   /* private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    public DataSet selectData(string sqlstr)
    {
        QueryLogger("-selectData->" + sqlstr);

        try
        {
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sqlstr, connection);
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds);
                return ds;
            }            
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message);
        }
        finally 
        {
            this.CloseConnection();
        }
        return null;
    }

    public MySqlDataReader selectDataReader(string sqlstr)
    {
        QueryLogger("-selectDataReader->" + sqlstr);

        try
        {
            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand(sqlstr, connection);
                dr = cmd.ExecuteReader();                
                return dr;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message);
        }
        finally
        {
            this.CloseConnection();
            dr.Close();
        }
        return null;
    }

    public int Ins_Upd_Del(string sqlstr)
    {
        QueryLogger("-Ins_Upd_Del->" + sqlstr);

        try
        {
            int numberOfRows = 0;
            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand(sqlstr, connection);
                numberOfRows = cmd.ExecuteNonQuery();
                return numberOfRows;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message); ;
        }
        finally
        {
            this.CloseConnection();
        }
        return 0;
    }

    public string scaler(string sqlstr)
    {
        QueryLogger("-scaler->" + sqlstr);

        try
        {
            string s1;
            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand(sqlstr, connection);
                s1 = Convert.ToString(cmd.ExecuteScalar());
                return s1;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return null;
    }   

    public DataTable selectDataTable(string sqlstr)
    {
        QueryLogger("-selectDataTable->" + sqlstr);

        try
        {
            da = new MySqlDataAdapter(sqlstr, connectionString);
            MySqlCommandBuilder commandbuilder = new MySqlCommandBuilder(da);
            dt = new DataTable();

            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message);
        }
        return dt;
    }

    public void QueryLogger(string strSql)
    {
        StreamWriter sr = null;
        try
        {
            if (!File.Exists("sqllog.log"))
                File.Create("sqllog.log");
            sr = new StreamWriter("sqllog.log", true);
            sr.WriteLine(System.DateTime.Now.ToString() + sqlstr + ";");            
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Something went wrong :" + ex.Message);
        }
        finally
        {
            sr.Close();
        }
    }*/
}
