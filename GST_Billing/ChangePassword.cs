using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class ChangePassword : Form
    {
        SqliteDb m1 = new SqliteDb();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    string sqlstr = "SELECT * FROM loginDetails WHERE username = '" + tbOldUserName.Text + "' AND password = '" + tbOldPassword.Text + "' ";
                    DataSet ds = m1.selectData(sqlstr);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        sqlstr = "UPDATE loginDetails set username='" + tbNewUserName.Text + "',password='" + tbNewPassword.Text + "' WHERE loginId = " + Convert.ToInt32(ds.Tables[0].Rows[0]["loginId"]) + " ";
                        int NoOfRows = m1.Ins_Upd_Del(sqlstr);
                        if (NoOfRows > 0)
                        {
                            MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateInputs()
        {
            bool username = !String.IsNullOrWhiteSpace(tbOldUserName.Text);
            bool oldpassword = !String.IsNullOrWhiteSpace(tbOldPassword.Text);
            bool newPassword = !String.IsNullOrWhiteSpace(tbNewPassword.Text);
            bool confirmPassword = !String.IsNullOrWhiteSpace(tbConfirmPassword.Text);

            if (username && oldpassword && newPassword && confirmPassword)
            {
                if (tbNewPassword.Text == tbConfirmPassword.Text)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Password does not match with confirm password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            string sqlstr = "SELECT username FROM loginDetails";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                tbOldUserName.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }
    }
}
