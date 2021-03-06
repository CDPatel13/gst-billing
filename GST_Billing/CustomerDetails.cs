﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaneshLogistics.AppCode;

namespace GST_Billing
{
    public partial class CustomerDetails : Form
    {
        BaseModel baseModel = BaseModel.Instance;
        SqliteDb m1 = new SqliteDb();
        string customerToEdit = String.Empty;

        public CustomerDetails()
        {
            InitializeComponent();
        }

        public CustomerDetails(string customerName)
        {
            customerToEdit = customerName;
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            tbPayment.DataSource = baseModel.paymentTerms.Values.ToList();
            tbShipPayment.DataSource = baseModel.paymentTerms.Values.ToList();
            if (!String.IsNullOrEmpty(customerToEdit))
            {
                getCustomerDataFromDB(customerToEdit);
                tbName.Enabled = false;
            }
            //tbPayment.SelectedIndex = -1;
            //tbShipPayment.SelectedIndex = -1;
        }

        private void tbCode_LeaveFocus(object sender, EventArgs e)
        {
            TextBox tbCode = sender as TextBox;
            int tbStateIndex = tbCode.Parent.Controls.IndexOf(tbCode) - 2;
            ComboBox tbState = tbCode.Parent.Controls[tbStateIndex] as ComboBox;
            int code = !String.IsNullOrEmpty(tbCode.Text) ? int.Parse(tbCode.Text) : 1;
            string codeStr = String.Format("{0:D2}", code);
            if (code > 0 && code < 37)
            {
                string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
                tbState.SelectedIndex = tbState.FindStringExact(state);
            }
            else
            {
                MessageBox.Show("State code must be between 1 and 36.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbState.SelectedIndex = 1;
            }

            syncBillingAndShipping();
        }

        private void tbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tbStateBox = sender as ComboBox;
            GroupBox gbBillShip = tbStateBox.Parent as GroupBox;
            string state = String.Empty;

            if (tbStateBox.Name == "tbState")
            {
                state = baseModel.ToPascalCase(tbState.Text);
            }
            else
            {
                state = baseModel.ToPascalCase(tbShipState.Text);
            }

            if (!String.IsNullOrEmpty(state))
            {
                try
                {
                    gbBillShip.Controls[gbBillShip.Controls.IndexOf(tbStateBox) + 2].Text = baseModel.stateCodes[state];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tbStateBox.Text = String.Empty;
                    tbStateBox.SelectedIndex = -1;
                    gbBillShip.Controls[gbBillShip.Controls.IndexOf(tbStateBox) + 2].Text = String.Empty;
                }
            }
        }

