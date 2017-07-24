using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class Invoice : Form
    {

        BaseModel baseModel = BaseModel.Instance;
        List<int> colIndices = new int[] { 3, 5, 7}.ToList();
        List<string> listOfCustomers = new List<string>();
        List<string> listAddCharges = new List<string>();
        SqliteDb m1 = new SqliteDb();
        int custId = 0;
        double sgstFinal = 0;
        double cgstFinal = 0;
        double igstFinal = 0;

        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            loadCustomerDetailsFromDatabase();

            Invoice_ResizeEnd(sender, e);
        }

        void Invoice_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            //this.Hide();
        }
        /// <summary>
        /// Check state changed for "Shipping details are same as billing"
        /// if checked, disable the shipping details part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBillAndShip_CheckedChanged(object sender, EventArgs e)
        {
            gbShipping.Enabled = !cbBillAndShip.Checked;
            syncBillingAndShipping();
        }

        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (colIndices.Contains(e.ColumnIndex) && String.IsNullOrEmpty(dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.00";
                }
            }
            updateValuesInRow(e.RowIndex, e.ColumnIndex);
        }

        private void updateValuesInRow(int rowIndex, int colIndex)
        {
            if (rowIndex < 0 || !colIndices.Contains(colIndex))
            {
                return;
            }

            float quantity = 0;
            double rate = 0;
            double amount = 0;
            double discount = 0;
            double taxable = 0;

            string tempString;
            
            var row = dgvProducts.Rows[rowIndex];

            // To avoid NullPointerException,
            // TODO : use autocomplete when adding new rows
            row.Cells["colUnit"].Value = row.Cells["colUnit"].Value == null ? String.Empty : row.Cells["colUnit"].Value.ToString();
            row.Cells["colSerNo"].Value = row.Cells["colSerNo"].Value == null ? String.Empty : row.Cells["colSerNo"].Value.ToString();
            row.Cells["colProDes"].Value = row.Cells["colProDes"].Value == null ? String.Empty : row.Cells["colProDes"].Value.ToString();
            row.Cells["colHsnCode"].Value = row.Cells["colHsnCode"].Value == null ? String.Empty : row.Cells["colHsnCode"].Value.ToString();
            row.Cells["colDiscount"].Value = row.Cells["colDiscount"].Value == null ? "0.00" : row.Cells["colDiscount"].Value.ToString();            
            
            tempString = row.Cells["colQty"].Value == null ? "0.00" : row.Cells["colQty"].Value.ToString();
            quantity = !String.IsNullOrEmpty(tempString) ? float.Parse(tempString) : 0;

            tempString = row.Cells["colRate"].Value == null ? "0.00" : row.Cells["colRate"].Value.ToString();
            rate = !String.IsNullOrEmpty(tempString) ? double.Parse(tempString) : 0;
            
            amount = Math.Round(rate * quantity, 2);

            tempString = row.Cells["colDiscount"].Value == null ? "0.00" : row.Cells["colDiscount"].Value.ToString();
            discount = !String.IsNullOrEmpty(tempString) ? double.Parse(tempString) : 0;
            
            taxable = Math.Round(amount - discount, 2);

            row.Cells["colTaxableVal"].Value = taxable;
            row.Cells["colAmount"].Value = amount;
            
            calculateTotals();

        }

        private void calculateTotals()
        {
            float quantity = 0;
            double total = 0;
            double amount = 0;
            double discount = 0;
            double gstAmount = 0;
            double taxableVal = 0;
            foreach(DataGridViewRow row in dgvProducts.Rows)
            {
                quantity += row.Cells["colQty"].Value != null ? float.Parse(row.Cells["colQty"].Value.ToString()) : 0;
                amount += row.Cells["colAmount"].Value != null ? float.Parse(row.Cells["colAmount"].Value.ToString()) : 0;
                discount += row.Cells["colDiscount"].Value != null ? double.Parse(row.Cells["colDiscount"].Value.ToString()) : 0;
                taxableVal += row.Cells["colTaxableVal"].Value != null ? double.Parse(row.Cells["colTaxableVal"].Value.ToString()) : 0;
            }

            taxableVal += calculateTaxableValue();
            gstAmount = calculateGST(taxableVal);
            amount = Math.Round(amount, 2);
            total = taxableVal + gstAmount;

            lbTotalQty.Text = quantity.ToString();
            lbTotalAmount.Text = amount.ToString();
            lbTotalDiscount.Text = discount.ToString();
            lbTotalTaxVal.Text = taxableVal.ToString();
            lbTotalGst.Text = gstAmount.ToString();
            lbTotalFinal.Text = total.ToString();

        }

        private double calculateTaxableValue()
        {
            double result = 0;

            foreach(string name in listAddCharges)
            {
                var addChargeTextBox = "tbAdd" + name;
                var control = tblPnlAddCharge.Controls.Find(addChargeTextBox, true);

                result += !string.IsNullOrEmpty(control[0].Text) ? double.Parse(control[0].Text) : 0;
            }

            return Math.Round(result, 2);
        }

        private double calculateGST(double taxVal)
        {
            if(tbSgst.Enabled)
            {
                var sgst = !String.IsNullOrEmpty(tbSgst.Text) ? double.Parse(tbSgst.Text) : 0;
                var cgst = !String.IsNullOrEmpty(tbCgst.Text) ? double.Parse(tbCgst.Text) : 0 ;

                sgstFinal = Math.Round((sgst * taxVal) / 100, 2);
                cgstFinal = Math.Round((cgst * taxVal) / 100, 2);
                return sgstFinal + cgstFinal;
            }
            else
            {
                var igst = !String.IsNullOrEmpty(tbIgst.Text) ? double.Parse(tbIgst.Text) : 0;
                igstFinal = Math.Round((igst * taxVal)/100, 2);
                return igstFinal;
            }
        }

        private void dgvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(column_KeyPress);

            if (colIndices.Contains(dgvProducts.CurrentCell.ColumnIndex))
            { 
                TextBox tb = e.Control as TextBox;
                //if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(column_KeyPress);
                }
            }
        }

        private void column_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Invoice_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Size.Width <= this.MinimumSize.Width)
            {
                gbBilling.Size = gbBilling.MinimumSize;
                gbShipping.Size = gbShipping.MinimumSize;
                dgvProducts.Size = dgvProducts.MinimumSize;
                gbInvoice.Size = gbInvoice.MinimumSize;
                tblPanelTotals.Size = tblPanelTotals.MinimumSize;
            }
            //else if (this.Size.Width >= this.MaximumSize.Width)
            //{
            //    gbBilling.Size = gbBilling.MaximumSize;
            //    gbShipping.Size = gbShipping.MaximumSize;
            //    dgvProducts.Size = dgvProducts.MaximumSize;
            //    gbInvoice.Size = gbInvoice.MaximumSize;
            //    tblPanelTotals.Size = tblPanelTotals.MaximumSize;
            //    gbAddCharge.Size = gbAddCharge.MaximumSize;
            //}
            else
            {
                gbBilling.Size = gbShipping.Size = new Size((dgvProducts.Size.Width - 5) / 2, gbShipping.Size.Height);
            }

            flwPanelButtons.Location = new Point((this.Size.Width/2) - 75, flwPanelButtons.Location.Y);

            gbShipping.Location = new Point(gbBilling.Location.X + gbBilling.Size.Width + 5, gbBilling.Location.Y);
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            string tempCharge = tbAddCharge.Text;
            if(!String.IsNullOrEmpty(tempCharge) && !String.IsNullOrWhiteSpace(tempCharge))
            {
                if(!listAddCharges.Contains(tempCharge))
                {
                    Label lbAdd = new Label();
                    string append = new string(' ', 50 - tempCharge.Length);
                    lbAdd.Text = append + tempCharge;
                    lbAdd.Name = "lbAdd" + tempCharge;
                    Padding margin = lbAdd.Margin;
                    margin.Top = 5;
                    lbAdd.Margin = margin;
                    lbAdd.Dock = DockStyle.Fill;

                    TextBox tbAdd = new TextBox();
                    tbAdd.Name = "tbAdd" + tempCharge;
                    tbAdd.Dock = DockStyle.Fill;
                    tbAdd.KeyPress += column_KeyPress;
                    tbAdd.TextChanged += tbAdd_TextChanged;

                    this.tblPnlAddCharge.Controls.Add(lbAdd);
                    this.tblPnlAddCharge.Controls.Add(tbAdd);

                    tblPnlAddCharge.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    TableLayoutStyleCollection styles = tblPnlAddCharge.RowStyles;
                    foreach(RowStyle style in styles)
                    {
                        style.SizeType = SizeType.Absolute;
                        style.Height = 30;
                    }

                    listAddCharges.Add(tempCharge);
                }
            }
        }

        void tbAdd_TextChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void tbAddCharge_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddCharge.Text) && !String.IsNullOrWhiteSpace(tbAddCharge.Text))
                btnAddCharge.Enabled = true; 
        }

        private void tbGst_TextChanged(object sender, EventArgs e)
        {
            if (tbSgst.Text.Length > 0 || tbCgst.Text.Length > 0)
            {
                tbIgst.Enabled = false;
            }
            else if(tbIgst.Text.Length > 0)
            {
                tbIgst.Enabled = true;

                tbSgst.Enabled = false;
                tbCgst.Enabled = false;
            }
            else
            {
                tbIgst.Enabled = true;

                tbSgst.Enabled = true;
                tbCgst.Enabled = true;
            }

            calculateTotals();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (!ValidateData()) return;
            try
            {
                string sqlstr = "SELECT * FROM invoiceDetails WHERE invoiceNo ='" + tbInvoiceNum.Text + "' AND IsActive = 1 ";
                DataSet ds = m1.selectData(sqlstr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DialogResult drDuplicateInsert = MessageBox.Show("Invoice no. : " + tbInvoiceNum.Text + " is present in Db.. Do you want to update it?"
                        , "Alert", MessageBoxButtons.YesNo);
                    switch (drDuplicateInsert)
                    {
                        case DialogResult.Yes:
                            sqlstr = "DELETE FROM invoiceProductDetails WHERE invoiceId ='" + ds.Tables[0].Rows[0]["invoiceId"] + "'";
                            m1.Ins_Upd_Del(sqlstr);

                            sqlstr = "DELETE FROM invoiceDetails WHERE invoiceNo ='" + tbInvoiceNum.Text + "'";
                            m1.Ins_Upd_Del(sqlstr);
                            break;
                        case DialogResult.No:
                            return;
                    }
                }

                sqlstr = "select MAX(userId) from userDetails";
                int userId = Convert.ToInt32(m1.scaler(sqlstr));
               
                //, totaCGSTAmount, totalIGSTAmount
                sqlstr = "INSERT INTO invoiceDetails(invoiceNo, invoiceDate, custId, userId, shipPartyName, shipPartyAddress, shipGstIn, shipState, shipCode, sgstPercent, cgstPercent, igstPercent, " +
                        "totalQnty, totalAmount, totaDiscount, totalTaxAmount, totalSGSTAmount,  totaCGSTAmount,  totalIGSTAmount, totalBillAmount, IsActive)" +
                        "VALUES('" + tbInvoiceNum.Text + "', '" + String.Format("{0:dd/MMM/yyyy}", tbInvoiceDate.Text) + "', " + custId + ",'" + userId + "', '" +
                        tbShipName.Text + "', '" + tbShipAddress.Text + "', '" + tbShipGstin.Text + "', '" + cbShipState.SelectedItem + "', '" + tbShipCode.Text + "', '" + tbSgst.Text + "', '" + tbCgst.Text + "', '" + tbIgst.Text + "', '" + lbTotalQty.Text + "', '" + lbTotalAmount.Text + "', '" +
                        lbTotalDiscount.Text + "', '" + lbTotalTaxVal.Text + "', '" + sgstFinal.ToString() + "', '" + cgstFinal.ToString() + "', '" + igstFinal.ToString() + "', '" + lbTotalFinal.Text + "', 1)";
                int NoOfRows = m1.Ins_Upd_Del(sqlstr);

                if (NoOfRows > 0)
                {
                    sqlstr = "select MAX(invoiceId) from invoiceDetails";
                    int invoiceId = Convert.ToInt32(m1.scaler(sqlstr));
                    int rowCount = 0;
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (rowCount < dgvProducts.RowCount - 1)
                        {
                            sqlstr = "INSERT INTO invoiceProductDetails(invoiceId, productName, productCode, productQnty, ProductUnit, productUnitPrice, productAmount, productDiscount, productTaxAmount)" +
                                "VALUES(" + invoiceId + ", '" + row.Cells["colProDes"].Value.ToString() + "', '" + row.Cells["colHsnCode"].Value.ToString() + "', " + float.Parse(row.Cells["colQty"].Value.ToString()) + ", '" 
                                          + row.Cells["colUnit"].Value.ToString() + "', " + float.Parse(row.Cells["colRate"].Value.ToString()) + ", " + float.Parse(row.Cells["colAmount"].Value.ToString()) + ", " 
                                          + float.Parse(row.Cells["colDiscount"].Value.ToString()) + ", " + float.Parse(row.Cells["colTaxableVal"].Value.ToString()) + ")";
                            m1.Ins_Upd_Del(sqlstr);
                            rowCount++;
                        }
                    }

                    foreach (string name in listAddCharges)
                    {
                        var addChargeTextBox = "tbAdd" + name;
                        var control = tblPnlAddCharge.Controls.Find(addChargeTextBox, true);
                        sqlstr = "INSERT INTO additionalCharges(invoiceId, chargeName, chargeAmount)" +
                            "VALUES(" + invoiceId + ", '" + name + "', '" + double.Parse(control[0].Text) + "')";
                        m1.Ins_Upd_Del(sqlstr);
                    }

                    MessageBox.Show("Invoice created successfully");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (tbInvoiceNum.Text == "" || tbInvoiceNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter Voucher number");
                tbInvoiceNum.Focus();
                return;
            }

            btnSave_Click(sender, e);

            PrintInvoice objPrintInvoice = new PrintInvoice(tbInvoiceNum.Text);
            objPrintInvoice.MdiParent = this.MdiParent;
            objPrintInvoice.Show();
        }

        private void cbBillName_SelectedIndexChanged(object sender, EventArgs e)
        {
            custId = 0;
            string sqlstr = "SELECT * FROM customerDetails where custname='" + cbBillName.Text + "'";
            DataSet ds = m1.selectData(sqlstr);
            if(ds.Tables[0].Rows.Count > 0)
            {
                custId = Convert.ToInt32(ds.Tables[0].Rows[0]["custId"]);
                tbBillAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["custaddress"]);
                tbBillGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["custgstin"]);
                cbBillState.Text = Convert.ToString(ds.Tables[0].Rows[0]["custstate"]);
                tbBillCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcode"]);
                tbShipName.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipname"]);
                tbShipAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipaddress"]);
                tbShipGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipgstin"]);
                cbShipState.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipstate"]);
                tbShipCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipcode"]);
            }
            else
            {
                tbBillAddress.ResetText();
                tbBillGstin.ResetText();
                cbBillState.ResetText();
                tbBillCode.ResetText();
                tbShipName.ResetText();
                tbShipAddress.ResetText();
                tbShipGstin.ResetText();
                cbShipState.ResetText();
                tbShipCode.ResetText();
            }
        }


        private void loadCustomerDetailsFromDatabase()
        {
            string sqlstr = "SELECT custname FROM customerDetails";
            DataSet ds = m1.selectData(sqlstr);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                listOfCustomers.Add(Convert.ToString(row["custname"]));
            }
            
            cbBillName.DataSource = listOfCustomers;
            cbBillName.SelectedIndex = -1;
            cbBillName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbBillName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void syncBillingAndShipping()
        {
            if (cbBillAndShip.Checked)
            {
                tbShipName.Text = cbBillName.Text;
                tbShipAddress.Text = tbBillAddress.Text;
                tbShipGstin.Text = tbBillGstin.Text;
                cbShipState.Text = cbBillState.Text;
                tbShipCode.Text = tbBillCode.Text;
            }
        }

        private void cbShipState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = baseModel.ToPascalCase(cbShipState.Text);
            tbShipCode.Text = baseModel.stateCodes[state];
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool name = !String.IsNullOrEmpty(tbShipName.Text) && !String.IsNullOrWhiteSpace(tbShipName.Text);
            bool address = !String.IsNullOrEmpty(tbShipAddress.Text) && !String.IsNullOrWhiteSpace(tbShipAddress.Text);
            bool gstin = !String.IsNullOrEmpty(tbShipGstin.Text) && !String.IsNullOrWhiteSpace(tbShipGstin.Text);
            bool state = !String.IsNullOrEmpty(cbShipState.Text) && !String.IsNullOrWhiteSpace(cbShipState.Text);
            bool code = !String.IsNullOrEmpty(tbShipCode.Text) && !String.IsNullOrWhiteSpace(tbShipCode.Text);

            if (name && address && gstin && state && code && tbShipGstin.Text.Length == 15)
            {
                flwPanelButtons.Enabled = true;
            }
            else
            {
                flwPanelButtons.Enabled = false;
            }
        }

        private void tbShipCode_Leave(object sender, EventArgs e)
        {
            int code = !String.IsNullOrEmpty(tbShipCode.Text) ? int.Parse(tbShipCode.Text) : 1;
            string codeStr = String.Format("{0:D2}", code);
            if (code > 0 && code < 37)
            {
                string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
                cbShipState.SelectedIndex = cbShipState.FindStringExact(state);
            }
            else
            {
                MessageBox.Show("State code must be between 1 and 36.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbShipState.SelectedIndex = 1;
            }
        }

        private void tbShipCode_Click(object sender, EventArgs e)
        {
            tbShipCode.SelectAll();
        }

    }
}
