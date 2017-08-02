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
        private int invoiceToEdit;
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

        public InvoicePayment(int invoiceToEdit, string custName, double amount, double pending)
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}