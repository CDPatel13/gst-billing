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

        List<string> listOfProducts = new List<string>();
        List<string> listOfCustomers = new List<string>();
        AutoCompleteStringCollection autoCompleteStrings = new AutoCompleteStringCollection();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region MainWindow

        private void MainWindow_Load(object sender, EventArgs e)
        {
            fillCustomerDataGrid();
            fillProductDataGrid();
            fillInvoiceDataGrid();

            fillAutoCompleteCustomers();

            if (dgvInvoice.RowCount > 0)
                dgvInvoice.Rows[0].Selected = true;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabMain.SelectedTab;

            switch (selectedTab.Name)
            {
                case "tabProducts":
                    fillAutoCompleteProducts();
                    break;
                case "tabInvoice":
                case "tabCustomer":
                    fillAutoCompleteCustomers();
                    break;
                default:
                    autoCompleteStrings.Clear();
                    break;
            }
        }

        private void tsmiCompanyInfo_Click(object sender, EventArgs e)
        {
            CompanyDetails companyInfo = new CompanyDetails();
            companyInfo.ShowDialog();
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            password.ShowDialog();
        }

        #endregion

        #region Customer

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
            if(row!= null)
            { 
                custName = (string)row.Cells["Customer Name"].Value;

                CustomerDetails editCustomer = new CustomerDetails(custName);
                editCustomer.ShowDialog();

                fillCustomerDataGrid();
            }
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

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            string customer = tbSearchCust.Text;
            if (!String.IsNullOrEmpty(customer) && !String.IsNullOrWhiteSpace(customer))
            {
                tableCustomer.DefaultView.RowFilter = "[Customer Name] LIKE '%" + customer + "%'";
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            tbSearchCust.Clear();
            tableCustomer.DefaultView.RowFilter = String.Empty;
        }

        private void fillCustomerDataGrid(DataSet table = null)
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM customerDetails";

            if (table == null)
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

        private void fillAutoCompleteCustomers()
        {
            string sqlstr = "SELECT custname from customerDetails";
            DataSet ds = m1.selectData(sqlstr);

            autoCompleteStrings.Clear();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    autoCompleteStrings.Add((string)row["custname"]);
                }
                tbSearchCust.AutoCompleteCustomSource = autoCompleteStrings;
                tbSearchInvoice.AutoCompleteCustomSource = autoCompleteStrings;
            }
        }
        
        #endregion

        #region Products

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDetails products = new ProductDetails();
            products.ShowDialog();

            fillProductDataGrid();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            string prodname = String.Empty;
            DataGridViewRow row = dgvProducts.SelectedRows[0];
            if (row != null)
            {
                prodname = (string)row.Cells["Product Name"].Value;

                ProductDetails editProduct = new ProductDetails(prodname);
                editProduct.ShowDialog();

                fillProductDataGrid();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count > 0)
            { 
                string sqlstr = "DELETE FROM productDetails WHERE productName='" + (string)dgvProducts.SelectedRows[0].Cells[0].Value + "'";
            
                DialogResult result = MessageBox.Show("Do you really want to delete this product?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                    dgvProducts.Rows.RemoveAt(dgvProducts.SelectedRows[0].Index);
                }
            }
        }

        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            // TODO : Print product details
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            string product = tbSearchProducts.Text;
            if (!String.IsNullOrEmpty(product) && !String.IsNullOrWhiteSpace(product))
            {
                tableProduct.DefaultView.RowFilter = "[Product Name] LIKE '%" + product + "%'";
            }
        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            tbSearchProducts.Clear();
            tableProduct.DefaultView.RowFilter = String.Empty;
        }

        private void fillProductDataGrid(DataSet table = null)
        {
            int colIndex = 0;
            string sqlstr = "SELECT * FROM productDetails";

            if (table == null)
            {
                DataSet ds = m1.selectData(sqlstr);
                tableProduct = ds.Tables[0];
            }
            else
            {
                tableProduct = table.Tables[0];
            }

            tableProduct.Columns["productName"].ColumnName = "Product Name";
            tableProduct.Columns["productPrice"].ColumnName = "Product Price";
            tableProduct.Columns["hsnCode"].ColumnName = "HSN Code";
            tableProduct.Columns["productUnit"].ColumnName = "Product Unit";

            tableProduct.Columns["Product Name"].SetOrdinal(colIndex++);
            tableProduct.Columns["HSN Code"].SetOrdinal(colIndex++);
            tableProduct.Columns["Product Price"].SetOrdinal(colIndex++);
            tableProduct.Columns["Product Unit"].SetOrdinal(colIndex++);

            tableProduct.Columns.Remove("productId");

            bindingSourceProducts.DataSource = null;
            bindingSourceProducts.DataSource = tableProduct;
            dgvProducts.DataSource = bindingSourceProducts;
        }

        private void fillAutoCompleteProducts()
        {
            string sqlstr = "SELECT productName from productDetails";
            DataSet ds = m1.selectData(sqlstr);

            autoCompleteStrings.Clear();
            if(ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    autoCompleteStrings.Add((string)row["productName"]);
                }
                tbSearchProducts.AutoCompleteCustomSource = autoCompleteStrings;
            }
        }

        #endregion

        #region Invoice

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            Invoice generateInvoice = new Invoice();
            DialogResult result = generateInvoice.ShowDialog();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            int invoiceToEdit = 0;
            string custName = String.Empty;
            DataGridViewRow row = dgvInvoice.SelectedRows[0];

            if (row != null)
            {
                invoiceToEdit = Int32.Parse((string)row.Cells["Invoice No"].Value);

                Invoice editInvoice = new Invoice(invoiceToEdit);
                editInvoice.ShowDialog();

                fillInvoiceDataGrid();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string sqlstr = "DELETE FROM invoiceDetails WHERE invoiceNo='" + Convert.ToInt64(dgvInvoice.SelectedRows[0].Cells["Invoice No"].Value) + "'";
            DialogResult result = MessageBox.Show("Do you really want to delete this invoice?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // TODO : Delete selected invoice from database
            if (result == DialogResult.Yes)
            {
                int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                if(no_of_rows > 0)
                    dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvInvoice.SelectedRows[0];
            if (row != null)
            {
                PrintInvoice objPrintInvoice = new PrintInvoice((string)row.Cells["Invoice No"].Value);
                objPrintInvoice.MdiParent = this.MdiParent;
                objPrintInvoice.Show();
            }
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            string conditionName = " AND [Customer Name] LIKE '%" + tbSearchInvoice.Text + "%'";
            string conditionDate = "[Invoice Date] > #" + dtpStartDate.Value + "# AND [Invoice Date] < #" + dtpEndDate.Value + "#";
            if(!String.IsNullOrEmpty(tbSearchInvoice.Text) && !String.IsNullOrWhiteSpace(tbSearchInvoice.Text))
            {
                tableInvoice.DefaultView.RowFilter = conditionDate + conditionName;
            }
            else
            {
                tableInvoice.DefaultView.RowFilter = conditionDate;
            }
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            tbSearchInvoice.Clear();
            tableInvoice.DefaultView.RowFilter = String.Empty;
            //fillInvoiceDataGrid();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int invoiceToEdit = 0;
            string custName = String.Empty;
            double paymentDone = 0;
            DataGridViewRow row = dgvInvoice.SelectedRows[0];

            if (row != null)
            {
                invoiceToEdit = Int32.Parse((string)row.Cells["Invoice No"].Value);
                custName = (string)row.Cells["Customer Name"].Value;
                double amount = double.Parse(row.Cells["Total Bill Amount"].Value.ToString());
                double received = double.Parse(row.Cells["Received Amount Till Date"].Value.ToString());
                double pending = amount - received;

                Invoice editInvoice = new Invoice(invoiceToEdit);

                InvoicePayment payment = new InvoicePayment(invoiceToEdit, custName, amount, pending);
                payment.ShowDialog();
                paymentDone = payment.PaymentDone;
                
                if(!editInvoice.UpdatePayment(paymentDone))
                {
                    MessageBox.Show("Failed to update payment. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                fillInvoiceDataGrid();
            }

        }

        private void fillInvoiceDataGrid()
        {
            int colIndex = 0;
            string sqlstrInvoice = "SELECT custname,invoiceNo,invoiceDate,termName,invoiceDetails.shipName," +
                                   "invoiceDetails.shipAddress,invoiceDetails.shipLandmark,invoiceDetails.shipCity," + 
                                   "invoiceDetails.shipState,invoiceDetails.shipPinCode,invoiceDetails.shipGstIn," +
                                   "sgstPercent,cgstPercent,igstPercent,totalQnty,totalAmount,totaDiscount," +
                                   "totalTaxAmount,totalSGSTAmount,totaCGSTAmount,totalIGSTAmount,totalBillAmount," + 
                                   "receivedAmount" +
                                   " FROM invoiceDetails" + 
                                   " INNER JOIN customerDetails ON customerDetails.custId = invoiceDetails.custId";

            DataSet ds = m1.selectData(sqlstrInvoice);
            tableInvoice = ds.Tables[0];

            tableInvoice.Columns.Add("Invoice Date", typeof(DateTime));
            
            tableInvoice.Columns["custname"].ColumnName = "Customer Name";
            tableInvoice.Columns["invoiceNo"].ColumnName = "Invoice No";
            tableInvoice.Columns["totalQnty"].ColumnName = "Total Quantity";
            tableInvoice.Columns["totalAmount"].ColumnName = "Amount";
            tableInvoice.Columns["totaDiscount"].ColumnName = "Discount";
            tableInvoice.Columns["totalTaxAmount"].ColumnName = "Taxable Amount";
            tableInvoice.Columns["totalSGSTAmount"].ColumnName = "Total SGST Amount";
            tableInvoice.Columns["totaCGSTAmount"].ColumnName = "Total CGST Amount";
            tableInvoice.Columns["totalIGSTAmount"].ColumnName = "Total IGST Amount";
            tableInvoice.Columns["totalBillAmount"].ColumnName = "Total Bill Amount";
            tableInvoice.Columns["termName"].ColumnName = "Payment Terms";
            tableInvoice.Columns["receivedAmount"].ColumnName = "Received Amount Till Date";

            tableInvoice.Columns["Customer Name"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Invoice No"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Invoice Date"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Total Quantity"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Discount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Taxable Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Total SGST Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Total CGST Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Total IGST Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Total Bill Amount"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Payment Terms"].SetOrdinal(colIndex++);
            tableInvoice.Columns["Received Amount Till Date"].SetOrdinal(colIndex++);

            foreach(DataRow row in tableInvoice.Rows)
            {
                row["Invoice Date"] = DateTime.ParseExact(row["invoiceDate"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            tableInvoice.Columns.Remove("invoiceDate");
            tableInvoice.Columns.Remove("shipName");
            tableInvoice.Columns.Remove("shipAddress");
            tableInvoice.Columns.Remove("shipCity");
            tableInvoice.Columns.Remove("shipLandmark");
            tableInvoice.Columns.Remove("shipState");
            tableInvoice.Columns.Remove("shipPinCode");
            tableInvoice.Columns.Remove("shipGstIn");
            tableInvoice.Columns.Remove("sgstPercent");
            tableInvoice.Columns.Remove("cgstPercent");
            tableInvoice.Columns.Remove("igstPercent");

            bindingSourceInvoice.DataSource = null;
            bindingSourceInvoice.DataSource = tableInvoice;
            dgvInvoice.DataSource = bindingSourceInvoice;

            dgvInvoice.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            calculateTotalInvoiceAmount();
        }

        private void calculateTotalInvoiceAmount()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                total += row.Cells["Total Bill Amount"].Value != null ? Convert.ToDouble(row.Cells["Total Bill Amount"].Value) : 0.00;
            }
            lbAmountTotal.Text = total.ToString();

            double received = 0;
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                received += row.Cells["Received Amount Till Date"].Value != null ? Convert.ToDouble(row.Cells["Received Amount Till Date"].Value) : 0.00;
            }
            lbAmountPending.Text = (total - received).ToString();
        }

        #endregion
    }
}