        private void tbCode_Click(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Name;
            if (name == "tbCode")
                tbCode.SelectAll();
            else
                tbShipCode.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            try
            {
                DataSet ds = customerExists(tbName.Text);
                int NoOfRows = 0;
                string sqlstr;
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update existing information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        sqlstr = "UPDATE customerDetails set custname='" + tbName.Text + "', custContactPerson='" + tbContact.Text + "', custaddress='" + tbAddress.Text + "', custlandmark='" + tbLandmark.Text +
                                  "', custcity='" + tbCity.Text + "', custstate='" + tbState.Text + "', custcode='" + tbCode.Text +
                                  "', custpincode='" + tbPinCode.Text + "', custemail='" + tbEmail.Text + "', custphoneNumber='" + tbPhoneNo.Text +
                                  "', custgstin='" + tbGstin.Text + "', custAadharNo='" + tbAadharNo.Text + "', custPanno='" + tbPanNo.Text +
                                  "', custpaymentTermName='" + tbPayment.Text +
                                  "', shipname='" + tbShipName.Text + "', shipContactPerson='" + tbShipContact.Text + "', shipaddress='" + tbShipAddress.Text +
                                  "', shiplandmark='" + tbShipLandmark.Text + "', shipcity='" + tbShipCity.Text + "', shipstate='" + tbShipState.Text +
                                  "', shipcode='" + tbShipCode.Text + "', shippincode='" + tbShipPinCode.Text + "', shipemail='" + tbShipEmail.Text + "', shipphoneNumber='" + tbShipPhone.Text +
                                  "', shipgstin='" + tbShipGstin.Text + "', shipAadharNo='" + tbShipAadhar.Text + "', shipPanno='" + tbShipPanNumber.Text +
                                  "', shippaymentTermName='" + tbShipPayment.Text + "' WHERE custname='" + tbName.Text + "' AND userId='" + baseModel.CompanyId + "'";
                        NoOfRows = m1.Ins_Upd_Del(sqlstr);
                    }
                }
                else
                {
                    sqlstr = "INSERT INTO customerDetails(custname, custContactPerson, custaddress, custlandmark, custcity, custstate, " +
                                "custcode, custpincode, custemail, custphoneNumber, custgstin, custAadharNo, custPanno, custpaymentTermName, " +
                                "shipname, shipContactPerson, shipaddress, shiplandmark, shipcity, shipstate, shipcode, shippincode, " +
                                "shipemail, shipphoneNumber, shipgstin, shipAadharNo, shipPanno, shippaymentTermName, userId)" +
                             "VALUES('" + tbName.Text + "', '" + tbContact.Text + "', '" + tbAddress.Text + "','" + tbLandmark.Text + "', '" + tbCity.Text + "', '" + tbState.Text + "', '" + tbCode.Text + "', '"
                                         + tbPinCode.Text + "', '" + tbEmail.Text + "', '" + tbPhoneNo.Text + "','" + tbGstin.Text + "', '" + tbAadharNo.Text + "', '" + tbPanNo.Text + "', '" + tbPayment.Text + "', '"
                                        + tbShipName.Text + "', '" + tbShipContact.Text + "', '" + tbShipAddress.Text + "','" + tbShipLandmark.Text + "', '" + tbShipCity.Text + "', '" + tbShipState.Text + "', '"
                                        + tbShipCode.Text + "', '" + tbShipPinCode.Text + "', '" + tbShipEmail.Text + "', '" + tbShipPhone.Text + "','" + tbShipGstin.Text + "', '" + tbShipAadhar.Text + "', '"
                                        + tbShipPanNumber.Text + "', '" + tbShipPayment.Text + "', '" + baseModel.CompanyId + "')";
                    NoOfRows = m1.Ins_Upd_Del(sqlstr);
                }
                if (NoOfRows > 0)
                {
                    MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception e1)
            {       
                MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Invoice invoice = new Invoice();
            //invoice.Show();
            //this.Hide();
        }

