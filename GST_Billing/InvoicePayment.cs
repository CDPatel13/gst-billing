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
    public partial class InvoicePayment : Form
    {
        private string invoiceToEdit;
        private string custName;
        private double amount;
        private double pending;
        private double paymentDone;

        public double PaymentDone
        {
            get
            {
                return paymentDone;
            }
            set
            {
                paymentDone = value;
            }
        }


        public InvoicePayment()
        {
            InitializeComponent();
        }

        public InvoicePayment(string invoiceToEdit, string custName, double amount, double pending)
        {
            // TODO: Complete member initialization
            this.invoiceToEdit = invoiceToEdit;
            this.custName = custName;
            this.amount = amount;
            this.pending = pending;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPayment.Text))
                this.PaymentDone = double.Parse(tbPayment.Text);
            else
                this.PaymentDone = 0;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void InvoicePayment_Load(object sender, EventArgs e)
        {
            tbInvoice.Text = this.invoiceToEdit.ToString();
            tbCustomer.Text = this.custName;
            tbBillAmount.Text = this.amount.ToString();
            tbPending.Text = this.pending.ToString();
        }

        private void tbPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            string paymentAmount = tbPayment.Text;
            if(paymentAmount.IndexOf('-') > 0)
            {
                errorProvider1.SetError(tbPayment, "Sign (-) can only be used at start of string.");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbPayment, String.Empty);
                btnSave.Enabled = true;
            }
        }
    }
}