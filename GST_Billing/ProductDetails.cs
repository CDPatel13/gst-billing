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

        public ProductDetails()
        {
            InitializeComponent();
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
            try
            {
                int NoOfRows = 0;
                string sqlstr = "INSERT INTO productDetails(productName, hsnCode, productPrice, productUnit)" +
                                "VALUES('" + tbProdDes.Text + "', '" + tbProdHsnCode.Text + "', " + tbProdRate.Text + ", '" + tbProdQty.Text + "')";
                NoOfRows = m1.Ins_Upd_Del(sqlstr);

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
        }
    }
}
