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
    public partial class SelectInvoicePrint : Form
    {
        public SelectInvoicePrint()
        {
            InitializeComponent();
        }

        public int invoicePrintType = 0;

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(!rbOriginal.Checked && !rbDuplicate.Checked)
            {
                MessageBox.Show("Please select at least one option.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rbOriginal.Checked)
            {
                this.invoicePrintType = 1;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else if(rbDuplicate.Checked)
            {
                this.invoicePrintType = 2;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
