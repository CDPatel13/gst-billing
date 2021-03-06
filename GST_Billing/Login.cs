﻿using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GST_Billing
{
	public partial class Login : Form
	{
		SqliteDb m1 = new SqliteDb();
		public Login()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				string sqlstr = "SELECT * FROM loginDetails WHERE username = '" + tbUserName.Text + "' ";
				DataSet ds = m1.selectData(sqlstr);
				if (ds.Tables[0].Rows.Count > 0)
				{
					string username = Convert.ToString(ds.Tables[0].Rows[0]["username"]);
					string password = Convert.ToString(ds.Tables[0].Rows[0]["password"]);

					if (tbUserName.Text != username || tbPassword.Text != password)
					{
						MessageBox.Show("Please enter valid credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						this.Hide();
                        SelectFirm companySelect = new SelectFirm();
                        companySelect.Show(this);
                  	}
				}
				else
				{
					MessageBox.Show("Please enter valid credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception e1)
			{
				MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_Load(object sender, EventArgs e)
		{
            label1.Text = "v. " + Application.ProductVersion;

			CompanyDetails newCompany = new CompanyDetails();
			//TODO : Get company information from DB
			if (!newCompany.CompanyExists)
			{
				DialogResult result = MessageBox.Show("Please enter company details...", "Company Details Setup", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                newCompany.ShowDialog();
            }
			this.ActiveControl = tbUserName;
		}
	}
}
