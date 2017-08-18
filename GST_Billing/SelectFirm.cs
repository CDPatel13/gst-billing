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
    public partial class SelectFirm : Form
    {
        AutoCompleteStringCollection autoCompleteStrings = new AutoCompleteStringCollection();
        SqliteDb m1 = new SqliteDb();

        public SelectFirm()
        {
            InitializeComponent();

            updateAutoCompleteFirms();
        }

        private void SelectFirm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            CompanyDetails company = new CompanyDetails();
            company.ShowDialog();

            updateAutoCompleteFirms();
        }

        private void updateAutoCompleteFirms()
        {
            string sqlstr = "SELECT * from userDetails";
            DataSet ds = m1.selectData(sqlstr);

            autoCompleteStrings.Clear();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    autoCompleteStrings.Add((string)row["companyname"]);
                }
                tbSelectedFirm.DataSource = null;
                tbSelectedFirm.DataSource = autoCompleteStrings;
                tbSelectedFirm.SelectedIndex = 0;
            }
            tbSelectedYear.SelectedIndex = 0;
        }

        private void btnEditFirm_Click(object sender, EventArgs e)
        {
            CompanyDetails company = new CompanyDetails(tbSelectedFirm.Text);
            company.ShowDialog();

            updateAutoCompleteFirms();
        }

        private void btnSelectFirm_Click(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * from userDetails WHERE companyname='"+ tbSelectedFirm.Text +"'";
            DataSet ds = m1.selectData(sqlstr);
            Int64 companyId = 0;

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                companyId = Convert.ToInt64(ds.Tables[0].Rows[0]["userId"]);
            }
            BaseModel.Instance.CompanyId = companyId;
            BaseModel.Instance.FinancialYear = tbSelectedYear.Text;

            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void SelectFirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
