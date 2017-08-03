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
    public partial class CompanyDetails : Form
    {
        BaseModel baseModel = BaseModel.Instance;
        SqliteDb m1 = new SqliteDb();

        AutoCompleteStringCollection autoCompleteStrings = new AutoCompleteStringCollection();
        private string _companyName;
        private string _companyAddress;
        private string _companyEmail;
        private string _companyContact;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        public string CompanyEmail
        {
            get { return _companyEmail; }
            set { _companyEmail = value; }
        }

        public string CompanyContact
        {
            get { return _companyContact; }
            set { _companyContact = value; }
        }

        public CompanyDetails()
        {
            InitializeComponent();

            string sqlstr = "SELECT * from userDetails";
            DataSet ds = m1.selectData(sqlstr);

            autoCompleteStrings.Clear();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    autoCompleteStrings.Add((string)row["companyname"]);
                }
                tbCompanyName.AutoCompleteCustomSource = autoCompleteStrings;

                this.CompanyName = Convert.ToString(ds.Tables[0].Rows[0]["companyname"]);
                this.CompanyAddress = Convert.ToString(ds.Tables[0].Rows[0]["address"]) + "," + 
                                      Convert.ToString(ds.Tables[0].Rows[0]["landmark"]) + "," + 
                                      Convert.ToString(ds.Tables[0].Rows[0]["city"]) + "," + 
                                      Convert.ToString(ds.Tables[0].Rows[0]["state"]);
                this.CompanyEmail = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                this.CompanyContact = Convert.ToString(ds.Tables[0].Rows[0]["phoneNumber"]);
            }
        }

        private void CompanyDetails_Load(object sender, EventArgs e)
        {

            int NoOfRows = 0;
            try
            {
                string sqlstr = "SELECT * FROM userDetails";
                DataSet ds = m1.selectData(sqlstr);

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    tbCompanyName.Text = Convert.ToString(ds.Tables[0].Rows[0]["companyname"]);
                    tbContactPerson.Text = Convert.ToString(ds.Tables[0].Rows[0]["name"]);
                    tbAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["address"]);
                    tbLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["landmark"]);
                    tbCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["city"]);
                    cbState.Text = Convert.ToString(ds.Tables[0].Rows[0]["state"]);
                    tbCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["code"]);
                    tbPinCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["pincode"]);
                    tbEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                    tbContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["phoneNumber"]);
                    tbGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["gstin"]);
                    tbPanNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["panno"]);
                    tbBankName.Text = Convert.ToString(ds.Tables[0].Rows[0]["bankname"]);
                    tbBranch.Text = Convert.ToString(ds.Tables[0].Rows[0]["branchname"]);
                    tbAccountNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["accountno"]);
                    tbIfscCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["ifsccode"]);
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

        void textBox_TextChanged(object sender, System.EventArgs e)
        {
            bool name = !String.IsNullOrEmpty(tbCompanyName.Text) && !String.IsNullOrWhiteSpace(tbCompanyName.Text);
            bool address = !String.IsNullOrEmpty(tbAddress.Text) && !String.IsNullOrWhiteSpace(tbAddress.Text);
            bool contact = !String.IsNullOrEmpty(tbContact.Text) && !String.IsNullOrWhiteSpace(tbContact.Text);
            bool gstin = !String.IsNullOrEmpty(tbGstin.Text) && !String.IsNullOrWhiteSpace(tbGstin.Text);
            bool state = !String.IsNullOrEmpty(cbState.Text) && !String.IsNullOrWhiteSpace(cbState.Text);
            bool code = !String.IsNullOrEmpty(tbCode.Text) && !String.IsNullOrWhiteSpace(tbCode.Text);

            if (name && address && contact && gstin && state && code && tbGstin.Text.Length == 15)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstr = "SELECT * from userDetails";
                DataSet ds = m1.selectData(sqlstr);
                int NoOfRows = 0;

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    NoOfRows = m1.Ins_Upd_Del("DELETE FROM userDetails");
                }
                sqlstr = "INSERT INTO userDetails(companyname, name, address, landmark, city, state, code, pincode, gstin, email, phoneNumber, panno, bankname, branchname, accountno, ifsccode)" +
                                "VALUES('" + tbCompanyName.Text + "', '" + tbContactPerson.Text + "', '" + tbAddress.Text + "', '" + tbLandmark.Text + "', '" + tbCity.Text + "', '" + cbState.SelectedItem + "','"
                                            + tbCode.Text + "', " + tbPinCode.Text + ", '" + tbGstin.Text + "', '" + tbEmail.Text + "', " + tbContact.Text + ", '" + tbPanNo.Text + "','"
                                            + tbBankName.Text + "', '" + tbBranch.Text + "', " + tbAccountNo.Text + ", '" + tbIfscCode.Text + "')";
                NoOfRows = m1.Ins_Upd_Del(sqlstr);

                if (NoOfRows > 0)
                {
                    this.CompanyName = tbCompanyName.Text;
                    this.CompanyAddress = tbAddress.Text;
                    this.CompanyEmail = tbEmail.Text;
                    this.CompanyContact = tbContact.Text;

                    MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK);
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = baseModel.ToPascalCase(cbState.Text);
            tbCode.Text = baseModel.stateCodes[state];
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCode_LeaveFocus(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbState.Text))
            {
                int code = !String.IsNullOrEmpty(tbCode.Text) ? int.Parse(tbCode.Text) : 1;
                string codeStr = String.Format("{0:D2}", code);
                if (code > 0 && code < 37)
                {
                    string state = baseModel.stateCodes.FirstOrDefault(x => x.Value == codeStr).Key;
                    cbState.SelectedIndex = cbState.FindStringExact(state);
                }
                else
                {
                    MessageBox.Show("State code must be between 1 and 36.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbState.SelectedIndex = 1;
                }
            }
        }

        private void tbCode_Click(object sender, EventArgs e)
        {
            tbCode.SelectAll();
        }
    }
}
