﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class IICChallan : Form
    {
        SqliteDb m1 = new SqliteDb();
        public IICChallan()
        {
            InitializeComponent();
        }

        public IICChallan(string invoiceNo)
        {
            try
            {
                InitializeComponent();
                string sqlstr1 = @"SELECT invoiceDetails.invoiceNo as invoiceNo, invoiceDetails.invoiceDate as invoiceDate, invoiceDetails.shipName as shipName, userDetails.city as city,
                                invoiceDetails.shipGstIn as shipGstIn, invoiceDetails.poNo, invoiceDetails.poDate, invoiceProductDetails.ProductUnit as ProductUnit, 
                                invoiceDetails.shipCode as shipCode, invoiceDetails.totalQnty as totalQnty, invoiceProductDetails.productName as productName,
                                invoiceProductDetails.productCode as productCode, invoiceProductDetails.productQnty as productQnty, customerDetails.custphoneNumber, 
                                customerDetails.custname as custname, customerDetails.custstate as custstate, customerDetails.custPanno as custPanno, customerDetails.shipPanno as shipPanno, 
                                customerDetails.custcode as custcode, customerDetails.custgstin as custgstin, userDetails.name as name, userDetails.companyname as companyname, userDetails.panno as panno,                                 
                                userDetails.email as email, userDetails.phoneNumber as phoneNumber, userDetails.gstin as gstin,  
                                userDetails.code as code, (invoiceDetails.shipAddress || "", "" || invoiceDetails.shipLandmark || "", "" || invoiceDetails.shipCity || ""-"" || invoiceDetails.shipPinCode || "", "" || invoiceDetails.shipState) AS shipAddress,
                                (customerDetails.custaddress || "", "" || customerDetails.custlandmark || "", "" || customerDetails.custcity || ""-"" || customerDetails.custpincode) AS custaddress,
                                (userDetails.address || "", "" || userDetails.landmark || "", "" || userDetails.city || ""-"" || userDetails.pincode || "" , "" || userDetails.state) AS address, invoiceDetails.refNo as refNo, invoiceDetails.transport as transport
                        FROM invoiceDetails 
                        INNER JOIN invoiceProductDetails ON invoiceProductDetails.invoiceId = invoiceDetails.invoiceId 
                        INNER JOIN customerDetails ON customerDetails.custId = invoiceDetails.custId 
                        INNER JOIN userDetails ON userDetails.userId = invoiceDetails.userId                                                  
                        WHERE invoiceDetails.invoiceNo ='" + invoiceNo + "' AND invoiceDetails.userId ='" + BaseModel.Instance.CompanyId + "' AND invoiceDetails.financialYear='" + BaseModel.Instance.FinancialYear + "' AND invoiceDetails.IsActive = 1 ";
                //LEFT JOIN additionalCharges ON additionalCharges.invoiceId = invoiceDetails.invoiceId
                //additionalCharges.chargeName as chargeName, additionalCharges.chargeAmount as chargeAmount
                InvoiceDetails dsVoucher = m1.selectDataAdapter(sqlstr1, 1);

                string sqlstr = "select invoiceId from invoiceDetails WHERE invoiceDetails.invoiceNo ='" + invoiceNo + "' AND invoiceDetails.userId ='" + BaseModel.Instance.CompanyId + "' AND invoiceDetails.financialYear='" +BaseModel.Instance.FinancialYear+ "' AND invoiceDetails.IsActive = 1 LIMIT 1";
                int invoiceId = Convert.ToInt32(m1.scaler(sqlstr));

                sqlstr = "select GROUP_CONCAT(challanNo) FROM invoiceChallanDetails WHERE invoiceId = " + invoiceId + " ";
                string challanNOs = m1.scaler(sqlstr);

                for (int i = 0; i < dsVoucher.Tables[0].Rows.Count; i++)
                {
                    dsVoucher.Tables[0].Rows[i]["challanNo"] = challanNOs;
                }
                
                ReportDocument cryRpt = new IIC_challan();                
                cryRpt.DataSourceConnections.Clear();
                cryRpt.SetDataSource(dsVoucher.Tables[0]);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error :" + e1.Message);
            }
        }
    }
}