        private void cbBillShip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBillShip.Checked)
            {
                foreach(Control ctrl in gbShipping.Controls)
                {
                    ctrl.Enabled = false;
                }
                cbBillShip.Enabled = true;
                syncBillingAndShipping();
            }
            else
            {
                foreach (Control ctrl in gbShipping.Controls)
                {
                    ctrl.Enabled = true;
                }
                updateShippingDetailsFromDB();
            }

        }

        private void syncBillingAndShipping()
        {
            if(cbBillShip.Checked)
            { 
                tbShipName.Text = tbName.Text;
                tbShipAddress.Text = tbAddress.Text;
                tbShipPhone.Text = tbPhoneNo.Text;
                tbShipEmail.Text = tbEmail.Text;
                tbShipGstin.Text = tbGstin.Text;
                tbShipState.Text = tbState.Text;
                tbShipCode.Text = tbCode.Text;
                tbShipLandmark.Text = tbLandmark.Text;
                tbShipCity.Text = tbCity.Text;
                tbShipPinCode.Text = tbPinCode.Text;
                tbShipAadhar.Text = tbAadharNo.Text;
                tbShipPanNumber.Text = tbPanNo.Text;
                tbShipPayment.SelectedIndex = tbPayment.SelectedIndex;
                tbShipContact.Text = tbContact.Text;
            }
        }

        private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAlphaNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void getCustomerDataFromDB(string customerName)
        {
            DataSet ds = customerExists(customerName);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                fillDetailsFromDB(ds);
            }
            syncBillingAndShipping();
        }

        public DataSet customerExists(string name)
        {
            string sqlstr = "SELECT * FROM customerDetails WHERE custname ='" + name + "' AND userId='" + baseModel.CompanyId + "'";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }

        private void fillDetailsFromDB(DataSet ds)
        {
            tbName.Text = Convert.ToString(ds.Tables[0].Rows[0]["custname"]);
            tbContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["custContactPerson"]);
            tbAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["custaddress"]);
            tbLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["custlandmark"]);
            tbCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcity"]);
            tbState.Text = Convert.ToString(ds.Tables[0].Rows[0]["custstate"]);
            tbCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["custcode"]);
            tbPinCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["custpincode"]);
            tbEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["custemail"]);
            tbPhoneNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["custphoneNumber"]);
            tbGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["custgstin"]);
            tbAadharNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["custAadharNo"]);
            tbPanNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["custPanno"]);
            tbPayment.Text = Convert.ToString(ds.Tables[0].Rows[0]["custpaymentTermName"]);
            fillShippingDetailsFromDB(ds);
        }

        private void updateShippingDetailsFromDB()
        {
            DataSet ds = customerExists(tbName.Text);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                fillShippingDetailsFromDB(ds);
            }
        }

        private void fillShippingDetailsFromDB(DataSet ds)
        {
            tbShipName.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipname"]);
            tbShipContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipContactPerson"]);
            tbShipAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipaddress"]);
            tbShipLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["shiplandmark"]);
            tbShipCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipcity"]);
            tbShipState.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipstate"]);
            tbShipCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipcode"]);
            tbShipPinCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["shippincode"]);
            tbShipEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipemail"]);
            tbShipPhone.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipphoneNumber"]);
            tbShipGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipgstin"]);
            tbShipAadhar.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipAadharNo"]);
            tbShipPanNumber.Text = Convert.ToString(ds.Tables[0].Rows[0]["shipPanno"]);
            tbShipPayment.Text = Convert.ToString(ds.Tables[0].Rows[0]["shippaymentTermName"]);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool name = String.IsNullOrWhiteSpace(tbName.Text);
            bool address = String.IsNullOrWhiteSpace(tbAddress.Text);
            bool phone = String.IsNullOrWhiteSpace(tbPhoneNo.Text);
            bool gstin = String.IsNullOrWhiteSpace(tbGstin.Text);
            bool state = String.IsNullOrWhiteSpace(tbState.Text);
            bool code = String.IsNullOrWhiteSpace(tbCode.Text);
            bool city = String.IsNullOrWhiteSpace(tbCity.Text);
            bool pin = String.IsNullOrWhiteSpace(tbPinCode.Text);
            if (!name)
            {
                errorProviderBilling.SetError(tbName, String.Empty);
            }
            if (!address)
            {
                errorProviderBilling.SetError(tbAddress, String.Empty);
            }
            if (!phone)
            {
                errorProviderBilling.SetError(tbPhoneNo, String.Empty);
            }
            if (!gstin)
            {
                errorProviderBilling.SetError(tbGstin, String.Empty);
            }
            if (!state)
            {
                errorProviderBilling.SetError(tbState, String.Empty);
            }
            if (!code)
            {
                errorProviderBilling.SetError(tbCode, String.Empty);
            }
            if (!city)
            {
                errorProviderBilling.SetError(tbCity, String.Empty);
            }
            if (!pin)
            {
                errorProviderBilling.SetError(tbPinCode, String.Empty);
            }

            name = !String.IsNullOrWhiteSpace(tbShipName.Text);
            address = !String.IsNullOrWhiteSpace(tbShipAddress.Text);
            phone = !String.IsNullOrWhiteSpace(tbShipPhone.Text);
            gstin = !String.IsNullOrWhiteSpace(tbShipGstin.Text);
            state = !String.IsNullOrWhiteSpace(tbShipState.Text);
            code = !String.IsNullOrWhiteSpace(tbShipCode.Text);
            city = !String.IsNullOrWhiteSpace(tbShipCity.Text);
            pin = !String.IsNullOrWhiteSpace(tbShipPinCode.Text);

            if (!name)
            {
                errorProviderBilling.SetError(tbShipName, String.Empty);
            }
            if (!address)
            {
                errorProviderBilling.SetError(tbShipAddress, String.Empty);
            }
            if (!gstin)
            {
                errorProviderBilling.SetError(tbShipGstin, String.Empty);
            }
            if (!state)
            {
                errorProviderBilling.SetError(tbShipState, String.Empty);
            }
            if (!code)
            {
                errorProviderBilling.SetError(tbShipCode, String.Empty);
            }
            if (!city)
            {
                errorProviderBilling.SetError(tbShipCity, String.Empty);
            }
            if (!pin)
            {
                errorProviderBilling.SetError(tbShipPinCode, String.Empty);
            }

            syncBillingAndShipping();
        }

        private bool ValidateData()
        {
            bool name = !String.IsNullOrWhiteSpace(tbName.Text);
            bool address = !String.IsNullOrWhiteSpace(tbAddress.Text);
            bool phone = !String.IsNullOrWhiteSpace(tbPhoneNo.Text);
            bool gstin = !String.IsNullOrWhiteSpace(tbGstin.Text) && tbGstin.Text.Length == 15;
            bool state = !String.IsNullOrWhiteSpace(tbState.Text);
            bool code = !String.IsNullOrWhiteSpace(tbCode.Text);
            bool city = !String.IsNullOrWhiteSpace(tbCity.Text);
            bool pin = !String.IsNullOrWhiteSpace(tbPinCode.Text);

            bool result = true;

            if (!name)
            {
                errorProviderBilling.SetError(tbName, "Please enter customer name.");
                result = false;
            }
            if (!address)
            {
                errorProviderBilling.SetError(tbAddress, "Please enter customer address.");
                result = false;
            }
            if (!phone)
            {
                errorProviderBilling.SetError(tbPhoneNo, "Please enter customer phone number.");
                result = false;
            }
            if (!gstin)
            {
                errorProviderBilling.SetError(tbGstin, "Please enter customer GSTIN(15 characters long).");
                result = false;
            }
            if (!state)
            {
                errorProviderBilling.SetError(tbState, "Please enter customer state.");
                result = false;
            }
            if (!code)
            {
                errorProviderBilling.SetError(tbCode, "Please enter customer state code.");
                result = false;
            }
            if (!city)
            {
                errorProviderBilling.SetError(tbCity, "Please enter customer city.");
                result = false;
            }
            if (!pin)
            {
                errorProviderBilling.SetError(tbPinCode, "Please enter customer pincode.");
                result = false;
            }

            if(cbBillShip.Checked)
            {
                return result;
            }

            name    = !String.IsNullOrWhiteSpace(tbShipName.Text);
            address = !String.IsNullOrWhiteSpace(tbShipAddress.Text);
            phone   = !String.IsNullOrWhiteSpace(tbShipPhone.Text);
            gstin   = !String.IsNullOrWhiteSpace(tbShipGstin.Text);
            state   = !String.IsNullOrWhiteSpace(tbShipState.Text);
            code    = !String.IsNullOrWhiteSpace(tbShipCode.Text);
            city    = !String.IsNullOrWhiteSpace(tbShipCity.Text);
            pin     = !String.IsNullOrWhiteSpace(tbShipPinCode.Text);

            if (!name)
            {
                errorProviderBilling.SetError(tbShipName, "Please enter consignee name.");
                result = false;
            }
            if (!address)
            {
                errorProviderBilling.SetError(tbShipAddress, "Please enter consignee address.");
                result = false;
            }
            if (!phone)
            {
                errorProviderBilling.SetError(tbShipPhone, "Please enter consignee phone number.");
                result = false;
            }
            if (!gstin)
            {
                errorProviderBilling.SetError(tbShipGstin, "Please enter consignee GSTIN.");
                result = false;
            }
            if (!state)
            {
                errorProviderBilling.SetError(tbShipState, "Please enter consignee state.");
                result = false;
            }
            if (!code)
            {
                errorProviderBilling.SetError(tbShipCode, "Please enter consignee state code.");
                result = false;
            }
            if (!city)
            {
                errorProviderBilling.SetError(tbShipCity, "Please enter consignee city.");
                result = false;
            }
            if (!pin)
            {
                errorProviderBilling.SetError(tbShipPinCode, "Please enter consignee pincode.");
                result = false;
            }

            return result;
        }
    }
}
