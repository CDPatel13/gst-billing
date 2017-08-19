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
        string oldPassword = String.Empty;
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
            bool username = !String.IsNullOrWhiteSpace(tbNewUserName.Text);
            bool oldpassword = !String.IsNullOrWhiteSpace(tbOldPassword.Text);
            bool newPassword = !String.IsNullOrWhiteSpace(tbNewPassword.Text);
            bool confirmPassword = !String.IsNullOrWhiteSpace(tbConfirmPassword.Text);

            bool result = true;

            if(!username)
            {
                errorProvider1.SetError(tbNewUserName, "Please enter new username.");
                result = false;
            }

            if(tbOldPassword.Text != oldPassword)
            {
                errorProvider1.SetError(tbOldPassword, "Please enter correct current password.");
                result = false;
            }
            if(!newPassword)
            {
                errorProvider1.SetError(tbNewPassword, "Password can not be empty.");
                result = false;
            }
            if (!newPassword)
            {
                errorProvider1.SetError(tbConfirmPassword, "Password can not be empty.");
                result = false;
            }
            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Passwords do not match.");
                errorProvider1.SetError(tbNewPassword, "Passwords do not match.");
                result = false;
            }
            return result;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            string sqlstr = "SELECT username,password FROM loginDetails";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
            {
                tbOldUserName.Text = ds.Tables[0].Rows[0][0].ToString();
                tbNewUserName.Text = tbOldUserName.Text;
                oldPassword = ds.Tables[0].Rows[0][1].ToString();
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            bool username = !String.IsNullOrWhiteSpace(tbNewUserName.Text);
            bool oldpassword = !String.IsNullOrWhiteSpace(tbOldPassword.Text);
            bool newPassword = !String.IsNullOrWhiteSpace(tbNewPassword.Text);
            bool confirmPassword = !String.IsNullOrWhiteSpace(tbConfirmPassword.Text);

            if (username)
            {
                errorProvider1.SetError(tbNewUserName, String.Empty);
            }
            if(oldpassword)
            {
                errorProvider1.SetError(tbOldPassword, String.Empty);
            }
            if(newPassword)
            {
                errorProvider1.SetError(tbNewPassword, String.Empty);
            }
            if(confirmPassword)
            {
                errorProvider1.SetError(tbConfirmPassword, String.Empty);
            }
        }
    }
}
