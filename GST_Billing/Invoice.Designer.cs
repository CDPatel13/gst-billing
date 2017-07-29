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
            this.tbBillPin = new System.Windows.Forms.TextBox();
            this.lbBillPin = new System.Windows.Forms.Label();
            this.tbBillCity = new System.Windows.Forms.TextBox();
            this.lbBillCity = new System.Windows.Forms.Label();
            this.tbBillLandmark = new System.Windows.Forms.TextBox();
            this.lbBillLandmark = new System.Windows.Forms.Label();
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
            this.tbBillName = new System.Windows.Forms.TextBox();
            this.cbBillAndShip = new System.Windows.Forms.CheckBox();
            this.gbInvoice = new System.Windows.Forms.GroupBox();
            this.tlpInvoice = new System.Windows.Forms.TableLayoutPanel();
            this.tbChallanNumber = new System.Windows.Forms.TextBox();
            this.lbChallan = new System.Windows.Forms.Label();
            this.tbInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lbInvoiceDate = new System.Windows.Forms.Label();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.tbInvoiceNum = new System.Windows.Forms.TextBox();
            this.btnAddChallan = new System.Windows.Forms.Button();
            this.btnClearChallan = new System.Windows.Forms.Button();
            this.lbAddedChallan = new System.Windows.Forms.Label();
            this.gbShipping = new System.Windows.Forms.GroupBox();
            this.tbShipPin = new System.Windows.Forms.TextBox();
            this.lbShipPin = new System.Windows.Forms.Label();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.lbShipCity = new System.Windows.Forms.Label();
            this.tbShipLandmark = new System.Windows.Forms.TextBox();
            this.lbShipLandmark = new System.Windows.Forms.Label();
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
            this.tlpTotals = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalFinal = new System.Windows.Forms.Label();
            this.lbTotalIgst = new System.Windows.Forms.Label();
            this.lbSgstT = new System.Windows.Forms.Label();
            this.lbTaxableVal = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbFinalTotal = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbTotalDiscount = new System.Windows.Forms.Label();
            this.lbTotalTaxVal = new System.Windows.Forms.Label();
            this.lbTotalSgst = new System.Windows.Forms.Label();
            this.lbTotalCgst = new System.Windows.Forms.Label();
            this.lbTotalAll = new System.Windows.Forms.Label();
            this.lbCgstT = new System.Windows.Forms.Label();
            this.lbIgstT = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.flpPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.gbAddCharge = new System.Windows.Forms.GroupBox();
            this.tlpAddCharge = new System.Windows.Forms.TableLayoutPanel();
            this.lbAddCharge1 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge1 = new System.Windows.Forms.TextBox();
            this.lbAddCharge2 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge2 = new System.Windows.Forms.TextBox();
            this.lbAddCharge3 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge3 = new System.Windows.Forms.TextBox();
            this.lbAddCharge4 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge4 = new System.Windows.Forms.TextBox();
            this.lbAddCharge5 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge5 = new System.Windows.Forms.TextBox();
            this.lbAddCharge6 = new System.Windows.Forms.ComboBox();
            this.tbAddCharge6 = new System.Windows.Forms.TextBox();
            this.lbSgst = new System.Windows.Forms.Label();
            this.tbSgst = new System.Windows.Forms.TextBox();
            this.lbCgst = new System.Windows.Forms.Label();
            this.tbCgst = new System.Windows.Forms.TextBox();
            this.lbIgst = new System.Windows.Forms.Label();
            this.tbIgst = new System.Windows.Forms.TextBox();
            this.flpBillShip = new System.Windows.Forms.FlowLayoutPanel();
            this.flpA = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGst = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAddCharge = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBilling.SuspendLayout();
            this.gbInvoice.SuspendLayout();
            this.tlpInvoice.SuspendLayout();
            this.gbShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tlpTotals.SuspendLayout();
            this.flpPanelButtons.SuspendLayout();
            this.gbAddCharge.SuspendLayout();
            this.tlpAddCharge.SuspendLayout();
            this.flpBillShip.SuspendLayout();
            this.flpA.SuspendLayout();
            this.flpGst.SuspendLayout();
            this.flpAddCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBilling
            // 
            this.gbBilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBilling.Controls.Add(this.tbBillPin);
            this.gbBilling.Controls.Add(this.lbBillPin);
            this.gbBilling.Controls.Add(this.tbBillCity);
            this.gbBilling.Controls.Add(this.lbBillCity);
            this.gbBilling.Controls.Add(this.tbBillLandmark);
            this.gbBilling.Controls.Add(this.lbBillLandmark);
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
            this.gbBilling.Controls.Add(this.tbBillName);
            this.gbBilling.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gbBilling.Location = new System.Drawing.Point(3, 3);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(363, 231);
            this.gbBilling.TabIndex = 5;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "Billing Details";
            // 
            // tbBillPin
            // 
            this.tbBillPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillPin.Location = new System.Drawing.Point(239, 139);
            this.tbBillPin.Name = "tbBillPin";
            this.tbBillPin.Size = new System.Drawing.Size(118, 26);
            this.tbBillPin.TabIndex = 24;
            // 
            // lbBillPin
            // 
            this.lbBillPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillPin.AutoSize = true;
            this.lbBillPin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillPin.Location = new System.Drawing.Point(202, 144);
            this.lbBillPin.Name = "lbBillPin";
            this.lbBillPin.Size = new System.Drawing.Size(31, 16);
            this.lbBillPin.TabIndex = 23;
            this.lbBillPin.Text = "PIN";
            // 
            // tbBillCity
            // 
            this.tbBillCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillCity.Location = new System.Drawing.Point(78, 139);
            this.tbBillCity.Name = "tbBillCity";
            this.tbBillCity.Size = new System.Drawing.Size(118, 26);
            this.tbBillCity.TabIndex = 22;
            // 
            // lbBillCity
            // 
            this.lbBillCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillCity.AutoSize = true;
            this.lbBillCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillCity.Location = new System.Drawing.Point(6, 145);
            this.lbBillCity.Name = "lbBillCity";
            this.lbBillCity.Size = new System.Drawing.Size(34, 16);
            this.lbBillCity.TabIndex = 21;
            this.lbBillCity.Text = "City";
            // 
            // tbBillLandmark
            // 
            this.tbBillLandmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillLandmark.Location = new System.Drawing.Point(78, 107);
            this.tbBillLandmark.Name = "tbBillLandmark";
            this.tbBillLandmark.Size = new System.Drawing.Size(278, 26);
            this.tbBillLandmark.TabIndex = 20;
            // 
            // lbBillLandmark
            // 
            this.lbBillLandmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillLandmark.AutoSize = true;
            this.lbBillLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillLandmark.Location = new System.Drawing.Point(5, 113);
            this.lbBillLandmark.Name = "lbBillLandmark";
            this.lbBillLandmark.Size = new System.Drawing.Size(76, 16);
            this.lbBillLandmark.TabIndex = 19;
            this.lbBillLandmark.Text = "Landmark";
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
            this.cbBillName.Size = new System.Drawing.Size(278, 25);
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
            this.cbBillState.Location = new System.Drawing.Point(78, 202);
            this.cbBillState.Name = "cbBillState";
            this.cbBillState.Size = new System.Drawing.Size(171, 25);
            this.cbBillState.TabIndex = 5;
            // 
            // lbBillCode
            // 
            this.lbBillCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillCode.AutoSize = true;
            this.lbBillCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillCode.Location = new System.Drawing.Point(255, 206);
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
            this.tbBillCode.Location = new System.Drawing.Point(305, 202);
            this.tbBillCode.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbBillCode.Name = "tbBillCode";
            this.tbBillCode.Size = new System.Drawing.Size(51, 25);
            this.tbBillCode.TabIndex = 6;
            // 
            // lbBillState
            // 
            this.lbBillState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBillState.AutoSize = true;
            this.lbBillState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbBillState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBillState.Location = new System.Drawing.Point(5, 207);
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
            this.lbBillGstin.Location = new System.Drawing.Point(6, 181);
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
            this.tbBillGstin.Location = new System.Drawing.Point(78, 171);
            this.tbBillGstin.Name = "tbBillGstin";
            this.tbBillGstin.Size = new System.Drawing.Size(279, 25);
            this.tbBillGstin.TabIndex = 4;
            // 
            // tbBillAddress
            // 
            this.tbBillAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillAddress.Enabled = false;
            this.tbBillAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillAddress.Location = new System.Drawing.Point(78, 51);
            this.tbBillAddress.Multiline = true;
            this.tbBillAddress.Name = "tbBillAddress";
            this.tbBillAddress.Size = new System.Drawing.Size(279, 50);
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
            // tbBillName
            // 
            this.tbBillName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillName.Location = new System.Drawing.Point(78, 18);
            this.tbBillName.Name = "tbBillName";
            this.tbBillName.Size = new System.Drawing.Size(279, 25);
            this.tbBillName.TabIndex = 25;
            this.tbBillName.Visible = false;
            // 
            // cbBillAndShip
            // 
            this.cbBillAndShip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBillAndShip.AutoSize = true;
            this.cbBillAndShip.Checked = true;
            this.cbBillAndShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBillAndShip.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBillAndShip.Location = new System.Drawing.Point(361, 7);
            this.cbBillAndShip.Margin = new System.Windows.Forms.Padding(10, 7, 3, 3);
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
            this.gbInvoice.Controls.Add(this.tlpInvoice);
            this.gbInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gbInvoice.Location = new System.Drawing.Point(3, 3);
            this.gbInvoice.Name = "gbInvoice";
            this.gbInvoice.Size = new System.Drawing.Size(732, 91);
            this.gbInvoice.TabIndex = 0;
            this.gbInvoice.TabStop = false;
            this.gbInvoice.Text = "Tax Invoice";
            // 
            // tlpInvoice
            // 
            this.tlpInvoice.ColumnCount = 5;
            this.tlpInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpInvoice.Controls.Add(this.tbChallanNumber, 3, 0);
            this.tlpInvoice.Controls.Add(this.lbChallan, 2, 0);
            this.tlpInvoice.Controls.Add(this.tbInvoiceDate, 1, 1);
            this.tlpInvoice.Controls.Add(this.lbInvoiceDate, 0, 1);
            this.tlpInvoice.Controls.Add(this.lbInvoiceNo, 0, 0);
            this.tlpInvoice.Controls.Add(this.tbInvoiceNum, 1, 0);
            this.tlpInvoice.Controls.Add(this.btnAddChallan, 3, 1);
            this.tlpInvoice.Controls.Add(this.btnClearChallan, 4, 1);
            this.tlpInvoice.Controls.Add(this.lbAddedChallan, 2, 1);
            this.tlpInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInvoice.Location = new System.Drawing.Point(3, 22);
            this.tlpInvoice.Name = "tlpInvoice";
            this.tlpInvoice.RowCount = 2;
            this.tlpInvoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInvoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInvoice.Size = new System.Drawing.Size(726, 66);
            this.tlpInvoice.TabIndex = 4;
            // 
            // tbChallanNumber
            // 
            this.tlpInvoice.SetColumnSpan(this.tbChallanNumber, 2);
            this.tbChallanNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChallanNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChallanNumber.Location = new System.Drawing.Point(510, 3);
            this.tbChallanNumber.Name = "tbChallanNumber";
            this.tbChallanNumber.Size = new System.Drawing.Size(213, 25);
            this.tbChallanNumber.TabIndex = 11;
            this.tbChallanNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChallanNumber_KeyPress);
            // 
            // lbChallan
            // 
            this.lbChallan.AutoSize = true;
            this.lbChallan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbChallan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbChallan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbChallan.Location = new System.Drawing.Point(444, 0);
            this.lbChallan.Name = "lbChallan";
            this.lbChallan.Size = new System.Drawing.Size(60, 33);
            this.lbChallan.TabIndex = 6;
            this.lbChallan.Text = "Challan";
            this.lbChallan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvoiceDate
            // 
            this.tbInvoiceDate.CalendarFont = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceDate.CustomFormat = "dd /MMM/ yyyy";
            this.tbInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInvoiceDate.Font = new System.Drawing.Font("Arial", 10F);
            this.tbInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbInvoiceDate.Location = new System.Drawing.Point(148, 36);
            this.tbInvoiceDate.Name = "tbInvoiceDate";
            this.tbInvoiceDate.Size = new System.Drawing.Size(211, 23);
            this.tbInvoiceDate.TabIndex = 5;
            // 
            // lbInvoiceDate
            // 
            this.lbInvoiceDate.AutoSize = true;
            this.lbInvoiceDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbInvoiceDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInvoiceDate.Location = new System.Drawing.Point(46, 33);
            this.lbInvoiceDate.Name = "lbInvoiceDate";
            this.lbInvoiceDate.Size = new System.Drawing.Size(96, 33);
            this.lbInvoiceDate.TabIndex = 3;
            this.lbInvoiceDate.Text = "Invoice Date";
            this.lbInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.AutoSize = true;
            this.lbInvoiceNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbInvoiceNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbInvoiceNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInvoiceNo.Location = new System.Drawing.Point(23, 0);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(119, 33);
            this.lbInvoiceNo.TabIndex = 0;
            this.lbInvoiceNo.Text = "Invoice Number";
            this.lbInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInvoiceNum
            // 
            this.tbInvoiceNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInvoiceNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceNum.Location = new System.Drawing.Point(148, 3);
            this.tbInvoiceNum.Name = "tbInvoiceNum";
            this.tbInvoiceNum.Size = new System.Drawing.Size(211, 25);
            this.tbInvoiceNum.TabIndex = 0;
            // 
            // btnAddChallan
            // 
            this.btnAddChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddChallan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChallan.Location = new System.Drawing.Point(510, 36);
            this.btnAddChallan.Name = "btnAddChallan";
            this.btnAddChallan.Size = new System.Drawing.Size(102, 27);
            this.btnAddChallan.TabIndex = 8;
            this.btnAddChallan.Text = "Add Challan";
            this.btnAddChallan.UseVisualStyleBackColor = true;
            this.btnAddChallan.Click += new System.EventHandler(this.btnAddChallan_Click);
            // 
            // btnClearChallan
            // 
            this.btnClearChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearChallan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearChallan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearChallan.Location = new System.Drawing.Point(618, 36);
            this.btnClearChallan.Name = "btnClearChallan";
            this.btnClearChallan.Size = new System.Drawing.Size(105, 27);
            this.btnClearChallan.TabIndex = 9;
            this.btnClearChallan.Text = "Clear";
            this.btnClearChallan.UseVisualStyleBackColor = true;
            this.btnClearChallan.Click += new System.EventHandler(this.btnClearChallan_Click);
            // 
            // lbAddedChallan
            // 
            this.lbAddedChallan.AutoSize = true;
            this.lbAddedChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddedChallan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbAddedChallan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAddedChallan.Location = new System.Drawing.Point(365, 33);
            this.lbAddedChallan.Name = "lbAddedChallan";
            this.lbAddedChallan.Size = new System.Drawing.Size(139, 33);
            this.lbAddedChallan.TabIndex = 10;
            this.lbAddedChallan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbShipping
            // 
            this.gbShipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbShipping.Controls.Add(this.tbShipPin);
            this.gbShipping.Controls.Add(this.lbShipPin);
            this.gbShipping.Controls.Add(this.tbShipCity);
            this.gbShipping.Controls.Add(this.lbShipCity);
            this.gbShipping.Controls.Add(this.tbShipLandmark);
            this.gbShipping.Controls.Add(this.lbShipLandmark);
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
            this.gbShipping.Location = new System.Drawing.Point(372, 3);
            this.gbShipping.Name = "gbShipping";
            this.gbShipping.Size = new System.Drawing.Size(363, 231);
            this.gbShipping.TabIndex = 6;
            this.gbShipping.TabStop = false;
            this.gbShipping.Text = "Shipping Details";
            // 
            // tbShipPin
            // 
            this.tbShipPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipPin.Location = new System.Drawing.Point(239, 139);
            this.tbShipPin.Name = "tbShipPin";
            this.tbShipPin.Size = new System.Drawing.Size(118, 26);
            this.tbShipPin.TabIndex = 31;
            // 
            // lbShipPin
            // 
            this.lbShipPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipPin.AutoSize = true;
            this.lbShipPin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipPin.Location = new System.Drawing.Point(202, 144);
            this.lbShipPin.Name = "lbShipPin";
            this.lbShipPin.Size = new System.Drawing.Size(31, 16);
            this.lbShipPin.TabIndex = 30;
            this.lbShipPin.Text = "PIN";
            // 
            // tbShipCity
            // 
            this.tbShipCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipCity.Location = new System.Drawing.Point(78, 139);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(118, 26);
            this.tbShipCity.TabIndex = 29;
            // 
            // lbShipCity
            // 
            this.lbShipCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipCity.AutoSize = true;
            this.lbShipCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipCity.Location = new System.Drawing.Point(6, 144);
            this.lbShipCity.Name = "lbShipCity";
            this.lbShipCity.Size = new System.Drawing.Size(34, 16);
            this.lbShipCity.TabIndex = 28;
            this.lbShipCity.Text = "City";
            // 
            // tbShipLandmark
            // 
            this.tbShipLandmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipLandmark.Location = new System.Drawing.Point(78, 107);
            this.tbShipLandmark.Name = "tbShipLandmark";
            this.tbShipLandmark.Size = new System.Drawing.Size(279, 26);
            this.tbShipLandmark.TabIndex = 27;
            // 
            // lbShipLandmark
            // 
            this.lbShipLandmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipLandmark.AutoSize = true;
            this.lbShipLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipLandmark.Location = new System.Drawing.Point(6, 112);
            this.lbShipLandmark.Name = "lbShipLandmark";
            this.lbShipLandmark.Size = new System.Drawing.Size(76, 16);
            this.lbShipLandmark.TabIndex = 26;
            this.lbShipLandmark.Text = "Landmark";
            // 
            // cbShipState
            // 
            this.cbShipState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShipState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
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
            this.cbShipState.Location = new System.Drawing.Point(78, 202);
            this.cbShipState.Name = "cbShipState";
            this.cbShipState.Size = new System.Drawing.Size(171, 25);
            this.cbShipState.TabIndex = 10;
            this.cbShipState.SelectedIndexChanged += new System.EventHandler(this.cbShipState_SelectedIndexChanged);
            // 
            // lbShipCode
            // 
            this.lbShipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShipCode.AutoSize = true;
            this.lbShipCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipCode.Location = new System.Drawing.Point(255, 207);
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
            this.tbShipCode.Location = new System.Drawing.Point(306, 202);
            this.tbShipCode.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbShipCode.Name = "tbShipCode";
            this.tbShipCode.Size = new System.Drawing.Size(51, 25);
            this.tbShipCode.TabIndex = 11;
            this.tbShipCode.Click += new System.EventHandler(this.tbShipCode_Click);
            this.tbShipCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipCode.Leave += new System.EventHandler(this.tbShipCode_Leave);
            // 
            // lbShipState
            // 
            this.lbShipState.AutoSize = true;
            this.lbShipState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipState.Location = new System.Drawing.Point(6, 207);
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
            this.lbShipGstin.Location = new System.Drawing.Point(6, 175);
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
            this.tbShipGstin.Location = new System.Drawing.Point(78, 171);
            this.tbShipGstin.Name = "tbShipGstin";
            this.tbShipGstin.Size = new System.Drawing.Size(279, 25);
            this.tbShipGstin.TabIndex = 9;
            this.tbShipGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipAddress.Location = new System.Drawing.Point(78, 51);
            this.tbShipAddress.Multiline = true;
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(279, 50);
            this.tbShipAddress.TabIndex = 8;
            this.tbShipAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipAddress
            // 
            this.lbShipAddress.AutoSize = true;
            this.lbShipAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbShipAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbShipAddress.Location = new System.Drawing.Point(6, 55);
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
            this.tbShipName.Location = new System.Drawing.Point(78, 20);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(279, 25);
            this.tbShipName.TabIndex = 7;
            this.tbShipName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipName
            // 
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
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 373);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.Size = new System.Drawing.Size(759, 205);
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
            this.colProDes.Width = 160;
            // 
            // colHsnCode
            // 
            this.colHsnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colHsnCode.FillWeight = 121.3543F;
            this.colHsnCode.HeaderText = "HSN Code";
            this.colHsnCode.Name = "colHsnCode";
            this.colHsnCode.Width = 77;
            // 
            // colQty
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.colQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQty.FillWeight = 71.97796F;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Width = 60;
            // 
            // colUnit
            // 
            this.colUnit.FillWeight = 76.05863F;
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 50;
            // 
            // colRate
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.colRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRate.FillWeight = 81.26287F;
            this.colRate.HeaderText = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Width = 70;
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
            this.colDiscount.Width = 70;
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
            // tlpTotals
            // 
            this.tlpTotals.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpTotals.ColumnCount = 9;
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.Controls.Add(this.lbTotalFinal, 8, 1);
            this.tlpTotals.Controls.Add(this.lbTotalIgst, 7, 1);
            this.tlpTotals.Controls.Add(this.lbSgstT, 5, 0);
            this.tlpTotals.Controls.Add(this.lbTaxableVal, 4, 0);
            this.tlpTotals.Controls.Add(this.lbDiscount, 3, 0);
            this.tlpTotals.Controls.Add(this.lbAmount, 2, 0);
            this.tlpTotals.Controls.Add(this.lbQty, 1, 0);
            this.tlpTotals.Controls.Add(this.lbFinalTotal, 0, 1);
            this.tlpTotals.Controls.Add(this.lbTotalQty, 1, 1);
            this.tlpTotals.Controls.Add(this.lbTotalAmount, 2, 1);
            this.tlpTotals.Controls.Add(this.lbTotalDiscount, 3, 1);
            this.tlpTotals.Controls.Add(this.lbTotalTaxVal, 4, 1);
            this.tlpTotals.Controls.Add(this.lbTotalSgst, 5, 1);
            this.tlpTotals.Controls.Add(this.lbTotalCgst, 6, 1);
            this.tlpTotals.Controls.Add(this.lbTotalAll, 8, 0);
            this.tlpTotals.Controls.Add(this.lbCgstT, 6, 0);
            this.tlpTotals.Controls.Add(this.lbIgstT, 7, 0);
            this.tlpTotals.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTotals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.tlpTotals.Location = new System.Drawing.Point(0, 749);
            this.tlpTotals.Name = "tlpTotals";
            this.tlpTotals.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tlpTotals.RowCount = 2;
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotals.Size = new System.Drawing.Size(759, 72);
            this.tlpTotals.TabIndex = 9;
            // 
            // lbTotalFinal
            // 
            this.lbTotalFinal.AutoSize = true;
            this.lbTotalFinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalFinal.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFinal.Location = new System.Drawing.Point(735, 40);
            this.lbTotalFinal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalFinal.Name = "lbTotalFinal";
            this.lbTotalFinal.Size = new System.Drawing.Size(18, 23);
            this.lbTotalFinal.TabIndex = 20;
            this.lbTotalFinal.Text = "0";
            // 
            // lbTotalIgst
            // 
            this.lbTotalIgst.AutoSize = true;
            this.lbTotalIgst.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalIgst.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalIgst.Location = new System.Drawing.Point(560, 40);
            this.lbTotalIgst.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalIgst.Name = "lbTotalIgst";
            this.lbTotalIgst.Size = new System.Drawing.Size(18, 23);
            this.lbTotalIgst.TabIndex = 19;
            this.lbTotalIgst.Text = "0";
            // 
            // lbSgstT
            // 
            this.lbSgstT.AutoSize = true;
            this.lbSgstT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSgstT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbSgstT.Location = new System.Drawing.Point(368, 9);
            this.lbSgstT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbSgstT.Name = "lbSgstT";
            this.lbSgstT.Size = new System.Drawing.Size(64, 22);
            this.lbSgstT.TabIndex = 6;
            this.lbSgstT.Text = "SGST";
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
            // lbTotalSgst
            // 
            this.lbTotalSgst.AutoSize = true;
            this.lbTotalSgst.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotalSgst.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalSgst.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSgst.Location = new System.Drawing.Point(414, 40);
            this.lbTotalSgst.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalSgst.Name = "lbTotalSgst";
            this.lbTotalSgst.Size = new System.Drawing.Size(18, 23);
            this.lbTotalSgst.TabIndex = 13;
            this.lbTotalSgst.Text = "0";
            // 
            // lbTotalCgst
            // 
            this.lbTotalCgst.AutoSize = true;
            this.lbTotalCgst.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalCgst.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCgst.Location = new System.Drawing.Point(487, 40);
            this.lbTotalCgst.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalCgst.Name = "lbTotalCgst";
            this.lbTotalCgst.Size = new System.Drawing.Size(18, 23);
            this.lbTotalCgst.TabIndex = 15;
            this.lbTotalCgst.Text = "0";
            // 
            // lbTotalAll
            // 
            this.lbTotalAll.AutoSize = true;
            this.lbTotalAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbTotalAll.Location = new System.Drawing.Point(587, 9);
            this.lbTotalAll.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbTotalAll.Name = "lbTotalAll";
            this.lbTotalAll.Size = new System.Drawing.Size(42, 16);
            this.lbTotalAll.TabIndex = 14;
            this.lbTotalAll.Text = "Total";
            // 
            // lbCgstT
            // 
            this.lbCgstT.AutoSize = true;
            this.lbCgstT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCgstT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCgstT.Location = new System.Drawing.Point(441, 9);
            this.lbCgstT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbCgstT.Name = "lbCgstT";
            this.lbCgstT.Size = new System.Drawing.Size(64, 22);
            this.lbCgstT.TabIndex = 16;
            this.lbCgstT.Text = "CGST";
            // 
            // lbIgstT
            // 
            this.lbIgstT.AutoSize = true;
            this.lbIgstT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIgstT.Location = new System.Drawing.Point(514, 9);
            this.lbIgstT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lbIgstT.Name = "lbIgstT";
            this.lbIgstT.Size = new System.Drawing.Size(38, 15);
            this.lbIgstT.TabIndex = 17;
            this.lbIgstT.Text = "IGST";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(3, 0);
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
            this.btnPrint.Location = new System.Drawing.Point(84, 0);
            this.btnPrint.MinimumSize = new System.Drawing.Size(75, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 40);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // flpPanelButtons
            // 
            this.flpPanelButtons.Controls.Add(this.btnSave);
            this.flpPanelButtons.Controls.Add(this.btnPrint);
            this.flpPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpPanelButtons.Enabled = false;
            this.flpPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flpPanelButtons.Location = new System.Drawing.Point(0, 821);
            this.flpPanelButtons.MinimumSize = new System.Drawing.Size(174, 43);
            this.flpPanelButtons.Name = "flpPanelButtons";
            this.flpPanelButtons.Size = new System.Drawing.Size(759, 43);
            this.flpPanelButtons.TabIndex = 12;
            // 
            // gbAddCharge
            // 
            this.gbAddCharge.Controls.Add(this.tlpAddCharge);
            this.gbAddCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddCharge.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbAddCharge.Location = new System.Drawing.Point(3, 3);
            this.gbAddCharge.MinimumSize = new System.Drawing.Size(591, 163);
            this.gbAddCharge.Name = "gbAddCharge";
            this.gbAddCharge.Size = new System.Drawing.Size(732, 163);
            this.gbAddCharge.TabIndex = 18;
            this.gbAddCharge.TabStop = false;
            this.gbAddCharge.Text = "Additional Charges";
            // 
            // tlpAddCharge
            // 
            this.tlpAddCharge.AutoScroll = true;
            this.tlpAddCharge.ColumnCount = 4;
            this.tlpAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAddCharge.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddCharge.Controls.Add(this.lbAddCharge1, 0, 0);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge1, 1, 0);
            this.tlpAddCharge.Controls.Add(this.lbAddCharge2, 0, 1);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge2, 1, 1);
            this.tlpAddCharge.Controls.Add(this.lbAddCharge3, 0, 2);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge3, 1, 2);
            this.tlpAddCharge.Controls.Add(this.lbAddCharge4, 2, 0);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge4, 3, 0);
            this.tlpAddCharge.Controls.Add(this.lbAddCharge5, 2, 1);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge5, 3, 1);
            this.tlpAddCharge.Controls.Add(this.lbAddCharge6, 2, 2);
            this.tlpAddCharge.Controls.Add(this.tbAddCharge6, 3, 2);
            this.tlpAddCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddCharge.Location = new System.Drawing.Point(3, 19);
            this.tlpAddCharge.Name = "tlpAddCharge";
            this.tlpAddCharge.RowCount = 3;
            this.tlpAddCharge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddCharge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddCharge.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAddCharge.Size = new System.Drawing.Size(726, 141);
            this.tlpAddCharge.TabIndex = 19;
            // 
            // lbAddCharge1
            // 
            this.lbAddCharge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge1.FormattingEnabled = true;
            this.lbAddCharge1.Location = new System.Drawing.Point(3, 3);
            this.lbAddCharge1.Name = "lbAddCharge1";
            this.lbAddCharge1.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge1.TabIndex = 0;
            this.lbAddCharge1.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge1
            // 
            this.tbAddCharge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge1.Location = new System.Drawing.Point(220, 3);
            this.tbAddCharge1.Name = "tbAddCharge1";
            this.tbAddCharge1.Size = new System.Drawing.Size(139, 23);
            this.tbAddCharge1.TabIndex = 6;
            this.tbAddCharge1.Text = "0.00";
            this.tbAddCharge1.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge1.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbAddCharge2
            // 
            this.lbAddCharge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge2.FormattingEnabled = true;
            this.lbAddCharge2.Location = new System.Drawing.Point(3, 50);
            this.lbAddCharge2.Name = "lbAddCharge2";
            this.lbAddCharge2.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge2.TabIndex = 1;
            this.lbAddCharge2.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge2
            // 
            this.tbAddCharge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge2.Location = new System.Drawing.Point(220, 50);
            this.tbAddCharge2.Name = "tbAddCharge2";
            this.tbAddCharge2.Size = new System.Drawing.Size(139, 23);
            this.tbAddCharge2.TabIndex = 8;
            this.tbAddCharge2.Text = "0.00";
            this.tbAddCharge2.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge2.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbAddCharge3
            // 
            this.lbAddCharge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge3.FormattingEnabled = true;
            this.lbAddCharge3.Location = new System.Drawing.Point(3, 97);
            this.lbAddCharge3.Name = "lbAddCharge3";
            this.lbAddCharge3.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge3.TabIndex = 2;
            this.lbAddCharge3.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge3
            // 
            this.tbAddCharge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge3.Location = new System.Drawing.Point(220, 97);
            this.tbAddCharge3.Name = "tbAddCharge3";
            this.tbAddCharge3.Size = new System.Drawing.Size(139, 23);
            this.tbAddCharge3.TabIndex = 10;
            this.tbAddCharge3.Text = "0.00";
            this.tbAddCharge3.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge3.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbAddCharge4
            // 
            this.lbAddCharge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge4.FormattingEnabled = true;
            this.lbAddCharge4.Location = new System.Drawing.Point(365, 3);
            this.lbAddCharge4.Name = "lbAddCharge4";
            this.lbAddCharge4.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge4.TabIndex = 3;
            this.lbAddCharge4.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge4
            // 
            this.tbAddCharge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge4.Location = new System.Drawing.Point(582, 3);
            this.tbAddCharge4.Name = "tbAddCharge4";
            this.tbAddCharge4.Size = new System.Drawing.Size(141, 23);
            this.tbAddCharge4.TabIndex = 7;
            this.tbAddCharge4.Text = "0.00";
            this.tbAddCharge4.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge4.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbAddCharge5
            // 
            this.lbAddCharge5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge5.FormattingEnabled = true;
            this.lbAddCharge5.Location = new System.Drawing.Point(365, 50);
            this.lbAddCharge5.Name = "lbAddCharge5";
            this.lbAddCharge5.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge5.TabIndex = 4;
            this.lbAddCharge5.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge5
            // 
            this.tbAddCharge5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge5.Location = new System.Drawing.Point(582, 50);
            this.tbAddCharge5.Name = "tbAddCharge5";
            this.tbAddCharge5.Size = new System.Drawing.Size(141, 23);
            this.tbAddCharge5.TabIndex = 9;
            this.tbAddCharge5.Text = "0.00";
            this.tbAddCharge5.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge5.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbAddCharge6
            // 
            this.lbAddCharge6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCharge6.FormattingEnabled = true;
            this.lbAddCharge6.Location = new System.Drawing.Point(365, 97);
            this.lbAddCharge6.Name = "lbAddCharge6";
            this.lbAddCharge6.Size = new System.Drawing.Size(211, 24);
            this.lbAddCharge6.TabIndex = 5;
            this.lbAddCharge6.Click += new System.EventHandler(this.lbAddCharge_Click);
            // 
            // tbAddCharge6
            // 
            this.tbAddCharge6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddCharge6.Location = new System.Drawing.Point(582, 97);
            this.tbAddCharge6.Name = "tbAddCharge6";
            this.tbAddCharge6.Size = new System.Drawing.Size(141, 23);
            this.tbAddCharge6.TabIndex = 11;
            this.tbAddCharge6.Text = "0.00";
            this.tbAddCharge6.Click += new System.EventHandler(this.tbAddCharge_Click);
            this.tbAddCharge6.TextChanged += new System.EventHandler(this.tbAddCharge_TextChanged);
            this.tbAddCharge6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // lbSgst
            // 
            this.lbSgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSgst.AutoSize = true;
            this.lbSgst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbSgst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSgst.Location = new System.Drawing.Point(3, 7);
            this.lbSgst.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
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
            this.tbSgst.Location = new System.Drawing.Point(54, 3);
            this.tbSgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbSgst.Name = "tbSgst";
            this.tbSgst.Size = new System.Drawing.Size(59, 25);
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
            this.lbCgst.Location = new System.Drawing.Point(119, 7);
            this.lbCgst.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
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
            this.tbCgst.Location = new System.Drawing.Point(171, 3);
            this.tbCgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbCgst.Name = "tbCgst";
            this.tbCgst.Size = new System.Drawing.Size(59, 25);
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
            this.lbIgst.Location = new System.Drawing.Point(243, 7);
            this.lbIgst.Margin = new System.Windows.Forms.Padding(10, 7, 3, 3);
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
            this.tbIgst.Location = new System.Drawing.Point(289, 3);
            this.tbIgst.MinimumSize = new System.Drawing.Size(51, 26);
            this.tbIgst.Name = "tbIgst";
            this.tbIgst.Size = new System.Drawing.Size(59, 25);
            this.tbIgst.TabIndex = 15;
            this.tbIgst.TextChanged += new System.EventHandler(this.tbGst_TextChanged);
            this.tbIgst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.column_KeyPress);
            // 
            // flpBillShip
            // 
            this.flpBillShip.Controls.Add(this.gbBilling);
            this.flpBillShip.Controls.Add(this.gbShipping);
            this.flpBillShip.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBillShip.Location = new System.Drawing.Point(0, 100);
            this.flpBillShip.Name = "flpBillShip";
            this.flpBillShip.Size = new System.Drawing.Size(759, 240);
            this.flpBillShip.TabIndex = 1;
            // 
            // flpA
            // 
            this.flpA.Controls.Add(this.gbInvoice);
            this.flpA.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpA.Location = new System.Drawing.Point(0, 0);
            this.flpA.Name = "flpA";
            this.flpA.Size = new System.Drawing.Size(759, 100);
            this.flpA.TabIndex = 0;
            // 
            // flpGst
            // 
            this.flpGst.Controls.Add(this.lbSgst);
            this.flpGst.Controls.Add(this.tbSgst);
            this.flpGst.Controls.Add(this.lbCgst);
            this.flpGst.Controls.Add(this.tbCgst);
            this.flpGst.Controls.Add(this.lbIgst);
            this.flpGst.Controls.Add(this.tbIgst);
            this.flpGst.Controls.Add(this.cbBillAndShip);
            this.flpGst.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpGst.Location = new System.Drawing.Point(0, 340);
            this.flpGst.Name = "flpGst";
            this.flpGst.Size = new System.Drawing.Size(759, 33);
            this.flpGst.TabIndex = 25;
            // 
            // flpAddCharge
            // 
            this.flpAddCharge.Controls.Add(this.gbAddCharge);
            this.flpAddCharge.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpAddCharge.Location = new System.Drawing.Point(0, 578);
            this.flpAddCharge.Name = "flpAddCharge";
            this.flpAddCharge.Size = new System.Drawing.Size(759, 171);
            this.flpAddCharge.TabIndex = 26;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(776, 562);
            this.Controls.Add(this.tlpTotals);
            this.Controls.Add(this.flpAddCharge);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.flpGst);
            this.Controls.Add(this.flpBillShip);
            this.Controls.Add(this.flpA);
            this.Controls.Add(this.flpPanelButtons);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(775, 367);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Billing";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResizeEnd += new System.EventHandler(this.Invoice_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Invoice_ResizeEnd);
            this.gbBilling.ResumeLayout(false);
            this.gbBilling.PerformLayout();
            this.gbInvoice.ResumeLayout(false);
            this.tlpInvoice.ResumeLayout(false);
            this.tlpInvoice.PerformLayout();
            this.gbShipping.ResumeLayout(false);
            this.gbShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tlpTotals.ResumeLayout(false);
            this.tlpTotals.PerformLayout();
            this.flpPanelButtons.ResumeLayout(false);
            this.flpPanelButtons.PerformLayout();
            this.gbAddCharge.ResumeLayout(false);
            this.tlpAddCharge.ResumeLayout(false);
            this.tlpAddCharge.PerformLayout();
            this.flpBillShip.ResumeLayout(false);
            this.flpA.ResumeLayout(false);
            this.flpGst.ResumeLayout(false);
            this.flpGst.PerformLayout();
            this.flpAddCharge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.GroupBox gbInvoice;
        private System.Windows.Forms.Label lbInvoiceNo;
        private System.Windows.Forms.TableLayoutPanel tlpInvoice;
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
        private System.Windows.Forms.TableLayoutPanel tlpTotals;
        private System.Windows.Forms.Label lbSgstT;
        private System.Windows.Forms.Label lbTaxableVal;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbFinalTotal;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbTotalDiscount;
        private System.Windows.Forms.Label lbTotalTaxVal;
        private System.Windows.Forms.Label lbTotalSgst;
        private System.Windows.Forms.Label lbTotalAll;
        private System.Windows.Forms.ComboBox cbBillState;
        private System.Windows.Forms.ComboBox cbShipState;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.FlowLayoutPanel flpPanelButtons;
        private System.Windows.Forms.GroupBox gbAddCharge;
        private System.Windows.Forms.Label lbSgst;
        private System.Windows.Forms.TextBox tbSgst;
        private System.Windows.Forms.Label lbCgst;
        private System.Windows.Forms.TextBox tbCgst;
        private System.Windows.Forms.Label lbIgst;
        private System.Windows.Forms.TextBox tbIgst;
        private System.Windows.Forms.ComboBox cbBillName;
        private System.Windows.Forms.Label lbCgstT;
        private System.Windows.Forms.Label lbTotalFinal;
        private System.Windows.Forms.Label lbTotalIgst;
        private System.Windows.Forms.Label lbTotalCgst;
        private System.Windows.Forms.Label lbIgstT;
        private System.Windows.Forms.TableLayoutPanel tlpAddCharge;
        private System.Windows.Forms.ComboBox lbAddCharge1;
        private System.Windows.Forms.ComboBox lbAddCharge2;
        private System.Windows.Forms.ComboBox lbAddCharge3;
        private System.Windows.Forms.ComboBox lbAddCharge4;
        private System.Windows.Forms.ComboBox lbAddCharge5;
        private System.Windows.Forms.ComboBox lbAddCharge6;
        private System.Windows.Forms.TextBox tbAddCharge6;
        private System.Windows.Forms.TextBox tbAddCharge3;
        private System.Windows.Forms.TextBox tbAddCharge5;
        private System.Windows.Forms.TextBox tbAddCharge2;
        private System.Windows.Forms.TextBox tbAddCharge4;
        private System.Windows.Forms.TextBox tbAddCharge1;
        private System.Windows.Forms.Label lbInvoiceDate;
        private System.Windows.Forms.DateTimePicker tbInvoiceDate;
        private System.Windows.Forms.Label lbChallan;
        private System.Windows.Forms.Button btnAddChallan;
        private System.Windows.Forms.Button btnClearChallan;
        private System.Windows.Forms.TextBox tbChallanNumber;
        private System.Windows.Forms.Label lbAddedChallan;
        private System.Windows.Forms.FlowLayoutPanel flpBillShip;
        private System.Windows.Forms.FlowLayoutPanel flpA;
        private System.Windows.Forms.FlowLayoutPanel flpGst;
        private System.Windows.Forms.FlowLayoutPanel flpAddCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHsnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxableVal;
        private System.Windows.Forms.TextBox tbBillLandmark;
        private System.Windows.Forms.Label lbBillLandmark;
        private System.Windows.Forms.TextBox tbShipLandmark;
        private System.Windows.Forms.Label lbShipLandmark;
        private System.Windows.Forms.TextBox tbBillCity;
        private System.Windows.Forms.Label lbBillCity;
        private System.Windows.Forms.TextBox tbShipCity;
        private System.Windows.Forms.Label lbShipCity;
        private System.Windows.Forms.TextBox tbBillPin;
        private System.Windows.Forms.Label lbBillPin;
        private System.Windows.Forms.TextBox tbShipPin;
        private System.Windows.Forms.Label lbShipPin;
        private System.Windows.Forms.TextBox tbBillName;
    }
}

