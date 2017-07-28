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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            Invoice generateInvoice = new Invoice();
            DialogResult result = generateInvoice.ShowDialog();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            int invoiceToEdit = 0;
            string custName = String.Empty;
            if(dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];
                invoiceToEdit = Int32.Parse((string)row.Cells["colInvoiceNum"].Value);
                custName = (string)row.Cells["colCust"].Value;
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Do you really want to delete this invoice?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            // TODO : Delete selected invoice from database

            dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            // TODO : print selected invoice
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO : fill datagrid with data from DB

            // UI : Select first row
            if (dgvInvoice.RowCount > 0)
                dgvInvoice.Rows[0].Selected = true;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
