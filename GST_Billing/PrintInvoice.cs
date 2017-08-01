using GaneshLogistics.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GST_Billing
{
    public partial class PrintInvoice : Form
    {
        SqliteDb m1 = new SqliteDb();
        public PrintInvoice()
        {
            InitializeComponent();
        }

        public PrintInvoice(string invoiceNo)
        {
            InitializeComponent();
            string sqlstr1 = @"SELECT invoiceDetails.invoiceNo as invoiceNo, invoiceDetails.invoiceDate as invoiceDate, invoiceDetails.shipName as shipName,		
                                invoiceDetails.shipGstIn as shipGstIn, invoiceDetails.shipState as shipState, 
                                invoiceDetails.sgstPercent as sgstPercent, invoiceDetails.cgstPercent as cgstPercent, invoiceDetails.igstPercent as igstPercent,  
                                invoiceDetails.shipCode as shipCode, invoiceDetails.totalQnty as totalQnty, invoiceDetails.totalAmount as totalAmount, invoiceDetails.totaDiscount as totaDiscount, 
                                invoiceDetails.totalTaxAmount as totalTaxAmount, invoiceDetails.totalSGSTAmount as totalSGSTAmount, invoiceDetails.totaCGSTAmount as totaCGSTAmount,
                                invoiceDetails.totalIGSTAmount as totalIGSTAmount, invoiceDetails.totalBillAmount as totalBillAmount, invoiceProductDetails.productName as productName,
                                invoiceProductDetails.productCode as productCode, invoiceProductDetails.productQnty as productQnty, invoiceProductDetails.ProductUnit as ProductUnit,
                                invoiceProductDetails.productUnitPrice as productUnitPrice, invoiceProductDetails.productAmount as productAmount, invoiceProductDetails.productDiscount as productDiscount,
                                invoiceProductDetails.productTaxAmount as productTaxAmount, 
                                customerDetails.custname as custname, customerDetails.custstate as custstate, 
                                customerDetails.custcode as custcode, customerDetails.custgstin as custgstin, userDetails.name as name, userDetails.companyname as companyname, companyname.panno as panno, 
                                userDetails.bankname as bankname, userDetails.branchname as branchname, userDetails.accountno as accountno, userDetails.ifsccode as ifsccode, 
                                userDetails.email as email, userDetails.phoneNumber as phoneNumber, userDetails.gstin as gstin, userDetails.state as state, 
                                userDetails.code as code, (invoiceDetails.shipAddress || "", "" || invoiceDetails.shipLandmark || "", "" || invoiceDetails.shipCity || ""-"" || invoiceDetails.shipPinCode) AS shipAddress,
                                (customerDetails.custaddress || "", "" || customerDetails.custlandmark || "", "" || customerDetails.custcity || ""-"" || customerDetails.custpincode) AS custaddress,
                                (userDetails.address || "", "" || userDetails.landmark || "", "" || userDetails.city || ""-"" || userDetails.pincode) AS address
                        FROM invoiceDetails 
                        INNER JOIN invoiceProductDetails ON invoiceProductDetails.invoiceId = invoiceDetails.invoiceId 
                        INNER JOIN customerDetails ON customerDetails.custId = invoiceDetails.custId 
                        INNER JOIN userDetails ON userDetails.userId = invoiceDetails.userId                          
                        WHERE invoiceDetails.invoiceNo ='" + invoiceNo + "' AND invoiceDetails.IsActive = 1 ";
            //INNER JOIN additionalCharges ON additionalCharges.invoiceId = invoiceDetails.invoiceId
            //additionalCharges.chargeName as chargeName, additionalCharges.chargeAmount as chargeAmount,
            InvoiceDetails dsVoucher = m1.selectDataAdapter(sqlstr1, 1);

            string sqlstr = "select invoiceId from invoiceDetails WHERE invoiceDetails.invoiceNo ='" + invoiceNo + "' AND invoiceDetails.IsActive = 1 LIMIT 1";
            int invoiceId = Convert.ToInt32(m1.scaler(sqlstr));

            sqlstr = "select GROUP_CONCAT(challanNo) FROM invoiceChallanDetails WHERE invoiceId = " + invoiceId + " ";
            string challanNOs = m1.scaler(sqlstr);

            for (int i = 0; i < dsVoucher.Tables[0].Rows.Count; i++)
            {
                dsVoucher.Tables[0].Rows[i]["challanNo"] = challanNOs;
            }

            invoicePrint1.SetDataSource(dsVoucher.Tables[0]);
            //rptVoucherDetails1.Database.Tables[0].SetDataSource(dsVoucher.Tables[0]);
            crystalReportViewer1.ReportSource = invoicePrint1;
            crystalReportViewer1.Refresh();
        }
    }
}
