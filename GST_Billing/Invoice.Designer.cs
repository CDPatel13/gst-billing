namespace GST_Billing
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.gbBilling = new System.Windows.Forms.GroupBox();
            this.cbBillName = new System.Windows.Forms.ComboBox();
            this.cbBillState = new System.Windows.Forms.ComboBox();
            this.lbBillCode = new System.Windows.Forms.Label();
            this.tbBillCode = new System.Windows.Forms.TextBox();
            this.lbBillState = new System.Windows.Forms.Label();
            this.lbBillGstin = new System.Windows.Forms.Label();
            this.tbBillGstin = new System.Windows.Forms.TextBox();
            this.tbBillAddress = new System.Windows.Forms.TextBox();
            this.lbBillAddress = new System.Windows.Forms.Label();
            this.lbBillName = new System.Windows.Forms.Label();
            this.cbBillAndShip = new System.Windows.Forms.CheckBox();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.tableLayoutInvoice = new System.Windows.Forms.TableLayoutPanel();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.tbInvoiceNum = new System.Windows.Forms.TextBox();
            this.lbInvoiceDate = new System.Windows.Forms.Label();
            this.tbInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.gbShipping = new System.Windows.Forms.GroupBox();
            this.cbShipState = new System.Windows.Forms.ComboBox();
            this.lbShipCode = new System.Windows.Forms.Label();
            this.tbShipCode = new System.Windows.Forms.TextBox();
            this.lbShipState = new System.Windows.Forms.Label();
            this.lbShipGstin = new System.Windows.Forms.Label();
            this.tbShipGstin = new System.Windows.Forms.TextBox();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lbShipAddress = new System.Windows.Forms.Label();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.lbShipName = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colSerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHsnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxableVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPanelTotals = new System.Windows.Forms.TableLayoutPanel();
            this.lbGST = new System.Windows.Forms.Label();
            this.lbTaxableVal = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbFinalTotal = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbTotalDiscount = new System.Windows.Forms.Label();
            this.lbTotalTaxVal = new System.Windows.Forms.Label();
            this.lbTotalGst = new System.Windows.Forms.Label();
            this.lbTotalAll = new System.Windows.Forms.Label();
            this.lbTotalFinal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flwPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAddCharge = new System.Windows.Forms.GroupBox();
            this.tblPnlAddCharge = new System.Windows.Forms.TableLayoutPanel();
            this.lbAddCharge = new System.Windows.Forms.Label();
            this.tbAddCharge = new System.Windows.Forms.TextBox();
            this.btnAddCharge = new System.Windows.Forms.Button();
            this.lbSgst = new System.Windows.Forms.Label();
            this.tbSgst = new System.Windows.Forms.TextBox();
            this.lbCgst = new System.Windows.Forms.Label();
            this.tbCgst = new System.Windows.Forms.TextBox();
            this.lbIgst = new System.Windows.Forms.Label();
            this.tbIgst = new System.Windows.Forms.TextBox();
            this.gbBilling.SuspendLayout();
            this.gbInvoice.SuspendLayout();
            this.tableLayoutInvoice.SuspendLayout();
            this.gbShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tblPanelTotals.SuspendLayout();
            this.flwPanelButtons.SuspendLayout();
            this.gbAddCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBilling
            // 
            this.gbBilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBilling.Controls.Add(this.cbBillName);
            this.gbBilling.Controls.Add(this.cbBillState);
            this.gbBilling.Controls.Add(this.lbBillCode);
            this.gbBilling.Controls.Add(this.tbBillCode);
            this.gbBilling.Controls.Add(this.lbBillState);
            this.gbBilling.Controls.Add(this.lbBillGstin);
            this.gbBilling.Controls.Add(this.tbBillGstin);
            this.gbBilling.Controls.Add(this.tbBillAddress);
            this.gbBilling.Controls.Add(this.lbBillAddress);
            this.gbBilling.Controls.Add(this.lbBillName);
            this.gbBilling.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gbBilling.Location = new System.Drawing.Point(12, 92);
            this.gbBilling.MaximumSize = new System.Drawing.Size(340, 200);
            this.gbBilling.MinimumSize = new System.Drawing.Size(292, 200);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(323, 200);
            this.gbBilling.TabIndex = 5;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "Billing Details";
            // 
            // cbBillName
            // 
            this.cbBillName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBillName.DropDownHeight = 100;
            this.cbBillName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBillName.FormattingEnabled = true;
            this.cbBillName.IntegralHeight = false;
            this.cbBillName.Location = new System.Drawing.Point(78, 20);
            this.cbBillName.Name = "cbBillName";
            this.cbBillName.Size = new System.Drawing.Size(238, 25);
            this.cbBillName.TabIndex = 2;
            this.cbBillName.SelectedIndexChanged += new System.EventHandler(this.cbBillName_SelectedIndexChanged);
            // 
            // cbBillState
            // 
            this.cbBillState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBillState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBillState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBillState.Enabled = false;
            this.cbBillState.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBillState.FormattingEnabled = true;
            this.cbBillState.Items.AddRange(new object[] {
            "Andaman and Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chattisgarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Lakshadweep Islands",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Pondicherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.cbBillState.Location = new System.Drawing.Point(78, 167);
            this.cbBillState.Name = "cbBillState";
            this.cbBillState.Size = new System.Drawing.Size(131, 25);
            this.cbBillState.TabIndex = 5;
            // 
            // lbBillCode
            // 
            this.lbBillCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillCode.AutoSize = true;
            this.lbBillCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillCode.Location = new System.Drawing.Point(215, 171);
            this.lbBillCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbBillCode.Name = "lbBillCode";
            this.lbBillCode.Size = new System.Drawing.Size(45, 16);
            this.lbBillCode.TabIndex = 18;
            this.lbBillCode.Text = "Code";
            // 
            // tbBillCode
            // 
            this.tbBillCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillCode.Enabled = false;
            this.tbBillCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillCode.Location = new System.Drawing.Point(266, 166);
            this.tbBillCode.MaximumSize = new System.Drawing.Size(51, 26);
            this.tbBillCode.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbBillCode.Name = "tbBillCode";
            this.tbBillCode.Size = new System.Drawing.Size(51, 26);
            this.tbBillCode.TabIndex = 6;
            // 
            // lbBillState
            // 
            this.lbBillState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillState.AutoSize = true;
            this.lbBillState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillState.Location = new System.Drawing.Point(6, 172);
            this.lbBillState.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbBillState.Name = "lbBillState";
            this.lbBillState.Size = new System.Drawing.Size(44, 16);
            this.lbBillState.TabIndex = 15;
            this.lbBillState.Text = "State";
            // 
            // lbBillGstin
            // 
            this.lbBillGstin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillGstin.AutoSize = true;
            this.lbBillGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillGstin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillGstin.Location = new System.Drawing.Point(6, 140);
            this.lbBillGstin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbBillGstin.Name = "lbBillGstin";
            this.lbBillGstin.Size = new System.Drawing.Size(50, 16);
            this.lbBillGstin.TabIndex = 14;
            this.lbBillGstin.Text = "GSTIN";
            // 
            // tbBillGstin
            // 
            this.tbBillGstin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillGstin.Enabled = false;
            this.tbBillGstin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillGstin.Location = new System.Drawing.Point(78, 135);
            this.tbBillGstin.Name = "tbBillGstin";
            this.tbBillGstin.Size = new System.Drawing.Size(239, 25);
            this.tbBillGstin.TabIndex = 4;
            // 
            // tbBillAddress
            // 
            this.tbBillAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillAddress.Enabled = false;
            this.tbBillAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillAddress.Location = new System.Drawing.Point(78, 52);
            this.tbBillAddress.Multiline = true;
            this.tbBillAddress.Name = "tbBillAddress";
            this.tbBillAddress.Size = new System.Drawing.Size(239, 77);
            this.tbBillAddress.TabIndex = 3;
            // 
            // lbBillAddress
            // 
            this.lbBillAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillAddress.AutoSize = true;
            this.lbBillAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillAddress.Location = new System.Drawing.Point(6, 57);
            this.lbBillAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbBillAddress.Name = "lbBillAddress";
            this.lbBillAddress.Size = new System.Drawing.Size(66, 16);
            this.lbBillAddress.TabIndex = 10;
            this.lbBillAddress.Text = "Address";
            // 
            // lbBillName
            // 
            this.lbBillName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillName.AutoSize = true;
            this.lbBillName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillName.Location = new System.Drawing.Point(6, 25);
            this.lbBillName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbBillName.Name = "lbBillName";
            this.lbBillName.Size = new System.Drawing.Size(47, 16);
            this.lbBillName.TabIndex = 1;
            this.lbBillName.Text = "Name";
            // 
            // cbBillAndShip
            // 
            this.cbBillAndShip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBillAndShip.AutoSize = true;
            this.cbBillAndShip.Checked = true;
            this.cbBillAndShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBillAndShip.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBillAndShip.Location = new System.Drawing.Point(358, 300);
            this.cbBillAndShip.Name = "cbBillAndShip";
            this.cbBillAndShip.Size = new System.Drawing.Size(248, 20);
            this.cbBillAndShip.TabIndex = 12;
            this.cbBillAndShip.Text = "Shipping details same as billing";
            this.cbBillAndShip.UseVisualStyleBackColor = true;
            this.cbBillAndShip.CheckedChanged += new System.EventHandler(this.cbBillAndShip_CheckedChanged);
            // 
            // gbInvoice
            // 
            this.gbInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInvoice.Controls.Add(this.tableLayoutInvoice);
            this.gbInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gbInvoice.Location = new System.Drawing.Point(12, 12);
            this.gbInvoice.MaximumSize = new System.Drawing.Size(686, 74);
            this.gbInvoice.MinimumSize = new System.Drawing.Size(591, 74);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Size = new System.Drawing.Size(669, 74);
            this.gbInvoice.TabIndex = 0;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Tax Invoice";
            // 
            // tableLayoutInvoice
            // 
            this.tableLayoutInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutInvoice.ColumnCount = 4;
            this.tableLayoutInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutInvoice.Controls.Add(this.lbInvoiceNo, 0, 0);
            this.tableLayoutInvoice.Controls.Add(this.tbInvoiceNum, 1, 0);
            this.tableLayoutInvoice.Controls.Add(this.lbInvoiceDate, 2, 0);
            this.tableLayoutInvoice.Controls.Add(this.tbInvoiceDate, 3, 0);
            this.tableLayoutInvoice.Location = new System.Drawing.Point(8, 25);
            this.tableLayoutInvoice.Name = "tableLayoutInvoice";
            this.tableLayoutInvoice.RowCount = 1;
            this.tableLayoutInvoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutInvoice.Size = new System.Drawing.Size(655, 36);
            this.tableLayoutInvoice.TabIndex = 4;
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.AutoSize = true;
            this.lbInvoiceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoiceNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInvoiceNo.Location = new System.Drawing.Point(3, 0);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(138, 36);
            this.lbInvoiceNo.TabIndex = 0;
            this.lbInvoiceNo.Text = "Invoice Number";
            this.lbInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvoiceNum
            // 
            this.tbInvoiceNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInvoiceNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceNum.Location = new System.Drawing.Point(147, 3);
            this.tbInvoiceNum.Name = "tbInvoiceNum";
            this.tbInvoiceNum.Size = new System.Drawing.Size(177, 25);
            this.tbInvoiceNum.TabIndex = 0;
            // 
            // lbInvoiceDate
            // 
            this.lbInvoiceDate.AutoSize = true;
            this.lbInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInvoiceDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInvoiceDate.Location = new System.Drawing.Point(330, 0);
            this.lbInvoiceDate.Name = "lbInvoiceDate";
            this.lbInvoiceDate.Size = new System.Drawing.Size(138, 36);
            this.lbInvoiceDate.TabIndex = 2;
            this.lbInvoiceDate.Text = "Invoice Date";
            this.lbInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvoiceDate
            // 
            this.tbInvoiceDate.CalendarFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceDate.CustomFormat = "dd /MMM/ yyyy";
            this.tbInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInvoiceDate.Font = new System.Drawing.Font("Arial", 10F);
            this.tbInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbInvoiceDate.Location = new System.Drawing.Point(474, 3);
            this.tbInvoiceDate.Name = "tbInvoiceDate";
            this.tbInvoiceDate.Size = new System.Drawing.Size(178, 23);
            this.tbInvoiceDate.TabIndex = 1;
            // 
            // gbShipping
            // 
            this.gbShipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbShipping.Controls.Add(this.cbShipState);
            this.gbShipping.Controls.Add(this.lbShipCode);
            this.gbShipping.Controls.Add(this.tbShipCode);
            this.gbShipping.Controls.Add(this.lbShipState);
            this.gbShipping.Controls.Add(this.lbShipGstin);
            this.gbShipping.Controls.Add(this.tbShipGstin);
            this.gbShipping.Controls.Add(this.tbShipAddress);
            this.gbShipping.Controls.Add(this.lbShipAddress);
            this.gbShipping.Controls.Add(this.tbShipName);
            this.gbShipping.Controls.Add(this.lbShipName);
            this.gbShipping.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbShipping.Enabled = false;
            this.gbShipping.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gbShipping.Location = new System.Drawing.Point(358, 92);
            this.gbShipping.MaximumSize = new System.Drawing.Size(340, 200);
            this.gbShipping.MinimumSize = new System.Drawing.Size(292, 200);
            this.gbShipping.Name = "gbShipping";
            this.gbShipping.Size = new System.Drawing.Size(323, 200);
            this.gbShipping.TabIndex = 6;
            this.gbShipping.TabStop = false;
            this.gbShipping.Text = "Shipping Details";
            // 
            // cbShipState
            // 
            this.cbShipState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShipState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbShipState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbShipState.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShipState.FormattingEnabled = true;
            this.cbShipState.Items.AddRange(new object[] {
            "Andaman and Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chattisgarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Lakshadweep Islands",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Pondicherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.cbShipState.Location = new System.Drawing.Point(78, 164);
            this.cbShipState.Name = "cbShipState";
            this.cbShipState.Size = new System.Drawing.Size(131, 25);
            this.cbShipState.TabIndex = 10;
            this.cbShipState.SelectedIndexChanged += new System.EventHandler(this.cbShipState_SelectedIndexChanged);
            // 
            // lbShipCode
            // 
            this.lbShipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipCode.AutoSize = true;
            this.lbShipCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipCode.Location = new System.Drawing.Point(215, 169);
            this.lbShipCode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbShipCode.Name = "lbShipCode";
            this.lbShipCode.Size = new System.Drawing.Size(45, 16);
            this.lbShipCode.TabIndex = 25;
            this.lbShipCode.Text = "Code";
            // 
            // tbShipCode
            // 
            this.tbShipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipCode.Location = new System.Drawing.Point(266, 164);
            this.tbShipCode.MaximumSize = new System.Drawing.Size(51, 26);
            this.tbShipCode.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbShipCode.Name = "tbShipCode";
            this.tbShipCode.Size = new System.Drawing.Size(51, 26);
            this.tbShipCode.TabIndex = 11;
            this.tbShipCode.Click += new System.EventHandler(this.tbShipCode_Click);
            this.tbShipCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipCode.Leave += new System.EventHandler(this.tbShipCode_Leave);
            // 
            // lbShipState
            // 
            this.lbShipState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipState.AutoSize = true;
            this.lbShipState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipState.Location = new System.Drawing.Point(6, 169);
            this.lbShipState.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbShipState.Name = "lbShipState";
            this.lbShipState.Size = new System.Drawing.Size(44, 16);
            this.lbShipState.TabIndex = 23;
            this.lbShipState.Text = "State";
            // 
            // lbShipGstin
            // 
            this.lbShipGstin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipGstin.AutoSize = true;
            this.lbShipGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipGstin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipGstin.Location = new System.Drawing.Point(6, 137);
            this.lbShipGstin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbShipGstin.Name = "lbShipGstin";
            this.lbShipGstin.Size = new System.Drawing.Size(50, 16);
            this.lbShipGstin.TabIndex = 22;
            this.lbShipGstin.Text = "GSTIN";
            // 
            // tbShipGstin
            // 
            this.tbShipGstin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipGstin.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbShipGstin.Location = new System.Drawing.Point(78, 132);
            this.tbShipGstin.Name = "tbShipGstin";
            this.tbShipGstin.Size = new System.Drawing.Size(239, 25);
            this.tbShipGstin.TabIndex = 9;
            this.tbShipGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipAddress.Location = new System.Drawing.Point(78, 49);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(239, 77);
            this.tbShipAddress.TabIndex = 8;
            this.tbShipAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipAddress
            // 
            this.lbShipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipAddress.AutoSize = true;
            this.lbShipAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipAddress.Location = new System.Drawing.Point(6, 54);
            this.lbShipAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbShipAddress.Name = "lbShipAddress";
            this.lbShipAddress.Size = new System.Drawing.Size(66, 16);
            this.lbShipAddress.TabIndex = 18;
            this.lbShipAddress.Text = "Address";
            // 
            // tbShipName
            // 
            this.tbShipName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipName.Location = new System.Drawing.Point(78, 17);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(239, 25);
            this.tbShipName.TabIndex = 7;
            this.tbShipName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipName
            // 
            this.lbShipName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipName.AutoSize = true;
            this.lbShipName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipName.Location = new System.Drawing.Point(6, 22);
            this.lbShipName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbShipName.Name = "lbShipName";
            this.lbShipName.Size = new System.Drawing.Size(47, 16);
            this.lbShipName.TabIndex = 16;
            this.lbShipName.Text = "Name";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerNo,
            this.colProDes,
            this.colHsnCode,
            this.colQty,
            this.colUnit,
            this.colRate,
            this.colAmount,
            this.colDiscount,
            this.colTaxableVal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.Location = new System.Drawing.Point(12, 332);
            this.dgvProducts.MaximumSize = new System.Drawing.Size(686, 271);
            this.dgvProducts.MinimumSize = new System.Drawing.Size(591, 271);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.Size = new System.Drawing.Size(669, 271);
            this.dgvProducts.TabIndex = 16;
            this.dgvProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellValueChanged);
            this.dgvProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProducts_EditingControlShowing);
            // 
            // colSerNo
            // 
            this.colSerNo.FillWeight = 91.70123F;
            this.colSerNo.HeaderText = "Ser. No.";
            this.colSerNo.Name = "colSerNo";
            this.colSerNo.Width = 40;
            // 
            // colProDes
            // 
            this.colProDes.FillWeight = 200.9351F;
            this.colProDes.HeaderText = "Product Description";
            this.colProDes.Name = "colProDes";
            this.colProDes.Width = 150;
            // 
            // colHsnCode
            // 
            this.colHsnCode.FillWeight = 121.3543F;
            this.colHsnCode.HeaderText = "HSN Code";
            this.colHsnCode.Name = "colHsnCode";
            this.colHsnCode.Width = 60;
            // 
            // colQty
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.colQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQty.FillWeight = 71.97796F;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Width = 45;
            // 
            // colUnit
            // 
            this.colUnit.FillWeight = 76.05863F;
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 40;
            // 
            // colRate
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.colRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRate.FillWeight = 81.26287F;
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Width = 75;
            // 
            // colAmount
            // 
            this.colAmount.FillWeight = 99.03992F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // colDiscount
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.colDiscount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiscount.FillWeight = 104.4025F;
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 60;
            // 
            // colTaxableVal
            // 
            this.colTaxableVal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.colTaxableVal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTaxableVal.FillWeight = 124.9178F;
            this.colTaxableVal.HeaderText = "Taxable Value";
            this.colTaxableVal.Name = "colTaxableVal";
            this.colTaxableVal.ReadOnly = true;
            this.colTaxableVal.Width = 92;
            // 
            // tblPanelTotals
            // 
            this.tblPanelTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPanelTotals.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblPanelTotals.ColumnCount = 7;
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelTotals.Controls.Add(this.lbGST, 5, 0);
            this.tblPanelTotals.Controls.Add(this.lbTaxableVal, 4, 0);
            this.tblPanelTotals.Controls.Add(this.lbDiscount, 3, 0);
            this.tblPanelTotals.Controls.Add(this.lbAmount, 2, 0);
            this.tblPanelTotals.Controls.Add(this.lbQty, 1, 0);
            this.tblPanelTotals.Controls.Add(this.lbFinalTotal, 0, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalQty, 1, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalAmount, 2, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalDiscount, 3, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalTaxVal, 4, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalGst, 5, 1);
            this.tblPanelTotals.Controls.Add(this.lbTotalAll, 6, 0);
            this.tblPanelTotals.Controls.Add(this.lbTotalFinal, 6, 1);
            this.tblPanelTotals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.tblPanelTotals.Location = new System.Drawing.Point(12, 779);
            this.tblPanelTotals.MaximumSize = new System.Drawing.Size(686, 72);
            this.tblPanelTotals.MinimumSize = new System.Drawing.Size(591, 72);
            this.tblPanelTotals.Name = "tblPanelTotals";
            this.tblPanelTotals.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tblPanelTotals.RowCount = 2;
            this.tblPanelTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelTotals.Size = new System.Drawing.Size(669, 72);
            this.tblPanelTotals.TabIndex = 9;
            // 
            // lbGST
            // 
            this.lbGST.AutoSize = true;
            this.lbGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGST.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbGST.Location = new System.Drawing.Point(368, 9);
            this.lbGST.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbGST.Name = "lbGST";
            this.lbGST.Size = new System.Drawing.Size(37, 22);
            this.lbGST.TabIndex = 6;
            this.lbGST.Text = "GST";
            // 
            // lbTaxableVal
            // 
            this.lbTaxableVal.AutoSize = true;
            this.lbTaxableVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTaxableVal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbTaxableVal.Location = new System.Drawing.Point(256, 9);
            this.lbTaxableVal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTaxableVal.Name = "lbTaxableVal";
            this.lbTaxableVal.Size = new System.Drawing.Size(103, 22);
            this.lbTaxableVal.TabIndex = 5;
            this.lbTaxableVal.Text = "Taxable Value";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbDiscount.Location = new System.Drawing.Point(180, 9);
            this.lbDiscount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 22);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Discount";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbAmount.Location = new System.Drawing.Point(112, 9);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(59, 22);
            this.lbAmount.TabIndex = 3;
            this.lbAmount.Text = "Amount";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbQty.Location = new System.Drawing.Point(71, 9);
            this.lbQty.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(32, 22);
            this.lbQty.TabIndex = 2;
            this.lbQty.Text = "Qty";
            // 
            // lbFinalTotal
            // 
            this.lbFinalTotal.AutoSize = true;
            this.lbFinalTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFinalTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalTotal.Location = new System.Drawing.Point(6, 40);
            this.lbFinalTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbFinalTotal.Name = "lbFinalTotal";
            this.lbFinalTotal.Size = new System.Drawing.Size(56, 23);
            this.lbFinalTotal.TabIndex = 8;
            this.lbFinalTotal.Text = "Total";
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalQty.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalQty.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalQty.Location = new System.Drawing.Point(85, 40);
            this.lbTotalQty.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(18, 23);
            this.lbTotalQty.TabIndex = 9;
            this.lbTotalQty.Text = "0";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalAmount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(153, 40);
            this.lbTotalAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(18, 23);
            this.lbTotalAmount.TabIndex = 10;
            this.lbTotalAmount.Text = "0";
            // 
            // lbTotalDiscount
            // 
            this.lbTotalDiscount.AutoSize = true;
            this.lbTotalDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalDiscount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalDiscount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDiscount.Location = new System.Drawing.Point(229, 40);
            this.lbTotalDiscount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalDiscount.Name = "lbTotalDiscount";
            this.lbTotalDiscount.Size = new System.Drawing.Size(18, 23);
            this.lbTotalDiscount.TabIndex = 11;
            this.lbTotalDiscount.Text = "0";
            // 
            // lbTotalTaxVal
            // 
            this.lbTotalTaxVal.AutoSize = true;
            this.lbTotalTaxVal.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalTaxVal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalTaxVal.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTaxVal.Location = new System.Drawing.Point(341, 40);
            this.lbTotalTaxVal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalTaxVal.Name = "lbTotalTaxVal";
            this.lbTotalTaxVal.Size = new System.Drawing.Size(18, 23);
            this.lbTotalTaxVal.TabIndex = 12;
            this.lbTotalTaxVal.Text = "0";
            // 
            // lbTotalGst
            // 
            this.lbTotalGst.AutoSize = true;
            this.lbTotalGst.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalGst.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalGst.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalGst.Location = new System.Drawing.Point(387, 40);
            this.lbTotalGst.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalGst.Name = "lbTotalGst";
            this.lbTotalGst.Size = new System.Drawing.Size(18, 23);
            this.lbTotalGst.TabIndex = 13;
            this.lbTotalGst.Text = "0";
            // 
            // lbTotalAll
            // 
            this.lbTotalAll.AutoSize = true;
            this.lbTotalAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbTotalAll.Location = new System.Drawing.Point(414, 9);
            this.lbTotalAll.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalAll.Name = "lbTotalAll";
            this.lbTotalAll.Size = new System.Drawing.Size(42, 16);
            this.lbTotalAll.TabIndex = 14;
            this.lbTotalAll.Text = "Total";
            // 
            // lbTotalFinal
            // 
            this.lbTotalFinal.AutoSize = true;
            this.lbTotalFinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalFinal.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFinal.Location = new System.Drawing.Point(645, 40);
            this.lbTotalFinal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalFinal.Name = "lbTotalFinal";
            this.lbTotalFinal.Size = new System.Drawing.Size(18, 23);
            this.lbTotalFinal.TabIndex = 15;
            this.lbTotalFinal.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.MaximumSize = new System.Drawing.Size(75, 40);
            this.btnSave.MinimumSize = new System.Drawing.Size(75, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.AutoSize = true;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(84, 3);
            this.btnPrint.MaximumSize = new System.Drawing.Size(75, 40);
            this.btnPrint.MinimumSize = new System.Drawing.Size(75, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 40);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // flwPanelButtons
            // 
            this.flwPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwPanelButtons.Controls.Add(this.btnSave);
            this.flwPanelButtons.Controls.Add(this.btnPrint);
            this.flwPanelButtons.Enabled = false;
            this.flwPanelButtons.Location = new System.Drawing.Point(285, 857);
            this.flwPanelButtons.MaximumSize = new System.Drawing.Size(174, 43);
            this.flwPanelButtons.MinimumSize = new System.Drawing.Size(174, 43);
            this.flwPanelButtons.Name = "flwPanelButtons";
            this.flwPanelButtons.Size = new System.Drawing.Size(174, 43);
            this.flwPanelButtons.TabIndex = 12;
            // 
            // gbAddCharge
            // 
            this.gbAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddCharge.Controls.Add(this.tblPnlAddCharge);
            this.gbAddCharge.Controls.Add(this.lbAddCharge);
            this.gbAddCharge.Controls.Add(this.tbAddCharge);
            this.gbAddCharge.Controls.Add(this.btnAddCharge);
            this.gbAddCharge.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbAddCharge.Location = new System.Drawing.Point(12, 610);
            this.gbAddCharge.MaximumSize = new System.Drawing.Size(686, 163);
            this.gbAddCharge.MinimumSize = new System.Drawing.Size(591, 163);
            this.gbAddCharge.Name = "gbAddCharge";
            this.gbAddCharge.Size = new System.Drawing.Size(669, 163);
            this.gbAddCharge.TabIndex = 18;
            this.gbAddCharge.TabStop = false;
            this.gbAddCharge.Text = "Additional Charges";
            // 
            // tblPnlAddCharge
            // 
            this.tblPnlAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlAddCharge.AutoScroll = true;
            this.tblPnlAddCharge.ColumnCount = 2;
            this.tblPnlAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.07418F));
            this.tblPnlAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.92582F));
            this.tblPnlAddCharge.Location = new System.Drawing.Point(6, 45);
            this.tblPnlAddCharge.Name = "tblPnlAddCharge";
            this.tblPnlAddCharge.RowCount = 1;
            this.tblPnlAddCharge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblPnlAddCharge.Size = new System.Drawing.Size(657, 112);
            this.tblPnlAddCharge.TabIndex = 19;
            // 
            // lbAddCharge
            // 
            this.lbAddCharge.Location = new System.Drawing.Point(6, 19);
            this.lbAddCharge.Name = "lbAddCharge";
            this.lbAddCharge.Size = new System.Drawing.Size(194, 16);
            this.lbAddCharge.TabIndex = 0;
            this.lbAddCharge.Text = "Additional Charges Name";
            // 
            // tbAddCharge
            // 
            this.tbAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddCharge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddCharge.Location = new System.Drawing.Point(206, 16);
            this.tbAddCharge.MaxLength = 50;
            this.tbAddCharge.Name = "tbAddCharge";
            this.tbAddCharge.Size = new System.Drawing.Size(365, 25);
            this.tbAddCharge.TabIndex = 17;
            this.tbAddCharge.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            // 
            // btnAddCharge
            // 
            this.btnAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCharge.Enabled = false;
            this.btnAddCharge.Location = new System.Drawing.Point(577, 16);
            this.btnAddCharge.Name = "btnAddCharge";
            this.btnAddCharge.Size = new System.Drawing.Size(86, 23);
            this.btnAddCharge.TabIndex = 18;
            this.btnAddCharge.Text = "Add";
            this.btnAddCharge.UseVisualStyleBackColor = true;
            this.btnAddCharge.Click += new System.EventHandler(this.btnAddCharge_Click);
            // 
            // lbSgst
            // 
            this.lbSgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSgst.AutoSize = true;
            this.lbSgst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbSgst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSgst.Location = new System.Drawing.Point(17, 301);
            this.lbSgst.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbSgst.Name = "lbSgst";
            this.lbSgst.Size = new System.Drawing.Size(45, 16);
            this.lbSgst.TabIndex = 20;
            this.lbSgst.Text = "SGST";
            // 
            // tbSgst
            // 
            this.tbSgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSgst.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSgst.Location = new System.Drawing.Point(68, 298);
            this.tbSgst.MaximumSize = new System.Drawing.Size(51, 26);
            this.tbSgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbSgst.Name = "tbSgst";
            this.tbSgst.Size = new System.Drawing.Size(51, 26);
            this.tbSgst.TabIndex = 13;
            this.tbSgst.TextChanged += new System.EventHandler(this.tbGst_TextChanged);
            this.tbSgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbCgst
            // 
            this.lbCgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCgst.AutoSize = true;
            this.lbCgst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbCgst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCgst.Location = new System.Drawing.Point(125, 301);
            this.lbCgst.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbCgst.Name = "lbCgst";
            this.lbCgst.Size = new System.Drawing.Size(46, 16);
            this.lbCgst.TabIndex = 22;
            this.lbCgst.Text = "CGST";
            // 
            // tbCgst
            // 
            this.tbCgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCgst.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCgst.Location = new System.Drawing.Point(177, 298);
            this.tbCgst.MaximumSize = new System.Drawing.Size(51, 26);
            this.tbCgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbCgst.Name = "tbCgst";
            this.tbCgst.Size = new System.Drawing.Size(51, 26);
            this.tbCgst.TabIndex = 14;
            this.tbCgst.TextChanged += new System.EventHandler(this.tbGst_TextChanged);
            this.tbCgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbIgst
            // 
            this.lbIgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIgst.AutoSize = true;
            this.lbIgst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbIgst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbIgst.Location = new System.Drawing.Point(249, 301);
            this.lbIgst.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbIgst.Name = "lbIgst";
            this.lbIgst.Size = new System.Drawing.Size(40, 16);
            this.lbIgst.TabIndex = 24;
            this.lbIgst.Text = "IGST";
            // 
            // tbIgst
            // 
            this.tbIgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIgst.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIgst.Location = new System.Drawing.Point(295, 298);
            this.tbIgst.MaximumSize = new System.Drawing.Size(51, 26);
            this.tbIgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbIgst.Name = "tbIgst";
            this.tbIgst.Size = new System.Drawing.Size(51, 26);
            this.tbIgst.TabIndex = 15;
            this.tbIgst.TextChanged += new System.EventHandler(this.tbGst_TextChanged);
            this.tbIgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(727, 329);
            this.Controls.Add(this.lbIgst);
            this.Controls.Add(this.tbIgst);
            this.Controls.Add(this.lbCgst);
            this.Controls.Add(this.tbCgst);
            this.Controls.Add(this.lbSgst);
            this.Controls.Add(this.tbSgst);
            this.Controls.Add(this.gbAddCharge);
            this.Controls.Add(this.flwPanelButtons);
            this.Controls.Add(this.tblPanelTotals);
            this.Controls.Add(this.cbBillAndShip);
            this.Controls.Add(this.gbShipping);
            this.Controls.Add(this.gbInvoice);
            this.Controls.Add(this.gbBilling);
            this.Controls.Add(this.dgvProducts);
            this.MaximumSize = new System.Drawing.Size(743, 950);
            this.MinimumSize = new System.Drawing.Size(648, 367);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Billing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invoice_FormClosed);
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResizeEnd += new System.EventHandler(this.Invoice_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Invoice_ResizeEnd);
            this.gbBilling.ResumeLayout(false);
            this.gbBilling.PerformLayout();
            this.gbInvoice.ResumeLayout(false);
            this.tableLayoutInvoice.ResumeLayout(false);
            this.tableLayoutInvoice.PerformLayout();
            this.gbShipping.ResumeLayout(false);
            this.gbShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tblPanelTotals.ResumeLayout(false);
            this.tblPanelTotals.PerformLayout();
            this.flwPanelButtons.ResumeLayout(false);
            this.flwPanelButtons.PerformLayout();
            this.gbAddCharge.ResumeLayout(false);
            this.gbAddCharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.GroupBox gbInvoice;
        private System.Windows.Forms.Label lbInvoiceNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInvoice;
        private System.Windows.Forms.Label lbInvoiceDate;
        private System.Windows.Forms.TextBox tbInvoiceNum;
        private System.Windows.Forms.GroupBox gbShipping;
        private System.Windows.Forms.Label lbBillName;
        private System.Windows.Forms.TextBox tbBillAddress;
        private System.Windows.Forms.Label lbBillAddress;
        private System.Windows.Forms.Label lbBillCode;
        private System.Windows.Forms.TextBox tbBillCode;
        private System.Windows.Forms.CheckBox cbBillAndShip;
        private System.Windows.Forms.Label lbBillState;
        private System.Windows.Forms.Label lbBillGstin;
        private System.Windows.Forms.TextBox tbBillGstin;
        private System.Windows.Forms.Label lbShipCode;
        private System.Windows.Forms.TextBox tbShipCode;
        private System.Windows.Forms.Label lbShipState;
        private System.Windows.Forms.Label lbShipGstin;
        private System.Windows.Forms.TextBox tbShipGstin;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lbShipAddress;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.Label lbShipName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TableLayoutPanel tblPanelTotals;
        private System.Windows.Forms.Label lbGST;
        private System.Windows.Forms.Label lbTaxableVal;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbFinalTotal;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbTotalDiscount;
        private System.Windows.Forms.Label lbTotalTaxVal;
        private System.Windows.Forms.Label lbTotalGst;
        private System.Windows.Forms.Label lbTotalAll;
        private System.Windows.Forms.ComboBox cbBillState;
        private System.Windows.Forms.ComboBox cbShipState;
        private System.Windows.Forms.Label lbTotalFinal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.FlowLayoutPanel flwPanelButtons;
        private System.Windows.Forms.GroupBox gbAddCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHsnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxableVal;
        private System.Windows.Forms.Label lbSgst;
        private System.Windows.Forms.TextBox tbSgst;
        private System.Windows.Forms.Label lbCgst;
        private System.Windows.Forms.TextBox tbCgst;
        private System.Windows.Forms.Label lbIgst;
        private System.Windows.Forms.TextBox tbIgst;
        private System.Windows.Forms.Button btnAddCharge;
        private System.Windows.Forms.TextBox tbAddCharge;
        private System.Windows.Forms.Label lbAddCharge;
        private System.Windows.Forms.TableLayoutPanel tblPnlAddCharge;
        private System.Windows.Forms.ComboBox cbBillName;
        private System.Windows.Forms.DateTimePicker tbInvoiceDate;
    }
}

