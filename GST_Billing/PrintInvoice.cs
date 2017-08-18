using CrystalDecisions.CrystalReports.Engine;
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

        public PrintInvoice(string invoiceNo, int invoiceType)
        {
            try
            {
                InitializeComponent();
                string strInvoiceType = "";
                if (invoiceType == 1)
                {
                    strInvoiceType = "Original Invoice";
                }
                else
                {
                    strInvoiceType = "Duplicate Invoice";
                }
                string sqlstr1 = @"SELECT invoiceDetails.invoiceNo as invoiceNo, invoiceDetails.invoiceDate as invoiceDate, invoiceDetails.shipName as shipName, userDetails.city as city,
                                invoiceDetails.shipGstIn as shipGstIn, invoiceDetails.shipState as shipState, invoiceDetails.totalTaxColAmt as totalTaxColAmt, invoiceDetails.poNo, invoiceDetails.poDate, 
                                (invoiceDetails.sgstPercent || "" %"") AS sgstPercent, (invoiceDetails.cgstPercent || "" %"") AS cgstPercent, (invoiceDetails.igstPercent || "" %"") AS igstPercent, invoiceDetails.termName as termName, 
                                invoiceDetails.shipCode as shipCode, invoiceDetails.totalQnty as totalQnty, invoiceDetails.totalAmount as totalAmount, invoiceDetails.totaDiscount as totaDiscount, 
                                invoiceDetails.totalTaxAmount as totalTaxAmount, invoiceDetails.totalSGSTAmount as totalSGSTAmount, invoiceDetails.totaCGSTAmount as totaCGSTAmount,
                                invoiceDetails.totalIGSTAmount as totalIGSTAmount, invoiceDetails.totalBillAmount as totalBillAmount, invoiceProductDetails.productName as productName,
                                invoiceProductDetails.productCode as productCode, invoiceProductDetails.productQnty as productQnty, invoiceProductDetails.ProductUnit as ProductUnit,
                                invoiceProductDetails.productUnitPrice as productUnitPrice, invoiceProductDetails.productAmount as productAmount, invoiceProductDetails.productDiscount as productDiscount,
                                invoiceProductDetails.productTaxAmount as productTaxAmount, customerDetails.custphoneNumber, 
                                customerDetails.custname as custname, customerDetails.custstate as custstate, customerDetails.custPanno as custPanno, customerDetails.shipPanno as shipPanno, 
                                customerDetails.custcode as custcode, customerDetails.custgstin as custgstin, userDetails.name as name, userDetails.companyname as companyname, userDetails.panno as panno, 
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
                //LEFT JOIN additionalCharges ON additionalCharges.invoiceId = invoiceDetails.invoiceId
                //additionalCharges.chargeName as chargeName, additionalCharges.chargeAmount as chargeAmount
                InvoiceDetails dsVoucher = m1.selectDataAdapter(sqlstr1, 1);

                string sqlstr = "select invoiceId from invoiceDetails WHERE invoiceDetails.invoiceNo ='" + invoiceNo + "' AND invoiceDetails.IsActive = 1 LIMIT 1";
                int invoiceId = Convert.ToInt32(m1.scaler(sqlstr));

                sqlstr = "select GROUP_CONCAT(challanNo) FROM invoiceChallanDetails WHERE invoiceId = " + invoiceId + " ";
                string challanNOs = m1.scaler(sqlstr);

                for (int i = 0; i < dsVoucher.Tables[0].Rows.Count; i++)
                {
                    dsVoucher.Tables[0].Rows[i]["challanNo"] = challanNOs;
                    dsVoucher.Tables[0].Rows[i]["invoiceType"] = strInvoiceType;
                }

                sqlstr = "select chargeName, CAST(chargeAmount as decimal) as chargeAmount FROM additionalCharges WHERE invoiceId = " + invoiceId + "";
                InvoiceDetails dsAddCharges = m1.selectDataAdapter(sqlstr, 1);
                
                //System.Data.DataColumn newColumn = new System.Data.DataColumn("totalAdditionalCharge", typeof(System.String));                                
                if (dsAddCharges.Tables[0].Rows.Count > 0)
                {
                    //object sumObject;
                    //sumObject = dsAddCharges.Tables[0].Compute("Sum(chargeAmount)", string.Empty);
                    //newColumn.DefaultValue = sumObject.ToString();

                    var sumObject = dsAddCharges.Tables[0].AsEnumerable().Sum(x => Convert.ToDecimal(x["chargeAmount"]));
                    foreach (DataRow row in dsVoucher.Tables[0].Rows)
                    {
                        row["totalAdditionalCharge"] = sumObject.ToString();
                    }
                    //dsVoucher.Tables[0].Columns["totalAdditionalCharge"].DefaultValue = sumObject.ToString();
                }
                else
                {
                    foreach (DataRow row in dsVoucher.Tables[0].Rows)
                    {
                        row["totalAdditionalCharge"] = "0";
                    }
                }
                //dsVoucher.Tables[0].Columns.Add(newColumn);

                ReportDocument cryRpt = new invoicePrint();
                //cryRpt.Load("D:\\Nirav\\gst-billing\\GST_Billing\\invoicePrint.rpt");
                //cryRpt.Load("C:/MainReport.rpt");
                cryRpt.DataSourceConnections.Clear();
                cryRpt.SetDataSource(dsVoucher.Tables[0]);
                cryRpt.Subreports[0].DataSourceConnections.Clear();
                /*
                            if (dsAddCharges.Tables[0].Rows.Count < 1)
                            {
                                cryRpt.ReportDefinition.Sections["PageFooterSection2"].SectionFormat.EnableSuppress = true;
                            }
                            else
                            {
                                cryRpt.ReportDefinition.Sections["PageFooterSection2"].SectionFormat.EnableSuppress = false;
                
                            }   
                 */
                cryRpt.Subreports[0].SetDataSource(dsAddCharges.Tables[0]);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();

                //invoicePrint1.SetDataSource(dsVoucher.Tables[0]);
                //rptVoucherDetails1.Database.Tables[0].SetDataSource(dsVoucher.Tables[0]);
                //crystalReportViewer1.ReportSource = invoicePrint1;
                //crystalReportViewer1.Refresh();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
        }
    }
}
