using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            CompanyDetails companyDetails = new CompanyDetails();
            companyDetails.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice generateInvoice = new Invoice();
            generateInvoice.Show();
            this.Hide();
        }

        void Home_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustDetails_Click(object sender, EventArgs e)
        {
            CustomerDetails custDetails = new CustomerDetails();
            custDetails.Show();
            this.Hide();
        }
    }
}
