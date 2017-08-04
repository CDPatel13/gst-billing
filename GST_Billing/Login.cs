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
    public partial class Login : Form
    {
        bool companyExists = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text != "admin" && tbPassword.Text != "admin")
            {
                MessageBox.Show("Please enter valid credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                MainWindow window = new MainWindow();
                window.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CompanyDetails newCompany = new CompanyDetails();
            //TODO : Get company information from DB
            if (String.IsNullOrEmpty(newCompany.CompanyName))
            {
                DialogResult result = MessageBox.Show("Please enter company details...", "Company Details Setup", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if ((result == DialogResult.OK) && (newCompany.ShowDialog() == DialogResult.OK))
                {
                    companyExists = true;
                    this.lbCompanyName.Text = newCompany.CompanyName;
                    this.lbCompanyAddress.Text = newCompany.CompanyAddress;
                    this.lbCompanyEmail.Text = newCompany.CompanyEmail;
                    this.lbCompanyContact.Text = newCompany.CompanyContact;
                }
            }
            else
            {
                companyExists = true;
                this.lbCompanyName.Text = newCompany.CompanyName;
                this.lbCompanyAddress.Text = newCompany.CompanyAddress;
                this.lbCompanyEmail.Text = newCompany.CompanyEmail;
                this.lbCompanyContact.Text = newCompany.CompanyContact;
            }
            this.ActiveControl = tbUserName;
        }
    }
}
