using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GaneshLogistics.AppCode;

namespace GST_Billing
{
    public partial class MainWindow : Form
    {
        SqliteDb m1 = new SqliteDb();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO : fill datagrids with data from DB
            fillCustomerDataGrid();
            fillProductDataGrid();

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

        private void fillCustomerDataGrid()
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM customerDetails";
            DataSet ds = m1.selectData(sqlstr);
            DataTable table = ds.Tables[0];

            //table.Columns["custId"].ColumnName = "Customer ID";
            table.Columns["custname"].ColumnName = "Customer Name";
            table.Columns["custContactPerson"].ColumnName = "Contact Person";
            table.Columns["custaddress"].ColumnName = "Customer Address";
            table.Columns["custcity"].ColumnName = "Customer City";
            table.Columns["custlandmark"].ColumnName = "Customer Landmark";
            table.Columns["custstate"].ColumnName = "Customer State";
            table.Columns["custcode"].ColumnName = "Code";
            table.Columns["custpincode"].ColumnName = "Customer PIN Code";
            table.Columns["custemail"].ColumnName = "Customer Email";
            table.Columns["custphoneNumber"].ColumnName = "Customer Phone No";
            table.Columns["custgstin"].ColumnName = "Customer GSTIN";
            table.Columns["custAadharNo"].ColumnName = "Customer Aadhar No";
            table.Columns["custPanno"].ColumnName = "Customer PAN No";
            table.Columns["custpaymentTermName"].ColumnName = "Customer Payment Terms";

            //table.Columns["Customer ID"].SetOrdinal(0);
            table.Columns["Customer Name"].SetOrdinal(colIndex++);
            table.Columns["Customer Address"].SetOrdinal(colIndex++);
            table.Columns["Customer Landmark"].SetOrdinal(colIndex++);
            table.Columns["Customer City"].SetOrdinal(colIndex++);
            table.Columns["Customer State"].SetOrdinal(colIndex++);
            table.Columns["Code"].SetOrdinal(colIndex++);
            table.Columns["Customer PIN Code"].SetOrdinal(colIndex++);
            table.Columns["Customer GSTIN"].SetOrdinal(colIndex++);
            table.Columns["Customer Phone No"].SetOrdinal(colIndex++);
            table.Columns["Customer Email"].SetOrdinal(colIndex++);
            table.Columns["Customer Aadhar No"].SetOrdinal(colIndex++);
            table.Columns["Customer PAN No"].SetOrdinal(colIndex++);
            table.Columns["Contact Person"].SetOrdinal(colIndex++);
            table.Columns["Customer Payment Terms"].SetOrdinal(colIndex++);

            table.Columns.Remove("custId");
            table.Columns.Remove("shipname");
            table.Columns.Remove("shipaddress");
            table.Columns.Remove("shipContactPerson");
            table.Columns.Remove("shipcity");
            table.Columns.Remove("shiplandmark");
            table.Columns.Remove("shipstate");
            table.Columns.Remove("shipcode");
            table.Columns.Remove("shippincode");
            table.Columns.Remove("shipemail");
            table.Columns.Remove("shipphoneNumber");
            table.Columns.Remove("shipgstin");
            table.Columns.Remove("shipAadharNo");
            table.Columns.Remove("shipPanno");
            table.Columns.Remove("shippaymentTermName");

            dgvCustomer.DataSource = table;
        }

        private void fillProductDataGrid()
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM productDetails";
            DataSet ds = m1.selectData(sqlstr);
            DataTable table = ds.Tables[0];

            table.Columns["productId"].ColumnName = "Product ID";
            table.Columns["productName"].ColumnName = "Product Name";
            table.Columns["productPrice"].ColumnName = "Product Price";
            table.Columns["hsnCode"].ColumnName = "HSN Code";
            table.Columns["productUnit"].ColumnName = "Product Unit";

            table.Columns["Product ID"].SetOrdinal(colIndex++);
            table.Columns["Product Name"].SetOrdinal(colIndex++);
            table.Columns["HSN Code"].SetOrdinal(colIndex++);
            table.Columns["Product Price"].SetOrdinal(colIndex++);
            table.Columns["Product Unit"].SetOrdinal(colIndex++);

            dgvProducts.DataSource = table;
        }
    }
}
