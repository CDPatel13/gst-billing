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
                    fillProductDataGrid();
                    fillAutoCompleteProducts();
                    break;
                case "tabInvoice":
                    fillInvoiceDataGrid();
                    break;
                case "tabCustomer":
                    fillCustomerDataGrid();
                    fillAutoCompleteCustomers();
                    break;
                default:
                    autoCompleteStrings.Clear();
                    break;
            }
        }

        private void tsmiCompanyInfo_Click(object sender, EventArgs e)
        {
            //CompanyDetails companyInfo = new CompanyDetails();
            //companyInfo.ShowDialog();

            SelectFirm selection = new SelectFirm();
            selection.ShowDialog();
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
            if(dgvCustomer.SelectedRows.Count > 0)
            { 
                DataGridViewRow row = dgvCustomer.SelectedRows[0];
                custName = (string)row.Cells["Customer Name"].Value;

                CustomerDetails editCustomer = new CustomerDetails(custName);
                editCustomer.ShowDialog();

                fillCustomerDataGrid();
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomer.SelectedRows[0];

                string sqlstr = "DELETE FROM customerDetails WHERE custname='" + (string)dgvCustomer.SelectedRows[0].Cells[0].Value + "' AND userId='" + BaseModel.Instance.CompanyId + "'";
                string sqlStrCustId = "SELECT custId FROM customerDetails WHERE custname='" + (string)dgvCustomer.SelectedRows[0].Cells[0].Value + "' AND userId='" + BaseModel.Instance.CompanyId + "'";

                DataSet ds = m1.selectData(sqlStrCustId);
                if(ds!=null && ds.Tables[0].Rows.Count > 0)
                {
                    string custId = ds.Tables[0].Rows[0][0].ToString();
                    sqlStrCustId = "SELECT invoiceNo FROM invoiceDetails WHERE custId='" + custId + "' AND userId='" + BaseModel.Instance.CompanyId + "'";

                    DataSet ds1 = m1.selectData(sqlStrCustId);
                    if(ds1!=null && ds1.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Customer can not be deleted as invoice for this customer exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Do you really want to delete this customer?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                    dgvCustomer.Rows.RemoveAt(dgvCustomer.SelectedRows[0].Index);
                }
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
            string sqlstr = "SELECT * FROM customerDetails WHERE userId='" + BaseModel.Instance.CompanyId + "'";

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
            tableCustomer.Columns.Remove("userId");
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
            string sqlstr = "SELECT custname from customerDetails WHERE userId='" + BaseModel.Instance.CompanyId + "'";
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
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                prodname = (string)row.Cells["Item Name"].Value;

                ProductDetails editProduct = new ProductDetails(prodname);
                editProduct.ShowDialog();

                fillProductDataGrid();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count > 0)
            { 
                string sqlstr = "DELETE FROM productDetails WHERE productName='" + (string)dgvProducts.SelectedRows[0].Cells[0].Value + "' and userId= '" + BaseModel.Instance.CompanyId+ "' ";
            
                DialogResult result = MessageBox.Show("Do you really want to delete this item?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                tableProduct.DefaultView.RowFilter = "[Item Name] LIKE '%" + product + "%'";
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
            string sqlstr = "SELECT * FROM productDetails where userId= '" +BaseModel.Instance.CompanyId+ "'";

            if (table == null)
            {
                DataSet ds = m1.selectData(sqlstr);
                tableProduct = ds.Tables[0];
            }
            else
            {
                tableProduct = table.Tables[0];
            }

            tableProduct.Columns["productName"].ColumnName = "Item Name";
            tableProduct.Columns["productPrice"].ColumnName = "Price";
            tableProduct.Columns["hsnCode"].ColumnName = "HSN Code";
            tableProduct.Columns["productUnit"].ColumnName = "Unit";

            tableProduct.Columns["Item Name"].SetOrdinal(colIndex++);
            tableProduct.Columns["HSN Code"].SetOrdinal(colIndex++);
            tableProduct.Columns["Price"].SetOrdinal(colIndex++);
            tableProduct.Columns["Unit"].SetOrdinal(colIndex++);

            tableProduct.Columns.Remove("productId");
            tableProduct.Columns.Remove("userId");

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
            addNewInvoice();
        }

        private void addNewInvoice()
        {
            Invoice generateInvoice = new Invoice();
            DialogResult result = generateInvoice.ShowDialog();

            fillInvoiceDataGrid();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            editExistingInvoice();
        }

        private void editExistingInvoice()
        {
            int invoiceToEdit = 0;
            string custName = String.Empty;
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];

                invoiceToEdit = Int32.Parse((string)row.Cells["Invoice No"].Value);

                Invoice editInvoice = new Invoice(invoiceToEdit);
                editInvoice.ShowDialog();

                fillInvoiceDataGrid();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            deleteSelectedInvoice();
        }

        private void deleteSelectedInvoice()
        {
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];

                string sqlstr = "DELETE FROM invoiceDetails WHERE invoiceNo='" + Convert.ToInt64(dgvInvoice.SelectedRows[0].Cells["Invoice No"].Value) + "' AND userId='" +BaseModel.Instance.CompanyId+ "' AND financialYear='" +BaseModel.Instance.FinancialYear+ "'";
                DialogResult result = MessageBox.Show("Do you really want to delete this invoice?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // TODO : Delete selected invoice from database
                if (result == DialogResult.Yes)
                {
                    int no_of_rows = m1.Ins_Upd_Del(sqlstr);
                    if (no_of_rows > 0)
                        dgvInvoice.Rows.RemoveAt(dgvInvoice.SelectedRows[0].Index);
                }
            }
            calculateTotalInvoiceAmount();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            viewSelectedInvoice();
        }

        private void viewSelectedInvoice()
        {
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];
                PrintInvoice objPrintInvoice = new PrintInvoice((string)row.Cells["Invoice No"].Value, 1);
                objPrintInvoice.MdiParent = this.MdiParent;
                objPrintInvoice.Show();
            }
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            string conditionName = " AND [Customer Name] LIKE '%" + tbSearchInvoice.Text + "%'";
            string conditionDate = "[Invoice Date] > '" + dtpStartDate.Value +"' AND [Invoice Date] < '" + dtpStartDate.Value + "'";
            if(!String.IsNullOrEmpty(tbSearchInvoice.Text) && !String.IsNullOrWhiteSpace(tbSearchInvoice.Text))
            {
                tableInvoice.DefaultView.RowFilter = conditionDate + conditionName;
            }
            else
            {
                tableInvoice.DefaultView.RowFilter = conditionDate;
            }
            calculateTotalInvoiceAmount();
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            tbSearchInvoice.Clear();
            tableInvoice.DefaultView.RowFilter = String.Empty;

            calculateTotalInvoiceAmount();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int invoiceToEdit = 0;
            string custName = String.Empty;
            double paymentDone = 0;
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInvoice.SelectedRows[0];
                invoiceToEdit = Int32.Parse((string)row.Cells["Invoice No"].Value);
                custName = (string)row.Cells["Customer Name"].Value;
                double amount = double.Parse(row.Cells["Total Bill Amount"].Value.ToString());
                double received = double.Parse(row.Cells["Received Amount Till Date"].Value.ToString());
                double pending = amount - received;

                Invoice editInvoice = new Invoice(invoiceToEdit);

                InvoicePayment payment = new InvoicePayment(invoiceToEdit, custName, amount, pending);
                if (payment.ShowDialog() == DialogResult.OK)
                {
                    paymentDone = payment.PaymentDone;
                }
                
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
                                   " INNER JOIN customerDetails ON customerDetails.custId = invoiceDetails.custId AND invoiceDetails.userId='" +BaseModel.Instance.CompanyId+ "' AND invoiceDetails.financialYear='" +BaseModel.Instance.FinancialYear+ "'";

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

            dgvInvoice.Sort(dgvInvoice.Columns[1], ListSortDirection.Ascending);

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

        private void dgvInvoice_DoubleClick(object sender, EventArgs e)
        {
            viewSelectedInvoice();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:
                {
                    addNewInvoice();
                }
                break;
                case Keys.F3:
                break;
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calculator = System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
