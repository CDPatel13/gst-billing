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
        private string p;
        private bool _companyExists;

        public Int64 companyId = 0;

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

        public bool CompanyExists
        {
            get { return _companyExists; }
            set { _companyExists = value; }
        }

        public CompanyDetails()
        {
            InitializeComponent();

            CompanyExists = checkCompanyExists();
        }

        private bool checkCompanyExists()
        {
            string sqlstr = "SELECT * from userDetails";
            DataSet ds = m1.selectData(sqlstr);

            //autoCompleteStrings.Clear();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return true;
                //foreach (DataRow row in ds.Tables[0].Rows)
                //{
                //    autoCompleteStrings.Add((string)row["companyname"]);
                //}
                //tbCompanyName.AutoCompleteCustomSource = autoCompleteStrings;

                //this.CompanyName = Convert.ToString(ds.Tables[0].Rows[0]["companyname"]);
                //this.CompanyAddress = Convert.ToString(ds.Tables[0].Rows[0]["address"]) + "," +
                //                      Convert.ToString(ds.Tables[0].Rows[0]["landmark"]) + "," +
                //                      Convert.ToString(ds.Tables[0].Rows[0]["city"]) + "," +
                //                      Convert.ToString(ds.Tables[0].Rows[0]["state"]);
                //this.CompanyEmail = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                //this.CompanyContact = Convert.ToString(ds.Tables[0].Rows[0]["phoneNumber"]);
            }
            return false;
        }

        public CompanyDetails(string companyName)
        {
            InitializeComponent();

            string sqlstr = "SELECT * from userDetails WHERE companyname='"+ companyName +"'";
            DataSet ds = m1.selectData(sqlstr);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                companyId = Convert.ToInt64(ds.Tables[0].Rows[0]["userId"]);
                tbCompanyName.Text = Convert.ToString(ds.Tables[0].Rows[0]["companyname"]);
                tbAddress.Text = Convert.ToString(ds.Tables[0].Rows[0]["address"]);
                tbLandmark.Text = Convert.ToString(ds.Tables[0].Rows[0]["landmark"]);
                tbCity.Text = Convert.ToString(ds.Tables[0].Rows[0]["city"]);
                tbState.Text = Convert.ToString(ds.Tables[0].Rows[0]["state"]);
                tbEmail.Text = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                tbContact.Text = Convert.ToString(ds.Tables[0].Rows[0]["phoneNumber"]);
                tbPinCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["pincode"]);
                tbPinCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["pincode"]);
                tbCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["code"]);
                tbGstin.Text = Convert.ToString(ds.Tables[0].Rows[0]["gstin"]);
                tbPanNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["panno"]);
                tbBankName.Text = Convert.ToString(ds.Tables[0].Rows[0]["bankname"]);
                tbBranch.Text = Convert.ToString(ds.Tables[0].Rows[0]["branchname"]);
                tbAccountNo.Text = Convert.ToString(ds.Tables[0].Rows[0]["accountno"]);
                tbIfscCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["ifsccode"]);
                tbContactPerson.Text = Convert.ToString(ds.Tables[0].Rows[0]["name"]);
            }
        }

        private void CompanyDetails_Load(object sender, EventArgs e)
        {

            int NoOfRows = 0;
            //try
            //{
            //}
            //catch (Exception e1)
            //{
            //    MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void textBox_TextChanged(object sender, System.EventArgs e)
        {
            bool name = !String.IsNullOrWhiteSpace(tbCompanyName.Text);
            bool address = !String.IsNullOrWhiteSpace(tbAddress.Text);
            bool gstin = !String.IsNullOrWhiteSpace(tbGstin.Text);
            bool state = !String.IsNullOrWhiteSpace(tbState.Text);
            bool code = !String.IsNullOrWhiteSpace(tbCode.Text);
            bool pin = !String.IsNullOrWhiteSpace(tbPinCode.Text);
            bool city = !String.IsNullOrWhiteSpace(tbCity.Text);

            if (!name)
            {
                errorProviderTextBox.SetError(tbCompanyName, String.Empty);
            }
            if (!address)
            {
                errorProviderTextBox.SetError(tbAddress, String.Empty);
            }
            if (!gstin)
            {
                errorProviderTextBox.SetError(tbGstin, String.Empty);
            }
            if (!state)
            {
                errorProviderTextBox.SetError(tbState, String.Empty);
            }
            if (!code)
            {
                errorProviderTextBox.SetError(tbCode, String.Empty);
            }
            if (!city)
            {
                errorProviderTextBox.SetError(tbCity, String.Empty);
            }
            if (!pin)
            {
                errorProviderTextBox.SetError(tbPinCode, String.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;
            try
            {
                string sqlstr;
                int NoOfRows = 0;

                if (companyId > 0)
                {
                    sqlstr = "SELECT * from userDetails WHERE userId='" + companyId + "'";
                    DataSet ds = m1.selectData(sqlstr);

                    DialogResult drDuplicateInsert = MessageBox.Show("Do you want to update Company : " + tbCompanyName.Text + " ?"
                        , "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(drDuplicateInsert == DialogResult.Yes)
                    { 
                        sqlstr = "UPDATE userDetails set companyname='" + tbCompanyName.Text + "', name='" + tbContactPerson.Text + 
                                 "', address='" + tbAddress.Text + "', landmark='" + tbLandmark.Text + "', city='" + tbCity.Text + 
                                 "', state='" + tbState.SelectedItem + "', code='" + tbCode.Text + "', pincode='" + tbPinCode.Text + 
                                 "', gstin='" + tbGstin.Text + "', email='" + tbEmail.Text + "', phoneNumber='" + tbContact.Text + 
                                 "', panno='" + tbPanNo.Text + "', bankname='" + tbBankName.Text + "', branchname='" + tbBranch.Text + 
                                 "', accountno='" + tbAccountNo.Text + "', ifsccode='" + tbIfscCode.Text + "' WHERE userId='" + companyId + "'";
                        NoOfRows = m1.Ins_Upd_Del(sqlstr);
                    }
                }
                else
                {
                    sqlstr = "INSERT INTO userDetails(companyname, name, address, landmark, city, state, code, pincode, gstin, email, phoneNumber, panno, bankname, branchname, accountno, ifsccode)" +
                                "VALUES('" + tbCompanyName.Text + "', '" + tbContactPerson.Text + "', '" + tbAddress.Text + "', '" + tbLandmark.Text + "', '" + tbCity.Text + "', '" + tbState.SelectedItem + "','"
                                            + tbCode.Text + "', '" + tbPinCode.Text + "', '" + tbGstin.Text + "', '" + tbEmail.Text + "', '" + tbContact.Text + "', '" + tbPanNo.Text + "','"
                                            + tbBankName.Text + "', '" + tbBranch.Text + "', '" + tbAccountNo.Text + "', '" + tbIfscCode.Text + "')";
                    NoOfRows = m1.Ins_Upd_Del(sqlstr);
                }
                if (NoOfRows > 0)
                {
                    //this.CompanyName = tbCompanyName.Text;
                    //this.CompanyAddress = tbAddress.Text;
                    //this.CompanyEmail = tbEmail.Text;
                    //this.CompanyContact = tbContact.Text;

                    MessageBox.Show("Details saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save details!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    return;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateData()
        {
            bool name = !String.IsNullOrWhiteSpace(tbCompanyName.Text);
            bool address = !String.IsNullOrWhiteSpace(tbAddress.Text);
            bool gstin = !String.IsNullOrWhiteSpace(tbGstin.Text);
            bool state = !String.IsNullOrWhiteSpace(tbState.Text);
            bool code = !String.IsNullOrWhiteSpace(tbCode.Text);
            bool pin = !String.IsNullOrWhiteSpace(tbPinCode.Text);
            bool city = !String.IsNullOrWhiteSpace(tbCity.Text);

            bool result = true;

            if (!name)
            {
                errorProviderTextBox.SetError(tbCompanyName, "Please enter company name.");
                result = false;
            }
            if (!address)
            {
                errorProviderTextBox.SetError(tbAddress, "Please enter company address.");
                result = false;
            }
            if (!gstin)
            {
                errorProviderTextBox.SetError(tbGstin, "Please enter company GSTIN.");
                result = false;
            }
            if (!state)
            {
                errorProviderTextBox.SetError(tbState, "Please enter company state.");
                result = false;
            }
            if (!code)
            {
                errorProviderTextBox.SetError(tbCode, "Please enter company state code.");
                result = false;
            }
            if (!city)
            {
                errorProviderTextBox.SetError(tbCity, "Please enter company city.");
                result = false;
            }
            if (!pin)
            {
                errorProviderTextBox.SetError(tbPinCode, "Please enter company pincode.");
                result = false;
            }

            return result;
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = baseModel.ToPascalCase(tbState.Text);
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
            if (!String.IsNullOrEmpty(tbState.Text))
            {
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
            }
        }

        private void tbCode_Click(object sender, EventArgs e)
        {
            tbCode.SelectAll();
        }
    }
}
