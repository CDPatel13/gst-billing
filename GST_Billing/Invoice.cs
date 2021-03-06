﻿using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GST_Billing
{
	public partial class Invoice : Form
	{
		BaseModel baseModel = BaseModel.Instance;
		List<int> colIndices = new int[] { 3, 5, 7}.ToList();
		List<string> listOfCustomers = new List<string>();
		List<Tuple<string, string>> listofAddCharges = new List<Tuple<string, string>>();
		List<string> challanNumbers = new List<string>();

		SqliteDb m1 = new SqliteDb();
		bool isDirty = false;
		int custId = 0;
        double totaltaxColAmt = 0;
		double sgstFinal = 0;
		double cgstFinal = 0;
		double igstFinal = 0;
		private string invoiceToEdit = String.Empty;

		public Invoice()
		{
			InitializeComponent();

            loadCustomerDetailsFromDatabase();
            tbBillName.DataSource = listOfCustomers;
            tbBillName.SelectedIndex = -1;
            tbBillName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBillName.AutoCompleteSource = AutoCompleteSource.ListItems;
            tbPoDate.Format = DateTimePickerFormat.Custom;
            tbPoDate.CustomFormat = " ";

            dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		public Invoice(string invoiceToEdit)
		{
			// TODO: Complete member initialization
			this.invoiceToEdit = invoiceToEdit;
			InitializeComponent();

            loadCustomerDetailsFromDatabase();
            tbBillName.DataSource = listOfCustomers;
            tbBillName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBillName.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		private void Invoice_Load(object sender, EventArgs e)
		{
			if(invoiceToEdit == String.Empty)
			{ 
                tbPaymentTerms.SelectedIndex = -1;
			}
			else
			{
				getInvoiceDetailsToEdit(invoiceToEdit);
				enableDisableControls();
			}

			this.WindowState = FormWindowState.Maximized;
			this.ResizeRedraw = true;
			this.Refresh();
		}

		private void enableDisableControls()
		{
			gbBilling.Enabled = false;
			tbInvoiceNum.Enabled = false;

			cbBillAndShip.Checked = false;
		}

		private void getInvoiceDetailsToEdit(string invoiceToEdit)
		{
			int invoiceId = 0;
			string sqlstrInvoice = "SELECT custname, custaddress, custlandmark, custcity, custpincode, custgstin, custstate, custcode, " + 
								   "invoiceId, invoiceNo, invoiceDate, termName, invoiceDetails.shipName, " +
								   "invoiceDetails.shipAddress, invoiceDetails.shipLandmark, invoiceDetails.shipCity, invoiceDetails.shipCode, " +
								   "invoiceDetails.shipState, invoiceDetails.shipPinCode, invoiceDetails.shipGstIn, " +
								   "sgstPercent, cgstPercent,igstPercent, totalQnty, totalAmount, totaDiscount, " +
								   "totalTaxAmount, totalSGSTAmount, totaCGSTAmount, totalIGSTAmount, totalBillAmount," +
								   "receivedAmount, poNo, poDate, refNo, transport" +
								   " FROM invoiceDetails" +
                                   " INNER JOIN customerDetails ON customerDetails.custId = invoiceDetails.custId AND invoiceNo = '" + invoiceToEdit + "' AND invoiceDetails.userId='" + BaseModel.Instance.CompanyId + "' AND invoiceDetails.financialYear='" + BaseModel.Instance.FinancialYear + "' ";

			DataSet ds = m1.selectData(sqlstrInvoice);
			if(ds!=null && ds.Tables[0].Rows.Count > 0)
			{
				DataRow row = ds.Tables[0].Rows[0];

                if (row["poDate"] != null && row["poDate"].ToString() != " ")
                {
                    tbPoDate.Value = DateTime.ParseExact(row["poDate"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    tbPoDate.CustomFormat = " ";
                }
                tbPoNum.Text = Convert.ToString(row["poNo"]);
				tbInvoiceNum.Text = Convert.ToString(row["invoiceNo"]);
				tbInvoiceDate.Value = DateTime.ParseExact(row["invoiceDate"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
				tbBillName.Text = Convert.ToString(row["custname"]);
				tbBillAddress.Text = Convert.ToString(row["custaddress"]);
				tbBillLandmark.Text = Convert.ToString(row["custlandmark"]);
				tbBillCity.Text = Convert.ToString(row["custcity"]);
				tbBillPin.Text = Convert.ToString(row["custpincode"]);
				tbBillGstin.Text = Convert.ToString(row["custgstin"]);
				tbBillState.Text = Convert.ToString(row["custstate"]);
				tbBillCode.Text = Convert.ToString(row["custcode"]);
				tbPaymentTerms.Text = Convert.ToString(row["termName"]);
				tbShipName.Text = Convert.ToString(row["shipName"]);
				tbShipAddress.Text = Convert.ToString(row["shipAddress"]);
				tbShipLandmark.Text = Convert.ToString(row["shipLandmark"]);
				tbShipCity.Text = Convert.ToString(row["shipCity"]);
				tbShipCode.Text = Convert.ToString(row["shipCode"]);
				tbShipState.Text = Convert.ToString(row["shipState"]);
				tbShipPin.Text = Convert.ToString(row["shipPinCode"]);
				tbShipGstin.Text = Convert.ToString(row["shipGstIn"]);
                tbRefNo.Text = Convert.ToString(row["refNo"]);
                tbTransport.Text = Convert.ToString(row["transport"]);

                tbSgst.TextChanged -= tbGst_TextChanged;
                tbCgst.TextChanged -= tbGst_TextChanged;
                tbIgst.TextChanged -= tbGst_TextChanged;
                tbSgst.Text = Convert.ToString(row["sgstPercent"]);
				tbCgst.Text = Convert.ToString(row["cgstPercent"]);
				tbIgst.Text = Convert.ToString(row["igstPercent"]);
                tbSgst.TextChanged += tbGst_TextChanged;
                tbCgst.TextChanged += tbGst_TextChanged;
                tbIgst.TextChanged += tbGst_TextChanged;
                
                lbTotalQty.Text = Convert.ToString(row["totalQnty"]);
				lbTotalAmount.Text = Convert.ToString(row["totalAmount"]);
				lbTotalDiscount.Text = Convert.ToString(row["totaDiscount"]);
				lbTotalTaxVal.Text = Convert.ToString(row["totalTaxAmount"]);
				lbTotalSgst.Text = Convert.ToString(row["totalSGSTAmount"]);
				lbTotalCgst.Text = Convert.ToString(row["totaCGSTAmount"]);
				lbTotalIgst.Text = Convert.ToString(row["totalIGSTAmount"]);
				lbTotalFinal.Text = Convert.ToString(row["totalBillAmount"]);

				invoiceId = int.Parse(row["invoiceId"].ToString());
				custId = getCustomerID(tbBillName.Text);
			}

			fillProductsForInvoice(invoiceId);
			fillAdditionalChargesForInvoice(invoiceId);
			fillChallanForInvoice(invoiceId);
		}

		private void fillChallanForInvoice(int invoiceId)
		{
			string sqlstrInvoice = "SELECT challanNo FROM invoiceChallanDetails WHERE invoiceId='" + invoiceId + "'";

			DataSet ds = m1.selectData(sqlstrInvoice);
			if (ds != null && ds.Tables[0].Rows.Count > 0)
			{
				challanNumbers.Clear();
				foreach (DataRow row in ds.Tables[0].Rows)
				{
					challanNumbers.Add(row["challanNo"].ToString());
				}
			}
			for(int index = 0; index < challanNumbers.Count; index++)
			{
				if(index > 0)
				{
					lbAddedChallan.Text += ",";
				}
				lbAddedChallan.Text += challanNumbers[index].ToString();
			}
		}

		private void fillAdditionalChargesForInvoice(int invoiceId)
		{
			int index = 1;
			string sqlstrInvoice = "SELECT chargeName, chargeAmount" +
								   " FROM additionalCharges WHERE invoiceId='" + invoiceId + "'";

			DataSet ds = m1.selectData(sqlstrInvoice);
			if (ds != null && ds.Tables[0].Rows.Count > 0)
			{
				for (index = 1; index <= ds.Tables[0].Rows.Count; index++ )
				{
					DataRow row = ds.Tables[0].Rows[index - 1];
					switch(index)
					{
						case 1:
							{ 
								lbAddCharge1.Text = Convert.ToString(row[0]);
								tbAddCharge1.Text = Convert.ToString(row[1]);
							}
							break;
						case 2:
							{
								lbAddCharge2.Text = Convert.ToString(row[0]);
								tbAddCharge2.Text = Convert.ToString(row[1]);
							}
							break;
						case 3:
							{
								lbAddCharge3.Text = Convert.ToString(row[0]);
								tbAddCharge3.Text = Convert.ToString(row[1]);
							}
							break;
					}
				}
			}
		}

		private void fillProductsForInvoice(int invoiceId)
		{
			string sqlstrInvoice = "SELECT productName, productCode, productQnty, productUnit, productUnitPrice, productAmount, productDiscount, productTaxAmount" +
								   " FROM invoiceProductDetails WHERE invoiceId='" + invoiceId + "'";

			DataSet ds = m1.selectData(sqlstrInvoice);
			if (ds != null && ds.Tables[0].Rows.Count > 0)
			{
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					int SerNo = 0;
					object[] buffer = new object[9];
					
					DataGridViewRow dgvRow = new DataGridViewRow();

					buffer[0] = Convert.ToString(++SerNo);
					buffer[1] = Convert.ToString(row["productName"]);
					buffer[2] = Convert.ToString(row["productCode"]);
					buffer[3] = Convert.ToString(row["productQnty"]);
					buffer[4] = Convert.ToString(row["productUnit"]);
                    buffer[5] = Double.Parse(row["productUnitPrice"].ToString()).ToString("0.00##");
					buffer[6] = Double.Parse(row["productAmount"].ToString()).ToString("0.00##");
					buffer[7] = Double.Parse(row["productDiscount"].ToString()).ToString("0.00##");
					buffer[8] = Double.Parse(row["productTaxAmount"].ToString()).ToString("0.00##");

					dgvRow.CreateCells(dgvProducts, buffer);
					dgvProducts.Rows.Add(dgvRow);
				}
			}
		}

		private void setAdditionalCharges()
		{
			lbAddCharge1.DataSource = baseModel.additionalCharges.Values.ToList<string>();
			lbAddCharge2.DataSource = baseModel.additionalCharges.Values.ToList<string>();
			lbAddCharge3.DataSource = baseModel.additionalCharges.Values.ToList<string>();

			lbAddCharge1.SelectedIndex = -1;
			lbAddCharge2.SelectedIndex = -1;
			lbAddCharge3.SelectedIndex = -1;
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
			isDirty = true;
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
			row.Cells["colDiscount"].Value = tempString;
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
            totaltaxColAmt = 0;
			foreach(DataGridViewRow row in dgvProducts.Rows)
			{
				quantity += row.Cells["colQty"].Value != null ? float.Parse(row.Cells["colQty"].Value.ToString()) : 0;
				amount += row.Cells["colAmount"].Value != null ? float.Parse(row.Cells["colAmount"].Value.ToString()) : 0;
				discount += row.Cells["colDiscount"].Value != null ? double.Parse(row.Cells["colDiscount"].Value.ToString()) : 0;
				taxableVal += row.Cells["colTaxableVal"].Value != null ? double.Parse(row.Cells["colTaxableVal"].Value.ToString()) : 0;
			}
            totaltaxColAmt = taxableVal;
			taxableVal += calculateTaxableValue();
			gstAmount = calculateGST(taxableVal);
			amount = Math.Round(amount, 2);
			total = Math.Round(taxableVal + gstAmount, 0);

			lbTotalQty.Text = quantity.ToString();
			lbTotalAmount.Text = amount.ToString();
			lbTotalDiscount.Text = discount.ToString();
			lbTotalTaxVal.Text = taxableVal.ToString();
			lbTotalFinal.Text = total.ToString();

		}

		private double calculateTaxableValue()
		{
			double result = 0;

			result = calculateAddCharges();

			return Math.Round(result, 2);
		}

		private double calculateGST(double taxVal)
		{
            string igstPercent = String.IsNullOrWhiteSpace(tbIgst.Text) ? "0" : tbIgst.Text;
            string sgstPercent = String.IsNullOrWhiteSpace(tbSgst.Text) ? "0" : tbSgst.Text;
            string cgstPercent = String.IsNullOrWhiteSpace(tbCgst.Text) ? "0" : tbCgst.Text;

			if ((tbSgst.Text.Length > 0 || tbCgst.Text.Length > 0) && (int.Parse(sgstPercent) > 0 || int.Parse(cgstPercent) > 0))
			{
                var sgst = !String.IsNullOrEmpty(tbSgst.Text) ? double.Parse(sgstPercent) : 0;
                var cgst = !String.IsNullOrEmpty(tbCgst.Text) ? double.Parse(cgstPercent) : 0;

                sgstFinal = Math.Round((sgst * taxVal) / 100, 2);
                cgstFinal = Math.Round((cgst * taxVal) / 100, 2);

                lbTotalSgst.Text = sgstFinal.ToString();
                lbTotalCgst.Text = cgstFinal.ToString();

                return sgstFinal + cgstFinal;
			}
            else if (tbIgst.Text.Length > 0 && int.Parse(igstPercent) > 0)
            {
                var igst = !String.IsNullOrEmpty(tbIgst.Text) ? double.Parse(igstPercent) : 0;
                igstFinal = Math.Round((igst * taxVal) / 100, 2);

                lbTotalIgst.Text = igstFinal.ToString();

                return igstFinal;
            }
            else
            {
                return 0;
            }
/*
			if(tbSgst.Enabled)
			{
                var sgst = !String.IsNullOrEmpty(tbSgst.Text) ? double.Parse(sgstPercent) : 0;
                var cgst = !String.IsNullOrEmpty(tbCgst.Text) ? double.Parse(cgstPercent) : 0;

				sgstFinal = Math.Round((sgst * taxVal) / 100, 2);
				cgstFinal = Math.Round((cgst * taxVal) / 100, 2);

				lbTotalSgst.Text = sgstFinal.ToString();
				lbTotalCgst.Text = cgstFinal.ToString();

				return sgstFinal + cgstFinal;
			}
			else
			{
                var igst = !String.IsNullOrEmpty(tbIgst.Text) ? double.Parse(igstPercent) : 0;
				igstFinal = Math.Round((igst * taxVal)/100, 2);

				lbTotalIgst.Text = igstFinal.ToString();

				return igstFinal;
			}*/
		}

		private void dgvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= new KeyPressEventHandler(column_KeyPress);

			if(dgvProducts.CurrentCell.ColumnIndex == 1)
			{
				TextBox tb = e.Control as TextBox;
				if(tb != null)
				{
                    tb.Multiline = false;
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    addProducts(collection);
					tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					tb.AutoCompleteCustomSource = collection;
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
					tb.TextChanged += tb_TextChanged;
				}
			}

			if (colIndices.Contains(dgvProducts.CurrentCell.ColumnIndex))
			{ 
				TextBox tb = e.Control as TextBox;
				if(tb != null)
				{
					tb.KeyPress += new KeyPressEventHandler(column_KeyPress);
				}
			}
		}

		private void tb_TextChanged(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			string sqlstr = "SELECT hsnCode, productPrice, productUnit FROM productDetails WHERE productName='" + tb.Text + "' AND userId='" +BaseModel.Instance.CompanyId+ "'";
			DataSet ds = m1.selectData(sqlstr);
			if (ds != null && ds.Tables[0].Rows.Count > 0)
			{
				dgvProducts.CurrentRow.Cells["colHsnCode"].Value = ds.Tables[0].Rows[0][0].ToString();
				dgvProducts.CurrentRow.Cells["colRate"].Value = ds.Tables[0].Rows[0][1].ToString();
				dgvProducts.CurrentRow.Cells["colUnit"].Value = ds.Tables[0].Rows[0][2].ToString();
			}
		}

		private void addProducts(AutoCompleteStringCollection collection)
		{
			string sqlstr = "SELECT productName FROM productDetails WHERE userId='" +BaseModel.Instance.CompanyId+ "'";
			DataSet ds = m1.selectData(sqlstr);
			if(ds != null && ds.Tables[0].Rows.Count > 0)
			{
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					collection.Add(row[0].ToString());
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

		private void tbGst_TextChanged(object sender, EventArgs e)
		{
            string igstPercent = String.IsNullOrWhiteSpace(tbIgst.Text) ? "0" : tbIgst.Text;
            string sgstPercent = String.IsNullOrWhiteSpace(tbSgst.Text) ? "0" : tbSgst.Text;
            string cgstPercent = String.IsNullOrWhiteSpace(tbCgst.Text) ? "0" : tbCgst.Text;

			if ((tbSgst.Text.Length > 0 || tbCgst.Text.Length > 0) && (int.Parse(sgstPercent) > 0 || int.Parse(cgstPercent) > 0))
			{
				tbIgst.Enabled = false;
                tbIgst.Text = "0";
                igstFinal = 0;
                lbTotalIgst.Text = igstFinal.ToString();
			}
            else if (tbIgst.Text.Length > 0 && int.Parse(igstPercent) > 0)
			{
				tbIgst.Enabled = true;

				tbSgst.Enabled = false;
				tbCgst.Enabled = false;

				tbSgst.Text = "0";
				tbCgst.Text = "0";

                sgstFinal = 0;
                lbTotalSgst.Text = sgstFinal.ToString();

                cgstFinal = 0;
                lbTotalCgst.Text = cgstFinal.ToString();
			}
			else
			{
				tbIgst.Enabled = true;

				tbSgst.Enabled = true;
				tbCgst.Enabled = true;

                sgstFinal = 0;
                lbTotalSgst.Text = sgstFinal.ToString();

                cgstFinal = 0;
                lbTotalCgst.Text = cgstFinal.ToString();

                igstFinal = 0;
                lbTotalIgst.Text = igstFinal.ToString();
			}

			calculateTotals();

		}

		private void cbBillName_SelectedIndexChanged(object sender, EventArgs e)
		{
			getCustomerDetails(tbBillName.Text);
		}

		private void getCustomerDetails(string customer)
		{
			custId = 0;
			string sqlstr = "SELECT * FROM customerDetails where custname='" + customer + "' AND userId='" +BaseModel.Instance.CompanyId+ "'";
			DataSet ds = m1.selectData(sqlstr);
			if (ds.Tables[0].Rows.Count > 0)
			{
				custId = Convert.ToInt32(ds.Tables[0].Rows[0]["custId"]);
				tbBillAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["custaddress"]);
				tbBillLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["custlandmark"]);
				tbBillCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcity"]);
				tbBillPin.Text = Convert.ToString(ds.Tables[0].Rows[0]["custpincode"]);
				tbBillGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["custgstin"]);
				tbBillState.Text = Convert.ToString(ds.Tables[0].Rows[0]["custstate"]);
				tbBillCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcode"]);
				tbPaymentTerms.Text = Convert.ToString(ds.Tables[0].Rows[0]["custpaymentTermName"]);
				tbShipName.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipname"]);
				tbShipAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipaddress"]);
				tbShipLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipLandmark"]);
				tbShipCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipCity"]);
				tbShipPin.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipPinCode"]);
				tbShipGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipgstin"]);
				tbShipState.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipstate"]);
				tbShipCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipcode"]);
			}
			else
			{
				tbBillCity.ResetText();
				tbBillLandmark.ResetText();
				tbBillAddress.ResetText();
				tbBillGstin.ResetText();
				tbBillState.ResetText();
				tbBillCode.ResetText();
				tbBillPin.ResetText();
				tbShipName.ResetText();
				tbShipAddress.ResetText();
				tbShipGstin.ResetText();
				tbShipState.ResetText();
				tbShipCode.ResetText();
				tbShipCity.ResetText();
				tbShipLandmark.ResetText();
				tbShipPin.ResetText();
				tbPaymentTerms.ResetText();
			}
		}

		private void loadCustomerDetailsFromDatabase()
		{
			string sqlstr = "SELECT custname FROM customerDetails where userId='" +BaseModel.Instance.CompanyId+ "'";
			DataSet ds = m1.selectData(sqlstr);
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				listOfCustomers.Add(Convert.ToString(row["custname"]));
			}
			

		}

		private void syncBillingAndShipping()
		{
			if (cbBillAndShip.Checked)
			{
				tbShipName.Text = tbBillName.Text;
				tbShipAddress.Text = tbBillAddress.Text;
				tbShipLandmark.Text = tbBillLandmark.Text;
				tbShipCity.Text = tbBillCity.Text;
				tbShipPin.Text = tbBillPin.Text;
				tbShipGstin.Text = tbBillGstin.Text;
				tbShipState.Text = tbBillState.Text;
				tbShipCode.Text = tbBillCode.Text;
			}
		}

		private void cbShipState_SelectedIndexChanged(object sender, EventArgs e)
		{
			string state = baseModel.ToPascalCase(tbShipState.Text);
			tbShipCode.Text = baseModel.stateCodes[state];
		}

		private void tbShipState_Leave(object sender, EventArgs e)
		{
			try
			{
				if(!String.IsNullOrWhiteSpace(tbShipState.Text))
				{
					string state = baseModel.ToPascalCase(tbShipState.Text);
					tbShipCode.Text = baseModel.stateCodes[state];
				}
				else if(!String.IsNullOrWhiteSpace(tbShipCode.Text))
				{
					setShipStateFromCode();
				}
			}
			catch(Exception ex)
			{
                Console.WriteLine(ex.Message);
				tbShipState.Text = String.Empty;
				tbShipState.SelectedIndex = -1;
				tbShipCode.Clear();
			}
		}

		private void setShipStateFromCode()
		{
			int code = !String.IsNullOrWhiteSpace(tbShipCode.Text) ? int.Parse(tbShipCode.Text) : 1;
			string codeStr = String.Format("{0:D2}", code);
			if (code > 0 && code < 37)
			{
				string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
				tbShipState.SelectedIndex = tbShipState.FindStringExact(state);
			}
			else
			{
				MessageBox.Show("State code must be between 1 and 36.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tbShipState.SelectedIndex = 1;
			}
		}

		private void tbShipCode_Leave(object sender, EventArgs e)
		{
			try
			{ 
				if (!String.IsNullOrWhiteSpace(tbShipCode.Text) && !String.IsNullOrWhiteSpace(tbShipState.Text))
				{
					setShipStateFromCode();	
				}
				else
				{
					string state = baseModel.ToPascalCase(tbShipState.Text);
					tbShipCode.Text = baseModel.stateCodes[state];
				}
			}
			catch(Exception ex)
			{
                Console.WriteLine(ex.Message);
				tbShipState.Text = String.Empty;
				tbShipState.SelectedIndex = -1;
				tbShipCode.Clear();
			}
		}

		private void tbShipCode_Click(object sender, EventArgs e)
		{
			tbShipCode.SelectAll();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateData()) return;
			try
			{
				string sqlstr = "SELECT * FROM invoiceDetails WHERE invoiceNo ='" + tbInvoiceNum.Text + "' AND userId='" +BaseModel.Instance.CompanyId+ "' AND financialYear='" +BaseModel.Instance.FinancialYear+ "' AND IsActive = 1 ";
				DataSet ds = m1.selectData(sqlstr);
				if (ds.Tables[0].Rows.Count > 0 && invoiceToEdit != String.Empty)
				{
					DialogResult drDuplicateInsert = MessageBox.Show("Do you want to update Invoice : " + tbInvoiceNum.Text + " ?"
						, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					switch (drDuplicateInsert)
					{
						case DialogResult.Yes:
                            sqlstr = "DELETE FROM invoiceProductDetails WHERE invoiceId =" + Convert.ToInt32(ds.Tables[0].Rows[0]["invoiceId"]) + "";
							m1.Ins_Upd_Del(sqlstr);

                            sqlstr = "DELETE FROM invoiceChallanDetails WHERE invoiceId =" + Convert.ToInt32(ds.Tables[0].Rows[0]["invoiceId"]) + "";
							m1.Ins_Upd_Del(sqlstr);

                            sqlstr = "DELETE FROM additionalCharges WHERE invoiceId =" + Convert.ToInt32(ds.Tables[0].Rows[0]["invoiceId"]) + "";
							m1.Ins_Upd_Del(sqlstr);

                            sqlstr = "DELETE FROM invoiceDetails WHERE invoiceId =" + Convert.ToInt32(ds.Tables[0].Rows[0]["invoiceId"]) + "";
							m1.Ins_Upd_Del(sqlstr);
							break;
						case DialogResult.No:
							return;
					}
				}
                else if (ds.Tables[0].Rows.Count > 0 && invoiceToEdit == String.Empty)
                {
                    MessageBox.Show("Invoice No. " + tbInvoiceNum.Text + " is already in use. Please use another number.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //sqlstr = "select MAX(userId) from userDetails";
                //int userId = Convert.ToInt32(m1.scaler(sqlstr));

				//, totaCGSTAmount, totalIGSTAmount
                calculateTotals();
				sqlstr = "INSERT INTO invoiceDetails(invoiceNo, invoiceDate, custId, userId, poNo, poDate, termName, shipName, shipAddress, shipLandmark, shipCity, shipPinCode, shipGstIn, shipState, shipCode, sgstPercent, cgstPercent, igstPercent, " +
                        "totalQnty, totalAmount, totaDiscount, totalTaxColAmt, totalTaxAmount, totalSGSTAmount,  totaCGSTAmount,  totalIGSTAmount, totalBillAmount, receivedAmount, IsActive, financialYear, refNo, transport)" +
                        "VALUES('" + tbInvoiceNum.Text + "', '" + String.Format("{0:dd/MM/yyyy}", tbInvoiceDate.Text) + "', " + custId + ", '" + BaseModel.Instance.CompanyId + "', '" + tbPoNum.Text + "','" + String.Format("{0:dd/MM/yyyy}", tbPoDate.Text) + "', '" + tbPaymentTerms.SelectedItem + "', '" +
						tbShipName.Text + "', '" + tbShipAddress.Text + "', '" + tbShipLandmark.Text + "', '" + tbShipCity.Text + "', '" + tbShipPin.Text + "', '" + tbShipGstin.Text + "', '" + tbShipState.SelectedItem + "', '" + tbShipCode.Text + "', '" + tbSgst.Text + "', '" + tbCgst.Text + "', '" + tbIgst.Text + "', '" + lbTotalQty.Text + "', '" + lbTotalAmount.Text + "', '" +
                        lbTotalDiscount.Text + "', '" + totaltaxColAmt + "', '" + lbTotalTaxVal.Text + "', '" + sgstFinal.ToString() + "', '" + cgstFinal.ToString() + "', '" + igstFinal.ToString() + "', '" + lbTotalFinal.Text + "', 0, 1, '" + BaseModel.Instance.FinancialYear + "', '" + tbRefNo.Text + "','" + tbTransport.Text + "')";
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

                    //getListOfAdditionalCharges(); // CDP : Taken into validateAddCharges()
					foreach (var item in listofAddCharges)
					{                        
						sqlstr = "INSERT INTO additionalCharges(invoiceId, chargeName, chargeAmount)" +
							"VALUES(" + invoiceId + ", '" + item.Item1 + "', '" + item.Item2 + "')";
						m1.Ins_Upd_Del(sqlstr);
					}

					foreach (string challanNo in challanNumbers)
					{
						sqlstr = "INSERT INTO invoiceChallanDetails(invoiceId, challanNo)" +
							"VALUES(" + invoiceId + ", '" + challanNo + "')";
						m1.Ins_Upd_Del(sqlstr);
					}

					MessageBox.Show("Invoice saved successfully","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

					btnPrint.Enabled = true;
                    btnChallan.Enabled = true;
					isDirty = false;
				}
			}
			catch (Exception e1)
			{
				MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int getCustomerID(string name)
		{
			string sqlstr = "SELECT custId FROM customerDetails WHERE custname='"+ name + "' AND userId='" +BaseModel.Instance.CompanyId+ "'";
			DataSet ds = m1.selectData(sqlstr);
			if(ds != null && ds.Tables[0].Rows.Count > 0)
			{
				custId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
				return custId;
			}
			return 0;
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (tbInvoiceNum.Text == "" || tbInvoiceNum.Text.Trim().Length == 0)
			{
				MessageBox.Show("Enter Invoice number", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
				tbInvoiceNum.Focus();
				return;
			}

			//btnSave_Click(sender, e);

			if(isDirty == false)
			{
                SelectInvoicePrint printInvoice = new SelectInvoicePrint();
                if (printInvoice.ShowDialog() == DialogResult.Yes)
                {
                    if (baseModel.SelectedCompany.Contains("Parth"))
                    {
                        ParthInvoice objPrintInvoice = new ParthInvoice(tbInvoiceNum.Text, printInvoice.invoicePrintType);
                        objPrintInvoice.MdiParent = this.MdiParent;
                        objPrintInvoice.Show();
                    }
                    else if (baseModel.SelectedCompany.Contains("Industrial Instruments"))
                    {
                        IICInvoice objPrintInvoice = new IICInvoice(tbInvoiceNum.Text, printInvoice.invoicePrintType);
                        objPrintInvoice.MdiParent = this.MdiParent;
                        objPrintInvoice.Show();
                    }
                }
			}
			else
			{
				MessageBox.Show("Please save invoice before printing.", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}

		private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnAddChallan_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(lbAddedChallan.Text) && !String.IsNullOrEmpty(tbChallanNumber.Text))
			{
				lbAddedChallan.Text = tbChallanNumber.Text;
                challanNumbers.Add(tbChallanNumber.Text);
			}
			else if(!challanNumbers.Contains(tbChallanNumber.Text) && !String.IsNullOrWhiteSpace(tbChallanNumber.Text))
			{
                if (challanNumbers.Count < 10)
                {
                    lbAddedChallan.Text += "," + tbChallanNumber.Text;
                    challanNumbers.Add(tbChallanNumber.Text);
                    lbAddedChallan.Text.TrimEnd(',');
                }
                else
                {
                    MessageBox.Show("Maximum 10 challans per invoice are allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
			}
			
			tbChallanNumber.Clear();
		}

		private void btnClearChallan_Click(object sender, EventArgs e)
		{
			lbAddedChallan.Text = String.Empty;
			challanNumbers.Clear();
		}

		private double calculateAddCharges()
		{
			double totalAddCharge = 0;

			if (!String.IsNullOrEmpty(lbAddCharge1.Text) && !String.IsNullOrEmpty(tbAddCharge1.Text))
			{
				totalAddCharge += double.Parse(tbAddCharge1.Text);
			}

			if (!String.IsNullOrEmpty(lbAddCharge2.Text) && !String.IsNullOrEmpty(tbAddCharge2.Text))
			{
				totalAddCharge += double.Parse(tbAddCharge2.Text);
			}

			if (!String.IsNullOrEmpty(lbAddCharge3.Text) && !String.IsNullOrEmpty(tbAddCharge3.Text))
			{
				totalAddCharge += double.Parse(tbAddCharge3.Text);
			}

			return totalAddCharge;
		}

		private void getListOfAdditionalCharges()
		{
            if (!String.IsNullOrWhiteSpace(lbAddCharge1.Text) && !String.IsNullOrWhiteSpace(tbAddCharge1.Text) && !listofAddCharges.Exists(x => x.Item1 == lbAddCharge1.Text))
			{
				listofAddCharges.Add(Tuple.Create(lbAddCharge1.Text, tbAddCharge1.Text));
			}
            else if (listofAddCharges.Exists(x => x.Item1 == lbAddCharge1.Text))
            {
                Tuple<string, string> pair = listofAddCharges.Find(x => x.Item1 == lbAddCharge1.Text);
                pair = new Tuple<string, string>(pair.Item1, tbAddCharge1.Text);
                listofAddCharges.Remove(listofAddCharges.Find(x => x.Item1 == lbAddCharge1.Text));
                listofAddCharges.Add(pair);
            }

            if (!String.IsNullOrWhiteSpace(lbAddCharge2.Text) && !String.IsNullOrWhiteSpace(tbAddCharge2.Text) && !listofAddCharges.Exists(x => x.Item1 == lbAddCharge2.Text))
			{
				listofAddCharges.Add(Tuple.Create(lbAddCharge2.Text, tbAddCharge2.Text));
			}
            else if (listofAddCharges.Exists(x => x.Item1 == lbAddCharge2.Text))
            {
                Tuple<string, string> pair = listofAddCharges.Find(x => x.Item1 == lbAddCharge2.Text);
                pair = new Tuple<string, string>(pair.Item1, tbAddCharge2.Text);
                listofAddCharges.Remove(listofAddCharges.Find(x => x.Item1 == lbAddCharge2.Text));
                listofAddCharges.Add(pair);
            }

            // Removed Additional Charge #3 and Chenged it into Reference No.
            if (!String.IsNullOrWhiteSpace(lbAddCharge3.Text) && !String.IsNullOrWhiteSpace(tbAddCharge3.Text) && !listofAddCharges.Exists(x => x.Item1 == lbAddCharge3.Text))
			{
				listofAddCharges.Add(Tuple.Create(lbAddCharge3.Text, tbAddCharge3.Text));
			}
            else if (listofAddCharges.Exists(x => x.Item1 == lbAddCharge3.Text))
            {
                Tuple<string, string> pair = listofAddCharges.Find(x => x.Item1 == lbAddCharge3.Text);
                pair = new Tuple<string, string>(pair.Item1, tbAddCharge3.Text);
                listofAddCharges.Remove(listofAddCharges.Find(x => x.Item1 == lbAddCharge3.Text));
                listofAddCharges.Add(pair);
            }

		}

		private void tbAddCharge_TextChanged(object sender, EventArgs e)
		{
			calculateTotals();
			isDirty = true;
		}

		internal bool UpdatePayment(double amount)
		{
			string sqlstr;
			sqlstr = "SELECT receivedAmount FROM invoiceDetails WHERE invoiceNo='" + invoiceToEdit + "'";
			DataSet ds = m1.selectData(sqlstr);
			if(ds != null && ds.Tables[0].Rows.Count > 0)
			{
				amount += double.Parse(ds.Tables[0].Rows[0][0].ToString());
			}

			sqlstr = "UPDATE invoiceDetails SET receivedAmount='" + amount + "' WHERE invoiceNo='" + invoiceToEdit + "'";
			int no_of_rows = m1.Ins_Upd_Del(sqlstr);
			if(no_of_rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
            updateSerNoProducts();
		}

        private void updateSerNoProducts()
        {
            int serNo = 1;
            string proDes = String.Empty;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (serNo == dgvProducts.Rows.Count)
                    break;
                row.Cells["colSerNo"].Value = (serNo++).ToString();
            }
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateSerNoProducts();
            calculateTotals();
        }

		private void Invoice_ResizeEnd(object sender, EventArgs e)
		{
			gbBilling.Size = gbShipping.Size = new Size((int)(this.Size.Width / 2) - 25, gbShipping.Size.Height);

			tlpTotals.Size = new Size(this.Size.Width - 33, tlpTotals.Height);
			gbInvoice.Size = new Size(this.Size.Width - 43, gbInvoice.Height);
			gbAddCharge.Size = new Size(this.Size.Width - 43, gbAddCharge.Height);



			Padding margin = flpPanelButtons.Controls[0].Margin;
			margin.Left = (int)flpPanelButtons.Size.Width / 2 - flpPanelButtons.Controls[0].Width;
			flpPanelButtons.Controls[0].Margin = margin;
		}

		private bool ValidateData()
		{
			bool invoiceNo = !String.IsNullOrWhiteSpace(tbInvoiceNum.Text);
			bool name = !String.IsNullOrWhiteSpace(tbShipName.Text);
			bool address = !String.IsNullOrWhiteSpace(tbShipAddress.Text);
			bool gstin = !String.IsNullOrWhiteSpace(tbShipGstin.Text) && tbShipGstin.Text.Length == 15;
			bool state = !String.IsNullOrWhiteSpace(tbShipState.Text);
			bool code = !String.IsNullOrWhiteSpace(tbShipCode.Text);
			bool city = !String.IsNullOrWhiteSpace(tbShipCity.Text);
			bool pin = !String.IsNullOrWhiteSpace(tbShipPin.Text);

			bool result = true;

			if(!invoiceNo)
			{
				errorProviderTextBox.SetError(tbInvoiceNum, "Please enter invoice number.");
				result = false;
			}
			if (!name)
			{
				errorProviderTextBox.SetError(tbShipName, "Please enter consignee name.");
				result = false;
			}
			if (!address)
			{
				errorProviderTextBox.SetError(tbShipAddress, "Please enter consignee address.");
				result = false;
			}
			if (!gstin)
			{
				errorProviderTextBox.SetError(tbShipGstin, "Please enter consignee GSTIN(15 characters long).");
				result = false;
			}
			if (!state)
			{
				errorProviderTextBox.SetError(tbShipState, "Please enter consignee state.");
				result = false;
			}
			if (!code)
			{
				errorProviderTextBox.SetError(tbShipCode, "Please enter consignee state code.");
				result = false;
			}
			if (!city)
			{
				errorProviderTextBox.SetError(tbShipCity, "Please enter consignee city.");
				result = false;
			}
			if (!pin)
			{
				errorProviderTextBox.SetError(tbShipPin, "Please enter consignee pincode.");
				result = false;
			}
            if (!listOfCustomers.Contains(tbBillName.Text))
            {
                errorProviderTextBox.SetError(tbBillName, "Customer does not exist. Please select correct customer.");
                result = false;
            }

            result = result && validateProducts();

            result = result && validateAddCharges();

			return result;
		}

        private bool validateProducts()
        {
            string quantity;
            int rowCnt = dgvProducts.Rows.Count;
            foreach(DataGridViewRow row in dgvProducts.Rows)
            {
                if (rowCnt == 1)
                    break;
                quantity = row.Cells["colQty"].Value == null ? "0.00" : row.Cells["colQty"].Value.ToString();
                if(quantity == "0.00")
                {
                    MessageBox.Show("Please remove products with 0(zero) quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                rowCnt--;
            }

            return true;
        }

        private bool validateAddCharges()
        {
            getListOfAdditionalCharges();

            for(int i = 0;i < listofAddCharges.Count; i++)
            {
                Tuple<string,string> pair = listofAddCharges[i];
                if(double.Parse(pair.Item2) == 0)
                {
                    listofAddCharges.Remove(pair);
                }
            }

            return true;
        }

		private void tbAll_TextChanged(object sender, EventArgs e)
		{
			bool invoiceNo = !String.IsNullOrWhiteSpace(tbShipName.Text);
			bool name = !String.IsNullOrWhiteSpace(tbShipName.Text);
			bool address = !String.IsNullOrWhiteSpace(tbShipAddress.Text);
			bool gstin = !String.IsNullOrWhiteSpace(tbShipGstin.Text);
			bool state = !String.IsNullOrWhiteSpace(tbShipState.Text);
			bool code = !String.IsNullOrWhiteSpace(tbShipCode.Text);
			bool city = !String.IsNullOrWhiteSpace(tbShipCity.Text);
			bool pin = !String.IsNullOrWhiteSpace(tbShipPin.Text);

			if (!invoiceNo)
			{
				errorProviderTextBox.SetError(tbInvoiceNum, String.Empty);
			}
			if (!name)
			{
				errorProviderTextBox.SetError(tbShipName, String.Empty);
			}
			if (!address)
			{
				errorProviderTextBox.SetError(tbShipAddress, String.Empty);
			}
			if (!gstin)
			{
				errorProviderTextBox.SetError(tbShipGstin, String.Empty);
			}
			if (!state)
			{
				errorProviderTextBox.SetError(tbShipState, String.Empty);
			}
			if (!code)
			{
				errorProviderTextBox.SetError(tbShipCode, String.Empty);
			}
			if (!city)
			{
				errorProviderTextBox.SetError(tbShipCity, String.Empty);
			}
			if (!pin)
			{
				errorProviderTextBox.SetError(tbShipPin, String.Empty);
			}

			isDirty = true;
		}

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            string proDes = row.Cells[1].Value == null ? String.Empty : row.Cells[1].Value.ToString();

            if (String.IsNullOrWhiteSpace(proDes) && !row.IsNewRow)
            {
                dgvProducts.Rows.Remove(row);
            }
        }

        private void btnChallan_Click(object sender, EventArgs e)
        {
            if (baseModel.SelectedCompany.Contains("Parth"))
            {
                parthChallan challan = new parthChallan(tbInvoiceNum.Text);
                challan.MdiParent = this.MdiParent;
                challan.Show();
            }
            else if (baseModel.SelectedCompany.Contains("Industrial Instruments"))
            {
                IICChallan challan = new IICChallan(tbInvoiceNum.Text);
                challan.MdiParent = this.MdiParent;
                challan.Show();
            }
        }

        private void tbPoDate_ValueChanged(object sender, EventArgs e)
        {
            tbPoDate.Format = DateTimePickerFormat.Custom;
            tbPoDate.CustomFormat = "dd/MM/yyyy";
        }
	}
}
