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

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(!rbOriginal.Checked && !rbDuplicate.Checked)
            {
                MessageBox.Show("Please select at least one option.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rbOriginal.Checked)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else if(rbDuplicate.Checked)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
            else
            {
                return;
            }
        }
    }
}
