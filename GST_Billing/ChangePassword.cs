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
                    string sqlstr = "SELECT * FROM loginDetails WHERE username = '" + tbUserName.Text + "' AND password = '" + textBox1.Text + "' ";
                    DataSet ds = m1.selectData(sqlstr);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        sqlstr = "UPDATE loginDetails set password='" + textBox2.Text + "' WHERE loginId = " + Convert.ToInt32(ds.Tables[0].Rows[0]["loginId"]) + " ";
                        int NoOfRows = m1.Ins_Upd_Del(sqlstr);
                        if (NoOfRows > 0)
                        {
                            MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK);
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
                MessageBox.Show("Error :" + e1.Message);
            }

        }

        private bool ValidateInputs()
        {
            bool username = !String.IsNullOrEmpty(tbUserName.Text) && !String.IsNullOrWhiteSpace(tbUserName.Text);
            bool oldpassword = !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text);
            bool newPassword = !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrWhiteSpace(textBox2.Text);
            bool confirmPassword = !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrWhiteSpace(textBox3.Text);

            if (username && oldpassword && newPassword && confirmPassword)
            {
                if (textBox2.Text == textBox3.Text)
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
            // TODO : Get current user name
        }
    }
}
