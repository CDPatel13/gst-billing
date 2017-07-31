using System;
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bool name = !String.IsNullOrEmpty(tbName.Text) && !String.IsNullOrWhiteSpace(tbName.Text) &&
                        !String.IsNullOrEmpty(tbShipName.Text) && !String.IsNullOrWhiteSpace(tbShipName.Text);
            bool address = !String.IsNullOrEmpty(tbAddress.Text) && !String.IsNullOrWhiteSpace(tbAddress.Text) &&
                           !String.IsNullOrEmpty(tbShipAddress.Text) && !String.IsNullOrWhiteSpace(tbShipAddress.Text);
            bool phone = !String.IsNullOrEmpty(tbPhoneNo.Text) && !String.IsNullOrWhiteSpace(tbPhoneNo.Text) &&
                           !String.IsNullOrEmpty(tbShipPhone.Text) && !String.IsNullOrWhiteSpace(tbShipPhone.Text);
            bool gstin = !String.IsNullOrEmpty(tbGstin.Text) && !String.IsNullOrWhiteSpace(tbGstin.Text) &&
                         !String.IsNullOrEmpty(tbShipGstin.Text) && !String.IsNullOrWhiteSpace(tbShipGstin.Text);
            bool state = !String.IsNullOrEmpty(tbState.Text) && !String.IsNullOrWhiteSpace(tbState.Text) &&
                         !String.IsNullOrEmpty(tbShipState.Text) && !String.IsNullOrWhiteSpace(tbShipState.Text);
            bool code = !String.IsNullOrEmpty(tbCode.Text) && !String.IsNullOrWhiteSpace(tbCode.Text) &&
                        !String.IsNullOrEmpty(tbShipCode.Text) && !String.IsNullOrWhiteSpace(tbShipCode.Text);

            if (name && address && phone && gstin && state && code && tbGstin.Text.Length == 15 && tbShipGstin.Text.Length == 15)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
            syncBillingAndShipping();
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
                MessageBox.Show("State code must be between 1 and 36.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    tbStateBox.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    btnSave.Enabled = false;
                    tbStateBox.BackColor = Color.Tomato;
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
                                  "', custpincode=" + tbPinCode.Text + ", custemail='" + tbEmail.Text + "', custphoneNumber=" + tbPhoneNo.Text +
                                  ", custgstin='" + tbGstin.Text + "', custAadharNo='" + tbAadharNo.Text + "', custPanno='" + tbPanNo.Text +
                                  "', custpaymentTermName='" + tbPayment.Text +
                                  "', shipname='" + tbShipName.Text + "', shipContactPerson='" + tbShipContact.Text + "', shipaddress='" + tbShipAddress.Text +
                                  "', shiplandmark='" + tbShipLandmark.Text + "', shipcity='" + tbShipCity.Text + "', shipstate='" + tbShipState.Text +
                                  "', shipcode='" + tbShipCode.Text + "', shippincode=" + tbShipPinCode.Text + ", shipemail='" + tbShipEmail.Text + "', shipphoneNumber='" + tbShipPhone.Text +
                                  "', shipgstin='" + tbShipGstin.Text + "', shipAadharNo='" + tbShipAadhar.Text + "', shipPanno='" + tbShipPanNumber.Text +
                                  "', shippaymentTermName='" + tbShipPayment.Text + "' where custname='" + tbName.Text + "'";
                        NoOfRows = m1.Ins_Upd_Del(sqlstr);
                    }
                }
                else
                {
                    sqlstr = "INSERT INTO customerDetails(custname, custContactPerson, custaddress, custlandmark, custcity, custstate, " +
                                "custcode, custpincode, custemail, custphoneNumber, custgstin, custAadharNo, custPanno, custpaymentTermName, " +
                                "shipname, shipContactPerson, shipaddress, shiplandmark, shipcity, shipstate, shipcode, shippincode, " +
                                "shipemail, shipphoneNumber, shipgstin, shipAadharNo, shipPanno, shippaymentTermName)" +
                             "VALUES('" + tbName.Text + "', '" + tbContact.Text + "', '" + tbAddress.Text + "','" + tbLandmark.Text + "', '" + tbCity.Text + "', '" + tbState.Text + "', '" + tbCode.Text + "', "
                                         + tbPinCode.Text + ", '" + tbEmail.Text + "', " + tbPhoneNo.Text + ",'" + tbGstin.Text + "', '" + tbAadharNo.Text + "', '" + tbPanNo.Text + "', '" + tbPayment.Text + "', '"
                                        + tbShipName.Text + "', '" + tbShipContact.Text + "', '" + tbShipAddress.Text + "','" + tbShipLandmark.Text + "', '" + tbShipCity.Text + "', '" + tbShipState.Text + "', '"
                                        + tbShipCode.Text + "', '" + tbShipPinCode.Text + "', '" + tbShipEmail.Text + "', " + tbShipPhone.Text + ",'" + tbShipGstin.Text + "', '" + tbShipAadhar.Text + "', '"
                                        + tbShipPanNumber.Text + "', '" + tbShipPayment.Text + "')";
                    NoOfRows = m1.Ins_Upd_Del(sqlstr);
                }
                if (NoOfRows > 0)
                {
                    MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }

            //Invoice invoice = new Invoice();
            //invoice.Show();
            //this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = customerExists(tbName.Text);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
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
                else
                {
                    MessageBox.Show("No records found", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
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
                tbShipPayment.Text = tbPayment.Text;
                tbShipContact.Text = tbContact.Text;
            }
        }



        private DataSet customerExists(string name)
        {
            string sqlstr = "SELECT * FROM customerDetails WHERE custname ='" + name + "'";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
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


    }
}
