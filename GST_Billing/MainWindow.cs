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
        BindingSource bindingSourceInvoice = new BindingSource();
        BindingSource bindingSourceCustomer = new BindingSource();
        BindingSource bindingSourceProducts = new BindingSource();

        DataTable tableCustomer;
        DataTable tableInvoice;
        DataTable tableProduct;

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
            string sqlstr = "DELETE FROM productDetails WHERE invoiceNo='" + (int)dgvInvoice.SelectedRows[0].Cells[0].Value + "'";
            DialogResult result = MessageBox.Show("Do you really want to delete this invoice?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            // TODO : Delete selected invoice from database
            if (result == DialogResult.Yes)
            {
                int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
            }
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

            fillCustomerDataGrid();
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            string custName = String.Empty;
            DataGridViewRow row = dgvCustomer.SelectedRows[0];
            custName = (string)row.Cells["Customer Name"].Value;

            CustomerDetails editCustomer = new CustomerDetails(custName);
            editCustomer.ShowDialog();

            fillCustomerDataGrid();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            string sqlstr = "DELETE FROM customerDetails WHERE custname='"+(string)dgvCustomer.SelectedRows[0].Cells[0].Value+"'";
            DialogResult result = MessageBox.Show("Do you really want to delete this customer?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                dgvCustomer.Rows.RemoveAt(dgvCustomer.SelectedRows[0].Index);
            }
        }

        private void btnPrintCust_Click(object sender, EventArgs e)
        {
            // TODO : Print customer details
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDetails products = new ProductDetails();
            products.ShowDialog();

            fillProductDataGrid();
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
            string sqlstr = "DELETE FROM productDetails WHERE productId='" + (Int64)dgvProducts.SelectedRows[0].Cells[0].Value + "'";
            
            DialogResult result = MessageBox.Show("Do you really want to delete this product?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                dgvProducts.Rows.RemoveAt(dgvProducts.SelectedRows[0].Index);
            }
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
            string customer = tbSearchCust.Text;
            if(!String.IsNullOrEmpty(customer))
            {
                string sqlstr = "SELECT * FROM customerDetails WHERE custname like '%" + customer + "%'";
                DataSet ds = m1.selectData(sqlstr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    fillCustomerDataGrid(ds);
                }
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            tbSearchCust.Clear();
            fillCustomerDataGrid();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            tbSearchProducts.Clear();
        }

        private void fillCustomerDataGrid(DataSet table = null)
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM customerDetails";

            if(table == null)
            {
                DataSet ds = m1.selectData(sqlstr);
                tableCustomer = ds.Tables[0];
            }
            else
            {
                tableCustomer = table.Tables[0];
            }

            //table.Columns["custId"].ColumnName = "Customer ID";
            tableCustomer.Columns["custname"].ColumnName = "Customer Name";
            tableCustomer.Columns["custContactPerson"].ColumnName = "Contact Person";
            tableCustomer.Columns["custaddress"].ColumnName = "Customer Address";
            tableCustomer.Columns["custcity"].ColumnName = "Customer City";
            tableCustomer.Columns["custlandmark"].ColumnName = "Customer Landmark";
            tableCustomer.Columns["custstate"].ColumnName = "Customer State";
            tableCustomer.Columns["custcode"].ColumnName = "Code";
            tableCustomer.Columns["custpincode"].ColumnName = "Customer PIN Code";
            tableCustomer.Columns["custemail"].ColumnName = "Customer Email";
            tableCustomer.Columns["custphoneNumber"].ColumnName = "Customer Phone No";
            tableCustomer.Columns["custgstin"].ColumnName = "Customer GSTIN";
            tableCustomer.Columns["custAadharNo"].ColumnName = "Customer Aadhar No";
            tableCustomer.Columns["custPanno"].ColumnName = "Customer PAN No";
            tableCustomer.Columns["custpaymentTermName"].ColumnName = "Customer Payment Terms";

            //table.Columns["Customer ID"].SetOrdinal(0);
            tableCustomer.Columns["Customer Name"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Address"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Landmark"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer City"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer State"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Code"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer PIN Code"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer GSTIN"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Phone No"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Email"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Aadhar No"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer PAN No"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Contact Person"].SetOrdinal(colIndex++);
            tableCustomer.Columns["Customer Payment Terms"].SetOrdinal(colIndex++);

            tableCustomer.Columns.Remove("custId");
            tableCustomer.Columns.Remove("shipname");
            tableCustomer.Columns.Remove("shipaddress");
            tableCustomer.Columns.Remove("shipContactPerson");
            tableCustomer.Columns.Remove("shipcity");
            tableCustomer.Columns.Remove("shiplandmark");
            tableCustomer.Columns.Remove("shipstate");
            tableCustomer.Columns.Remove("shipcode");
            tableCustomer.Columns.Remove("shippincode");
            tableCustomer.Columns.Remove("shipemail");
            tableCustomer.Columns.Remove("shipphoneNumber");
            tableCustomer.Columns.Remove("shipgstin");
            tableCustomer.Columns.Remove("shipAadharNo");
            tableCustomer.Columns.Remove("shipPanno");
            tableCustomer.Columns.Remove("shippaymentTermName");

            bindingSourceCustomer.DataSource = null;
            bindingSourceCustomer.DataSource = tableCustomer;
            dgvCustomer.DataSource = bindingSourceCustomer;
        }

        private void fillProductDataGrid()
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM productDetails";
            DataSet ds = m1.selectData(sqlstr);
            tableProduct = ds.Tables[0];

            tableProduct.Columns["productId"].ColumnName = "Product ID";
            tableProduct.Columns["productName"].ColumnName = "Product Name";
            tableProduct.Columns["productPrice"].ColumnName = "Product Price";
            tableProduct.Columns["hsnCode"].ColumnName = "HSN Code";
            tableProduct.Columns["productUnit"].ColumnName = "Product Unit";

            tableProduct.Columns["Product ID"].SetOrdinal(colIndex++);
            tableProduct.Columns["Product Name"].SetOrdinal(colIndex++);
            tableProduct.Columns["HSN Code"].SetOrdinal(colIndex++);
            tableProduct.Columns["Product Price"].SetOrdinal(colIndex++);
            tableProduct.Columns["Product Unit"].SetOrdinal(colIndex++);

            bindingSourceProducts.DataSource = null;
            bindingSourceProducts.DataSource = tableProduct;
            dgvProducts.DataSource = bindingSourceProducts;
        }
    }
}
