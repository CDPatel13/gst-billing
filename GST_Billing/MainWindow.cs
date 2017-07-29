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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO : fill datagrids with data from DB

            // UI : Select first row
            if (dgvInvoice.RowCount > 0)
                dgvInvoice.Rows[0].Selected = true;
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
            
            DialogResult result = MessageBox.Show("Do you really want to delete this invoice?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            // TODO : Delete selected invoice from database
            if(result == DialogResult.Yes)
                dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            // TODO : print selected invoice
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            // TODO : Add info into invoice for payment
            // TODO : refresh data grid with updated values
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.ShowDialog();
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            // TODO : edit customer details
            string custName = String.Empty;
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomer.SelectedRows[0];
                custName = (string)row.Cells["colCustName"].Value;
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            // TODO : delete customer details from DB
            DialogResult result = MessageBox.Show("Do you really want to delete this customer?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // TODO : Delete selected invoice from database
            if (result == DialogResult.Yes)
                dgvCustomer.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
        }

        private void btnPrintCust_Click(object sender, EventArgs e)
        {
            // TODO : Print customer details
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDetails products = new ProductDetails();
            products.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            // TODO : edit product details
            string prodId = String.Empty;
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                prodId = (string)row.Cells["colProdId"].Value;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // TODO : delete product details
            // TODO : delete customer details from DB
            DialogResult result = MessageBox.Show("Do you really want to delete this product?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // TODO : Delete selected invoice from database
            if (result == DialogResult.Yes)
                dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            // TODO : Print product details
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            tbSearchInvoice.Clear();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            tbSearchCust.Clear();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            tbSearchProducts.Clear();
        }
    }
}
