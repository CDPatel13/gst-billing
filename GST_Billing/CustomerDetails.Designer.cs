namespace GST_Billing
{
	partial class CustomerDetails
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
            this.components = new System.ComponentModel.Container();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbGstin = new System.Windows.Forms.TextBox();
            this.lbGstin = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.ComboBox();
            this.gbBilling = new System.Windows.Forms.GroupBox();
            this.lbLandmark = new System.Windows.Forms.Label();
            this.tbLandmark = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbPinCode = new System.Windows.Forms.Label();
            this.tbPinCode = new System.Windows.Forms.TextBox();
            this.lbAadhar = new System.Windows.Forms.Label();
            this.tbAadharNo = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lbPanNo = new System.Windows.Forms.Label();
            this.tbPanNo = new System.Windows.Forms.TextBox();
            this.lbPayment = new System.Windows.Forms.Label();
            this.tbPayment = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbShipping = new System.Windows.Forms.GroupBox();
            this.cbBillShip = new System.Windows.Forms.CheckBox();
            this.lbShipName = new System.Windows.Forms.Label();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.lbShipAddress = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lbShipLandmark = new System.Windows.Forms.Label();
            this.tbShipLandmark = new System.Windows.Forms.TextBox();
            this.lbShipCity = new System.Windows.Forms.Label();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.lbShipPinCode = new System.Windows.Forms.Label();
            this.tbShipPinCode = new System.Windows.Forms.TextBox();
            this.lbShipState = new System.Windows.Forms.Label();
            this.tbShipState = new System.Windows.Forms.ComboBox();
            this.lbShipCode = new System.Windows.Forms.Label();
            this.tbShipCode = new System.Windows.Forms.TextBox();
            this.lbShipGstin = new System.Windows.Forms.Label();
            this.tbShipGstin = new System.Windows.Forms.TextBox();
            this.lbShipPhone = new System.Windows.Forms.Label();
            this.tbShipPhone = new System.Windows.Forms.TextBox();
            this.lbShipEmail = new System.Windows.Forms.Label();
            this.tbShipEmail = new System.Windows.Forms.TextBox();
            this.lbShipAadhar = new System.Windows.Forms.Label();
            this.tbShipAadhar = new System.Windows.Forms.TextBox();
            this.lbShipPanNumber = new System.Windows.Forms.Label();
            this.tbShipPanNumber = new System.Windows.Forms.TextBox();
            this.lbShipContact = new System.Windows.Forms.Label();
            this.tbShipContact = new System.Windows.Forms.TextBox();
            this.lbShipPayment = new System.Windows.Forms.Label();
            this.tbShipPayment = new System.Windows.Forms.ComboBox();
            this.errorProviderBilling = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderShipping = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbBilling.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShipping)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(75, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(128, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(614, 23);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(128, 45);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(614, 23);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(56, 48);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 16);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Address";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(505, 161);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 23);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(449, 165);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 16);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "E-mail";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.Location = new System.Drawing.Point(505, 132);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(237, 23);
            this.tbPhoneNo.TabIndex = 7;
            this.tbPhoneNo.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(423, 136);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(76, 16);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone No";
            // 
            // tbGstin
            // 
            this.tbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGstin.Location = new System.Drawing.Point(128, 162);
            this.tbGstin.MaxLength = 15;
            this.tbGstin.Name = "tbGstin";
            this.tbGstin.Size = new System.Drawing.Size(237, 23);
            this.tbGstin.TabIndex = 9;
            this.tbGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbGstin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlphaNumeric_KeyPress);
            // 
            // lbGstin
            // 
            this.lbGstin.AutoSize = true;
            this.lbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGstin.Location = new System.Drawing.Point(72, 165);
            this.lbGstin.Name = "lbGstin";
            this.lbGstin.Size = new System.Drawing.Size(50, 16);
            this.lbGstin.TabIndex = 12;
            this.lbGstin.Text = "GSTIN";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(763, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(78, 106);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(44, 16);
            this.lbState.TabIndex = 15;
            this.lbState.Text = "State";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(128, 133);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(237, 23);
            this.tbCode.TabIndex = 6;
            this.tbCode.Click += new System.EventHandler(this.tbCode_Click);
            this.tbCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            this.tbCode.Leave += new System.EventHandler(this.tbCode_LeaveFocus);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCode.Location = new System.Drawing.Point(77, 136);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(45, 16);
            this.lbCode.TabIndex = 17;
            this.lbCode.Text = "Code";
            // 
            // tbState
            // 
            this.tbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbState.DropDownHeight = 100;
            this.tbState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.FormattingEnabled = true;
            this.tbState.IntegralHeight = false;
            this.tbState.Items.AddRange(new object[] {
            "Andaman And Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chattisgarh",
            "Dadra And Nagar Haveli",
            "Daman And Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu And Kashmir",
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
            this.tbState.Location = new System.Drawing.Point(128, 103);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(237, 24);
            this.tbState.TabIndex = 5;
            this.tbState.SelectedIndexChanged += new System.EventHandler(this.tbState_SelectedIndexChanged);
            this.tbState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbState.Leave += new System.EventHandler(this.tbState_SelectedIndexChanged);
            // 
            // gbBilling
            // 
            this.gbBilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBilling.Controls.Add(this.lbName);
            this.gbBilling.Controls.Add(this.tbName);
            this.gbBilling.Controls.Add(this.lbAddress);
            this.gbBilling.Controls.Add(this.tbAddress);
            this.gbBilling.Controls.Add(this.lbLandmark);
            this.gbBilling.Controls.Add(this.tbLandmark);
            this.gbBilling.Controls.Add(this.lbCity);
            this.gbBilling.Controls.Add(this.tbCity);
            this.gbBilling.Controls.Add(this.lbPinCode);
            this.gbBilling.Controls.Add(this.tbPinCode);
            this.gbBilling.Controls.Add(this.lbState);
            this.gbBilling.Controls.Add(this.tbState);
            this.gbBilling.Controls.Add(this.lbCode);
            this.gbBilling.Controls.Add(this.tbCode);
            this.gbBilling.Controls.Add(this.lbGstin);
            this.gbBilling.Controls.Add(this.tbGstin);
            this.gbBilling.Controls.Add(this.lbPhone);
            this.gbBilling.Controls.Add(this.tbPhoneNo);
            this.gbBilling.Controls.Add(this.lbEmail);
            this.gbBilling.Controls.Add(this.tbEmail);
            this.gbBilling.Controls.Add(this.lbAadhar);
            this.gbBilling.Controls.Add(this.tbAadharNo);
            this.gbBilling.Controls.Add(this.lbContact);
            this.gbBilling.Controls.Add(this.tbContact);
            this.gbBilling.Controls.Add(this.lbPanNo);
            this.gbBilling.Controls.Add(this.tbPanNo);
            this.gbBilling.Controls.Add(this.lbPayment);
            this.gbBilling.Controls.Add(this.tbPayment);
            this.gbBilling.Location = new System.Drawing.Point(3, 3);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(757, 247);
            this.gbBilling.TabIndex = 19;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "Billing Details";
            // 
            // lbLandmark
            // 
            this.lbLandmark.AutoSize = true;
            this.lbLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLandmark.Location = new System.Drawing.Point(46, 77);
            this.lbLandmark.Name = "lbLandmark";
            this.lbLandmark.Size = new System.Drawing.Size(76, 16);
            this.lbLandmark.TabIndex = 20;
            this.lbLandmark.Text = "Landmark";
            // 
            // tbLandmark
            // 
            this.tbLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLandmark.Location = new System.Drawing.Point(128, 74);
            this.tbLandmark.Name = "tbLandmark";
            this.tbLandmark.Size = new System.Drawing.Size(237, 23);
            this.tbLandmark.TabIndex = 2;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(465, 77);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 16);
            this.lbCity.TabIndex = 22;
            this.lbCity.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(505, 74);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(237, 23);
            this.tbCity.TabIndex = 3;
            this.tbCity.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbPinCode
            // 
            this.lbPinCode.AutoSize = true;
            this.lbPinCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPinCode.Location = new System.Drawing.Point(429, 106);
            this.lbPinCode.Name = "lbPinCode";
            this.lbPinCode.Size = new System.Drawing.Size(71, 16);
            this.lbPinCode.TabIndex = 26;
            this.lbPinCode.Text = "Pin Code";
            // 
            // tbPinCode
            // 
            this.tbPinCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinCode.Location = new System.Drawing.Point(505, 103);
            this.tbPinCode.MaxLength = 6;
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.Size = new System.Drawing.Size(237, 23);
            this.tbPinCode.TabIndex = 4;
            this.tbPinCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbPinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbAadhar
            // 
            this.lbAadhar.AutoSize = true;
            this.lbAadhar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAadhar.Location = new System.Drawing.Point(42, 192);
            this.lbAadhar.Name = "lbAadhar";
            this.lbAadhar.Size = new System.Drawing.Size(80, 16);
            this.lbAadhar.TabIndex = 32;
            this.lbAadhar.Text = "Aadhar No";
            // 
            // tbAadharNo
            // 
            this.tbAadharNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAadharNo.Location = new System.Drawing.Point(128, 191);
            this.tbAadharNo.MaxLength = 12;
            this.tbAadharNo.Name = "tbAadharNo";
            this.tbAadharNo.Size = new System.Drawing.Size(237, 23);
            this.tbAadharNo.TabIndex = 10;
            this.tbAadharNo.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbAadharNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(6, 223);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(116, 16);
            this.lbContact.TabIndex = 30;
            this.lbContact.Text = "Contact Person";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(128, 220);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(237, 23);
            this.tbContact.TabIndex = 12;
            this.tbContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbPanNo
            // 
            this.lbPanNo.AutoSize = true;
            this.lbPanNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanNo.Location = new System.Drawing.Point(441, 194);
            this.lbPanNo.Name = "lbPanNo";
            this.lbPanNo.Size = new System.Drawing.Size(58, 16);
            this.lbPanNo.TabIndex = 24;
            this.lbPanNo.Text = "PAN No";
            // 
            // tbPanNo
            // 
            this.tbPanNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPanNo.Location = new System.Drawing.Point(505, 190);
            this.tbPanNo.MaxLength = 10;
            this.tbPanNo.Name = "tbPanNo";
            this.tbPanNo.Size = new System.Drawing.Size(237, 23);
            this.tbPanNo.TabIndex = 11;
            this.tbPanNo.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbPanNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlphaNumeric_KeyPress);
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.Location = new System.Drawing.Point(386, 223);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(113, 16);
            this.lbPayment.TabIndex = 34;
            this.lbPayment.Text = "Payment Terms";
            // 
            // tbPayment
            // 
            this.tbPayment.Font = new System.Drawing.Font("Arial", 10F);
            this.tbPayment.FormattingEnabled = true;
            this.tbPayment.Location = new System.Drawing.Point(505, 219);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(237, 24);
            this.tbPayment.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.gbBilling);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 256);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.gbShipping);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 256);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(763, 256);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // gbShipping
            // 
            this.gbShipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbShipping.Controls.Add(this.cbBillShip);
            this.gbShipping.Controls.Add(this.lbShipName);
            this.gbShipping.Controls.Add(this.tbShipName);
            this.gbShipping.Controls.Add(this.lbShipAddress);
            this.gbShipping.Controls.Add(this.tbShipAddress);
            this.gbShipping.Controls.Add(this.lbShipLandmark);
            this.gbShipping.Controls.Add(this.tbShipLandmark);
            this.gbShipping.Controls.Add(this.lbShipCity);
            this.gbShipping.Controls.Add(this.tbShipCity);
            this.gbShipping.Controls.Add(this.lbShipPinCode);
            this.gbShipping.Controls.Add(this.tbShipPinCode);
            this.gbShipping.Controls.Add(this.lbShipState);
            this.gbShipping.Controls.Add(this.tbShipState);
            this.gbShipping.Controls.Add(this.lbShipCode);
            this.gbShipping.Controls.Add(this.tbShipCode);
            this.gbShipping.Controls.Add(this.lbShipGstin);
            this.gbShipping.Controls.Add(this.tbShipGstin);
            this.gbShipping.Controls.Add(this.lbShipPhone);
            this.gbShipping.Controls.Add(this.tbShipPhone);
            this.gbShipping.Controls.Add(this.lbShipEmail);
            this.gbShipping.Controls.Add(this.tbShipEmail);
            this.gbShipping.Controls.Add(this.lbShipAadhar);
            this.gbShipping.Controls.Add(this.tbShipAadhar);
            this.gbShipping.Controls.Add(this.lbShipPanNumber);
            this.gbShipping.Controls.Add(this.tbShipPanNumber);
            this.gbShipping.Controls.Add(this.lbShipContact);
            this.gbShipping.Controls.Add(this.tbShipContact);
            this.gbShipping.Controls.Add(this.lbShipPayment);
            this.gbShipping.Controls.Add(this.tbShipPayment);
            this.gbShipping.Location = new System.Drawing.Point(3, 3);
            this.gbShipping.Name = "gbShipping";
            this.gbShipping.Size = new System.Drawing.Size(757, 247);
            this.gbShipping.TabIndex = 19;
            this.gbShipping.TabStop = false;
            this.gbShipping.Text = "Shipping Details";
            // 
            // cbBillShip
            // 
            this.cbBillShip.AutoSize = true;
            this.cbBillShip.Checked = true;
            this.cbBillShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBillShip.Location = new System.Drawing.Point(499, 18);
            this.cbBillShip.Name = "cbBillShip";
            this.cbBillShip.Size = new System.Drawing.Size(249, 20);
            this.cbBillShip.TabIndex = 14;
            this.cbBillShip.Text = "Shipping details same as above";
            this.cbBillShip.UseVisualStyleBackColor = true;
            this.cbBillShip.CheckedChanged += new System.EventHandler(this.cbBillShip_CheckedChanged);
            // 
            // lbShipName
            // 
            this.lbShipName.AutoSize = true;
            this.lbShipName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipName.Location = new System.Drawing.Point(75, 19);
            this.lbShipName.Name = "lbShipName";
            this.lbShipName.Size = new System.Drawing.Size(47, 16);
            this.lbShipName.TabIndex = 0;
            this.lbShipName.Text = "Name";
            // 
            // tbShipName
            // 
            this.tbShipName.Enabled = false;
            this.tbShipName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipName.Location = new System.Drawing.Point(128, 16);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(237, 23);
            this.tbShipName.TabIndex = 15;
            // 
            // lbShipAddress
            // 
            this.lbShipAddress.AutoSize = true;
            this.lbShipAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipAddress.Location = new System.Drawing.Point(56, 48);
            this.lbShipAddress.Name = "lbShipAddress";
            this.lbShipAddress.Size = new System.Drawing.Size(66, 16);
            this.lbShipAddress.TabIndex = 6;
            this.lbShipAddress.Text = "Address";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Enabled = false;
            this.tbShipAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipAddress.Location = new System.Drawing.Point(128, 45);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(614, 23);
            this.tbShipAddress.TabIndex = 16;
            this.tbShipAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipLandmark
            // 
            this.lbShipLandmark.AutoSize = true;
            this.lbShipLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipLandmark.Location = new System.Drawing.Point(46, 77);
            this.lbShipLandmark.Name = "lbShipLandmark";
            this.lbShipLandmark.Size = new System.Drawing.Size(76, 16);
            this.lbShipLandmark.TabIndex = 20;
            this.lbShipLandmark.Text = "Landmark";
            // 
            // tbShipLandmark
            // 
            this.tbShipLandmark.Enabled = false;
            this.tbShipLandmark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipLandmark.Location = new System.Drawing.Point(128, 74);
            this.tbShipLandmark.Name = "tbShipLandmark";
            this.tbShipLandmark.Size = new System.Drawing.Size(237, 23);
            this.tbShipLandmark.TabIndex = 17;
            this.tbShipLandmark.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipCity
            // 
            this.lbShipCity.AutoSize = true;
            this.lbShipCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipCity.Location = new System.Drawing.Point(465, 77);
            this.lbShipCity.Name = "lbShipCity";
            this.lbShipCity.Size = new System.Drawing.Size(34, 16);
            this.lbShipCity.TabIndex = 22;
            this.lbShipCity.Text = "City";
            // 
            // tbShipCity
            // 
            this.tbShipCity.Enabled = false;
            this.tbShipCity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipCity.Location = new System.Drawing.Point(505, 74);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(237, 23);
            this.tbShipCity.TabIndex = 18;
            this.tbShipCity.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipPinCode
            // 
            this.lbShipPinCode.AutoSize = true;
            this.lbShipPinCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipPinCode.Location = new System.Drawing.Point(428, 106);
            this.lbShipPinCode.Name = "lbShipPinCode";
            this.lbShipPinCode.Size = new System.Drawing.Size(71, 16);
            this.lbShipPinCode.TabIndex = 26;
            this.lbShipPinCode.Text = "Pin Code";
            // 
            // tbShipPinCode
            // 
            this.tbShipPinCode.Enabled = false;
            this.tbShipPinCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipPinCode.Location = new System.Drawing.Point(505, 103);
            this.tbShipPinCode.MaxLength = 6;
            this.tbShipPinCode.Name = "tbShipPinCode";
            this.tbShipPinCode.Size = new System.Drawing.Size(237, 23);
            this.tbShipPinCode.TabIndex = 19;
            this.tbShipPinCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipPinCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbShipState
            // 
            this.lbShipState.AutoSize = true;
            this.lbShipState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipState.Location = new System.Drawing.Point(78, 106);
            this.lbShipState.Name = "lbShipState";
            this.lbShipState.Size = new System.Drawing.Size(44, 16);
            this.lbShipState.TabIndex = 15;
            this.lbShipState.Text = "State";
            // 
            // tbShipState
            // 
            this.tbShipState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbShipState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tbShipState.DropDownHeight = 100;
            this.tbShipState.Enabled = false;
            this.tbShipState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipState.FormattingEnabled = true;
            this.tbShipState.IntegralHeight = false;
            this.tbShipState.Items.AddRange(new object[] {
            "Andaman And Nicobar Islands",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chattisgarh",
            "Dadra And Nagar Haveli",
            "Daman And Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu And Kashmir",
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
            this.tbShipState.Location = new System.Drawing.Point(128, 103);
            this.tbShipState.Name = "tbShipState";
            this.tbShipState.Size = new System.Drawing.Size(237, 24);
            this.tbShipState.TabIndex = 20;
            this.tbShipState.SelectedIndexChanged += new System.EventHandler(this.tbState_SelectedIndexChanged);
            this.tbShipState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipState.Leave += new System.EventHandler(this.tbState_SelectedIndexChanged);
            // 
            // lbShipCode
            // 
            this.lbShipCode.AutoSize = true;
            this.lbShipCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipCode.Location = new System.Drawing.Point(77, 136);
            this.lbShipCode.Name = "lbShipCode";
            this.lbShipCode.Size = new System.Drawing.Size(45, 16);
            this.lbShipCode.TabIndex = 17;
            this.lbShipCode.Text = "Code";
            // 
            // tbShipCode
            // 
            this.tbShipCode.Enabled = false;
            this.tbShipCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipCode.Location = new System.Drawing.Point(128, 133);
            this.tbShipCode.Name = "tbShipCode";
            this.tbShipCode.Size = new System.Drawing.Size(237, 23);
            this.tbShipCode.TabIndex = 21;
            this.tbShipCode.Click += new System.EventHandler(this.tbCode_Click);
            this.tbShipCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            this.tbShipCode.Leave += new System.EventHandler(this.tbCode_LeaveFocus);
            // 
            // lbShipGstin
            // 
            this.lbShipGstin.AutoSize = true;
            this.lbShipGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipGstin.Location = new System.Drawing.Point(72, 165);
            this.lbShipGstin.Name = "lbShipGstin";
            this.lbShipGstin.Size = new System.Drawing.Size(50, 16);
            this.lbShipGstin.TabIndex = 12;
            this.lbShipGstin.Text = "GSTIN";
            // 
            // tbShipGstin
            // 
            this.tbShipGstin.Enabled = false;
            this.tbShipGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipGstin.Location = new System.Drawing.Point(128, 162);
            this.tbShipGstin.MaxLength = 15;
            this.tbShipGstin.Name = "tbShipGstin";
            this.tbShipGstin.Size = new System.Drawing.Size(237, 23);
            this.tbShipGstin.TabIndex = 24;
            this.tbShipGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipGstin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlphaNumeric_KeyPress);
            // 
            // lbShipPhone
            // 
            this.lbShipPhone.AutoSize = true;
            this.lbShipPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipPhone.Location = new System.Drawing.Point(423, 135);
            this.lbShipPhone.Name = "lbShipPhone";
            this.lbShipPhone.Size = new System.Drawing.Size(76, 16);
            this.lbShipPhone.TabIndex = 10;
            this.lbShipPhone.Text = "Phone No";
            // 
            // tbShipPhone
            // 
            this.tbShipPhone.Enabled = false;
            this.tbShipPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipPhone.Location = new System.Drawing.Point(505, 132);
            this.tbShipPhone.Name = "tbShipPhone";
            this.tbShipPhone.Size = new System.Drawing.Size(237, 23);
            this.tbShipPhone.TabIndex = 22;
            this.tbShipPhone.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbShipEmail
            // 
            this.lbShipEmail.AutoSize = true;
            this.lbShipEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipEmail.Location = new System.Drawing.Point(445, 165);
            this.lbShipEmail.Name = "lbShipEmail";
            this.lbShipEmail.Size = new System.Drawing.Size(50, 16);
            this.lbShipEmail.TabIndex = 8;
            this.lbShipEmail.Text = "E-mail";
            // 
            // tbShipEmail
            // 
            this.tbShipEmail.Enabled = false;
            this.tbShipEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipEmail.Location = new System.Drawing.Point(505, 161);
            this.tbShipEmail.Name = "tbShipEmail";
            this.tbShipEmail.Size = new System.Drawing.Size(237, 23);
            this.tbShipEmail.TabIndex = 23;
            this.tbShipEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipAadhar
            // 
            this.lbShipAadhar.AutoSize = true;
            this.lbShipAadhar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipAadhar.Location = new System.Drawing.Point(42, 192);
            this.lbShipAadhar.Name = "lbShipAadhar";
            this.lbShipAadhar.Size = new System.Drawing.Size(80, 16);
            this.lbShipAadhar.TabIndex = 32;
            this.lbShipAadhar.Text = "Aadhar No";
            // 
            // tbShipAadhar
            // 
            this.tbShipAadhar.Enabled = false;
            this.tbShipAadhar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipAadhar.Location = new System.Drawing.Point(128, 191);
            this.tbShipAadhar.MaxLength = 12;
            this.tbShipAadhar.Name = "tbShipAadhar";
            this.tbShipAadhar.Size = new System.Drawing.Size(237, 23);
            this.tbShipAadhar.TabIndex = 25;
            this.tbShipAadhar.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipAadhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lbShipPanNumber
            // 
            this.lbShipPanNumber.AutoSize = true;
            this.lbShipPanNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipPanNumber.Location = new System.Drawing.Point(442, 192);
            this.lbShipPanNumber.Name = "lbShipPanNumber";
            this.lbShipPanNumber.Size = new System.Drawing.Size(58, 16);
            this.lbShipPanNumber.TabIndex = 24;
            this.lbShipPanNumber.Text = "PAN No";
            // 
            // tbShipPanNumber
            // 
            this.tbShipPanNumber.Enabled = false;
            this.tbShipPanNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipPanNumber.Location = new System.Drawing.Point(505, 189);
            this.tbShipPanNumber.MaxLength = 10;
            this.tbShipPanNumber.Name = "tbShipPanNumber";
            this.tbShipPanNumber.Size = new System.Drawing.Size(237, 23);
            this.tbShipPanNumber.TabIndex = 26;
            this.tbShipPanNumber.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbShipPanNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlphaNumeric_KeyPress);
            // 
            // lbShipContact
            // 
            this.lbShipContact.AutoSize = true;
            this.lbShipContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipContact.Location = new System.Drawing.Point(6, 223);
            this.lbShipContact.Name = "lbShipContact";
            this.lbShipContact.Size = new System.Drawing.Size(116, 16);
            this.lbShipContact.TabIndex = 30;
            this.lbShipContact.Text = "Contact Person";
            // 
            // tbShipContact
            // 
            this.tbShipContact.Enabled = false;
            this.tbShipContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShipContact.Location = new System.Drawing.Point(128, 220);
            this.tbShipContact.Name = "tbShipContact";
            this.tbShipContact.Size = new System.Drawing.Size(237, 23);
            this.tbShipContact.TabIndex = 27;
            this.tbShipContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbShipPayment
            // 
            this.lbShipPayment.AutoSize = true;
            this.lbShipPayment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipPayment.Location = new System.Drawing.Point(386, 221);
            this.lbShipPayment.Name = "lbShipPayment";
            this.lbShipPayment.Size = new System.Drawing.Size(113, 16);
            this.lbShipPayment.TabIndex = 34;
            this.lbShipPayment.Text = "Payment Terms";
            // 
            // tbShipPayment
            // 
            this.tbShipPayment.Enabled = false;
            this.tbShipPayment.Font = new System.Drawing.Font("Arial", 10F);
            this.tbShipPayment.FormattingEnabled = true;
            this.tbShipPayment.Location = new System.Drawing.Point(505, 218);
            this.tbShipPayment.Name = "tbShipPayment";
            this.tbShipPayment.Size = new System.Drawing.Size(237, 24);
            this.tbShipPayment.TabIndex = 28;
            // 
            // errorProviderBilling
            // 
            this.errorProviderBilling.ContainerControl = this;
            // 
            // errorProviderShipping
            // 
            this.errorProviderShipping.ContainerControl = this;
            // 
            // CustomerDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(763, 544);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(779, 582);
            this.Name = "CustomerDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.gbBilling.ResumeLayout(false);
            this.gbBilling.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gbShipping.ResumeLayout(false);
            this.gbShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderShipping)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.TextBox tbPhoneNo;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.TextBox tbGstin;
		private System.Windows.Forms.Label lbGstin;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lbState;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.Label lbCode;
		private System.Windows.Forms.ComboBox tbState;
        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbLandmark;
        private System.Windows.Forms.Label lbLandmark;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbPanNo;
        private System.Windows.Forms.Label lbPanNo;
        private System.Windows.Forms.TextBox tbPinCode;
        private System.Windows.Forms.Label lbPinCode;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.TextBox tbAadharNo;
        private System.Windows.Forms.Label lbAadhar;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbShipping;
        private System.Windows.Forms.Label lbShipPayment;
        private System.Windows.Forms.TextBox tbShipAadhar;
        private System.Windows.Forms.Label lbShipAadhar;
        private System.Windows.Forms.TextBox tbShipContact;
        private System.Windows.Forms.Label lbShipContact;
        private System.Windows.Forms.TextBox tbShipPinCode;
        private System.Windows.Forms.Label lbShipPinCode;
        private System.Windows.Forms.TextBox tbShipPanNumber;
        private System.Windows.Forms.Label lbShipPanNumber;
        private System.Windows.Forms.TextBox tbShipCity;
        private System.Windows.Forms.Label lbShipCity;
        private System.Windows.Forms.TextBox tbShipLandmark;
        private System.Windows.Forms.Label lbShipLandmark;
        private System.Windows.Forms.Label lbShipName;
        private System.Windows.Forms.ComboBox tbShipState;
        private System.Windows.Forms.TextBox tbShipCode;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.Label lbShipCode;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lbShipState;
        private System.Windows.Forms.Label lbShipAddress;
        private System.Windows.Forms.TextBox tbShipEmail;
        private System.Windows.Forms.TextBox tbShipGstin;
        private System.Windows.Forms.Label lbShipEmail;
        private System.Windows.Forms.Label lbShipGstin;
        private System.Windows.Forms.Label lbShipPhone;
        private System.Windows.Forms.TextBox tbShipPhone;
        private System.Windows.Forms.CheckBox cbBillShip;
        private System.Windows.Forms.ComboBox tbPayment;
        private System.Windows.Forms.ComboBox tbShipPayment;
        private System.Windows.Forms.ErrorProvider errorProviderBilling;
        private System.Windows.Forms.ErrorProvider errorProviderShipping;
	}
}