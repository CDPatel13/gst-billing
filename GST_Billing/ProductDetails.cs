using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class ProductDetails : Form
    {
        SqliteDb m1 = new SqliteDb();
        private string prodName;

        public ProductDetails()
        {
            InitializeComponent();
        }

        public ProductDetails(string productName)
        {
            // TODO: Complete member initialization
            this.prodName = productName;
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(prodName))
            {
                getProductDataFromDB(prodName);
                tbProdDes.Enabled = false;
            }
        }

        private void getProductDataFromDB(string prodname)
        {
            DataSet ds = productExists(prodname);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                fillDetailsFromDB(ds);
            }
        }

        private void fillDetailsFromDB(DataSet ds)
        {
            tbProdDes.Text = Convert.ToString(ds.Tables[0].Rows[0]["productName"]);
            tbProdHsnCode.Text = Convert.ToString(ds.Tables[0].Rows[0]["hsnCode"]);
            tbProdRate.Text = Convert.ToString(ds.Tables[0].Rows[0]["productPrice"]);
            tbProdUnit.Text = Convert.ToString(ds.Tables[0].Rows[0]["productUnit"]);
        }

        public DataSet productExists(string name)
        {
            string sqlstr = "SELECT * FROM productDetails WHERE productName='" + name + "'";
            DataSet ds = m1.selectData(sqlstr);
            if (ds.Tables[0].Rows.Count > 0)
                return ds;
            return null;
        }

        private void tbRateQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;
            try
            {
                DataSet ds = productExists(tbProdDes.Text);
                int NoOfRows = 0;
                string sqlstr;
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update existing information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        sqlstr = "UPDATE productDetails set productName='" + tbProdDes.Text + "', hsnCode='" + tbProdHsnCode.Text + "', productPrice='" + tbProdRate.Text +
                                  "', productUnit='" + tbProdUnit.Text + "' WHERE productId='" + ds.Tables[0].Rows[0][0] + "'" ;
                        NoOfRows = m1.Ins_Upd_Del(sqlstr);
                    }
                }
                else 
                { 
                    sqlstr = "INSERT INTO productDetails(productName, hsnCode, productPrice, productUnit)" +
                                    "VALUES('" + tbProdDes.Text + "', '" + tbProdHsnCode.Text + "', " + tbProdRate.Text + ", '" + tbProdUnit.Text + "')";
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
                MessageBox.Show("Error :" + e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateData()
        {
            bool productDes = !String.IsNullOrWhiteSpace(tbProdDes.Text);
            bool unit = !String.IsNullOrWhiteSpace(tbProdUnit.Text);

            bool result = true;
            if(!productDes)
            {
                validatorTextBox.SetError(tbProdDes, "Please enter product description.");
                result = false;
            }
            if(!unit)
            {
                validatorTextBox.SetError(tbProdUnit, "Please enter unit for the product.");
                result = false;
            }

            return result;
        }
    }
}
