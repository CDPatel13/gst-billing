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
			this.lbName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.lbAddress = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.lbEmail = new System.Windows.Forms.Label();
			this.tbContact = new System.Windows.Forms.TextBox();
			this.lbContact = new System.Windows.Forms.Label();
			this.tbGstin = new System.Windows.Forms.TextBox();
			this.lbGstin = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.blState = new System.Windows.Forms.Label();
			this.tbCode = new System.Windows.Forms.TextBox();
			this.lbCode = new System.Windows.Forms.Label();
			this.cbState = new System.Windows.Forms.ComboBox();
			this.gbBilling = new System.Windows.Forms.GroupBox();
			this.gbShipping = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbShipState = new System.Windows.Forms.ComboBox();
			this.tbShipCode = new System.Windows.Forms.TextBox();
			this.tbShipName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbShipAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbShipEmail = new System.Windows.Forms.TextBox();
			this.tbShipGstin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbShipContact = new System.Windows.Forms.TextBox();
			this.cbBillShip = new System.Windows.Forms.CheckBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.gbBilling.SuspendLayout();
			this.gbShipping.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbName.Location = new System.Drawing.Point(6, 19);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(47, 16);
			this.lbName.TabIndex = 0;
			this.lbName.Text = "Name";
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbName.Location = new System.Drawing.Point(84, 16);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(199, 23);
			this.tbName.TabIndex = 0;
			this.tbName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// tbAddress
			// 
			this.tbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddress.Location = new System.Drawing.Point(84, 45);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(250, 91);
			this.tbAddress.TabIndex = 1;
			this.tbAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddress.Location = new System.Drawing.Point(6, 48);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(66, 16);
			this.lbAddress.TabIndex = 6;
			this.lbAddress.Text = "Address";
			// 
			// tbEmail
			// 
			this.tbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEmail.Location = new System.Drawing.Point(84, 142);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(250, 23);
			this.tbEmail.TabIndex = 2;
			this.tbEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmail.Location = new System.Drawing.Point(5, 145);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(50, 16);
			this.lbEmail.TabIndex = 8;
			this.lbEmail.Text = "E-mail";
			// 
			// tbContact
			// 
			this.tbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContact.Location = new System.Drawing.Point(84, 174);
			this.tbContact.Name = "tbContact";
			this.tbContact.Size = new System.Drawing.Size(250, 23);
			this.tbContact.TabIndex = 3;
			this.tbContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
			// 
			// lbContact
			// 
			this.lbContact.AutoSize = true;
			this.lbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbContact.Location = new System.Drawing.Point(5, 177);
			this.lbContact.Name = "lbContact";
			this.lbContact.Size = new System.Drawing.Size(62, 16);
			this.lbContact.TabIndex = 10;
			this.lbContact.Text = "Contact";
			// 
			// tbGstin
			// 
			this.tbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGstin.Location = new System.Drawing.Point(84, 206);
			this.tbGstin.Name = "tbGstin";
			this.tbGstin.Size = new System.Drawing.Size(250, 23);
			this.tbGstin.TabIndex = 4;
			this.tbGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// lbGstin
			// 
			this.lbGstin.AutoSize = true;
			this.lbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGstin.Location = new System.Drawing.Point(5, 209);
			this.lbGstin.Name = "lbGstin";
			this.lbGstin.Size = new System.Drawing.Size(50, 16);
			this.lbGstin.TabIndex = 12;
			this.lbGstin.Text = "GSTIN";
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(0, 339);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(727, 29);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// blState
			// 
			this.blState.AutoSize = true;
			this.blState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.blState.Location = new System.Drawing.Point(5, 238);
			this.blState.Name = "blState";
			this.blState.Size = new System.Drawing.Size(44, 16);
			this.blState.TabIndex = 15;
			this.blState.Text = "State";
			// 
			// tbCode
			// 
			this.tbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCode.Location = new System.Drawing.Point(84, 264);
			this.tbCode.Name = "tbCode";
			this.tbCode.Size = new System.Drawing.Size(250, 23);
			this.tbCode.TabIndex = 6;
			this.tbCode.Click += new System.EventHandler(this.tbCode_Click);
			this.tbCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.tbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
			this.tbCode.Leave += new System.EventHandler(this.tbCode_LeaveFocus);
			// 
			// lbCode
			// 
			this.lbCode.AutoSize = true;
			this.lbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCode.Location = new System.Drawing.Point(5, 267);
			this.lbCode.Name = "lbCode";
			this.lbCode.Size = new System.Drawing.Size(45, 16);
			this.lbCode.TabIndex = 17;
			this.lbCode.Text = "Code";
			// 
			// cbState
			// 
			this.cbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbState.DropDownHeight = 100;
			this.cbState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbState.FormattingEnabled = true;
			this.cbState.IntegralHeight = false;
			this.cbState.Items.AddRange(new object[] {
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
			this.cbState.Location = new System.Drawing.Point(84, 235);
			this.cbState.Name = "cbState";
			this.cbState.Size = new System.Drawing.Size(250, 24);
			this.cbState.TabIndex = 5;
			this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
			this.cbState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// gbBilling
			// 
			this.gbBilling.Controls.Add(this.lbName);
			this.gbBilling.Controls.Add(this.cbState);
			this.gbBilling.Controls.Add(this.btnSearch);
			this.gbBilling.Controls.Add(this.tbCode);
			this.gbBilling.Controls.Add(this.tbName);
			this.gbBilling.Controls.Add(this.lbCode);
			this.gbBilling.Controls.Add(this.tbAddress);
			this.gbBilling.Controls.Add(this.blState);
			this.gbBilling.Controls.Add(this.lbAddress);
			this.gbBilling.Controls.Add(this.tbEmail);
			this.gbBilling.Controls.Add(this.tbGstin);
			this.gbBilling.Controls.Add(this.lbEmail);
			this.gbBilling.Controls.Add(this.lbGstin);
			this.gbBilling.Controls.Add(this.lbContact);
			this.gbBilling.Controls.Add(this.tbContact);
			this.gbBilling.Location = new System.Drawing.Point(12, 12);
			this.gbBilling.Name = "gbBilling";
			this.gbBilling.Size = new System.Drawing.Size(340, 294);
			this.gbBilling.TabIndex = 19;
			this.gbBilling.TabStop = false;
			this.gbBilling.Text = "Billing Details";
			// 
			// gbShipping
			// 
			this.gbShipping.Controls.Add(this.label1);
			this.gbShipping.Controls.Add(this.cbShipState);
			this.gbShipping.Controls.Add(this.tbShipCode);
			this.gbShipping.Controls.Add(this.tbShipName);
			this.gbShipping.Controls.Add(this.label2);
			this.gbShipping.Controls.Add(this.tbShipAddress);
			this.gbShipping.Controls.Add(this.label3);
			this.gbShipping.Controls.Add(this.label4);
			this.gbShipping.Controls.Add(this.tbShipEmail);
			this.gbShipping.Controls.Add(this.tbShipGstin);
			this.gbShipping.Controls.Add(this.label5);
			this.gbShipping.Controls.Add(this.label6);
			this.gbShipping.Controls.Add(this.label7);
			this.gbShipping.Controls.Add(this.tbShipContact);
			this.gbShipping.Enabled = false;
			this.gbShipping.Location = new System.Drawing.Point(358, 12);
			this.gbShipping.Name = "gbShipping";
			this.gbShipping.Size = new System.Drawing.Size(340, 294);
			this.gbShipping.TabIndex = 20;
			this.gbShipping.TabStop = false;
			this.gbShipping.Text = "Shipping Details";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// cbShipState
			// 
			this.cbShipState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbShipState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbShipState.DropDownHeight = 100;
			this.cbShipState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbShipState.FormattingEnabled = true;
			this.cbShipState.IntegralHeight = false;
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
			this.cbShipState.Location = new System.Drawing.Point(84, 235);
			this.cbShipState.Name = "cbShipState";
			this.cbShipState.Size = new System.Drawing.Size(250, 24);
			this.cbShipState.TabIndex = 5;
			this.cbShipState.SelectedIndexChanged += new System.EventHandler(this.cbShipState_SelectedIndexChanged);
			this.cbShipState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// tbShipCode
			// 
			this.tbShipCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipCode.Location = new System.Drawing.Point(84, 264);
			this.tbShipCode.Name = "tbShipCode";
			this.tbShipCode.Size = new System.Drawing.Size(250, 23);
			this.tbShipCode.TabIndex = 6;
			this.tbShipCode.Click += new System.EventHandler(this.tbCode_Click);
			this.tbShipCode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.tbShipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
			this.tbShipCode.Leave += new System.EventHandler(this.tbCode_LeaveFocus);
			// 
			// tbShipName
			// 
			this.tbShipName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipName.Location = new System.Drawing.Point(84, 16);
			this.tbShipName.Name = "tbShipName";
			this.tbShipName.Size = new System.Drawing.Size(250, 23);
			this.tbShipName.TabIndex = 0;
			this.tbShipName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Code";
			// 
			// tbShipAddress
			// 
			this.tbShipAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipAddress.Location = new System.Drawing.Point(84, 45);
			this.tbShipAddress.Multiline = true;
			this.tbShipAddress.Name = "tbShipAddress";
			this.tbShipAddress.Size = new System.Drawing.Size(250, 91);
			this.tbShipAddress.TabIndex = 1;
			this.tbShipAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "State";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Address";
			// 
			// tbShipEmail
			// 
			this.tbShipEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipEmail.Location = new System.Drawing.Point(84, 142);
			this.tbShipEmail.Name = "tbShipEmail";
			this.tbShipEmail.Size = new System.Drawing.Size(250, 23);
			this.tbShipEmail.TabIndex = 2;
			this.tbShipEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// tbShipGstin
			// 
			this.tbShipGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipGstin.Location = new System.Drawing.Point(84, 206);
			this.tbShipGstin.Name = "tbShipGstin";
			this.tbShipGstin.Size = new System.Drawing.Size(250, 23);
			this.tbShipGstin.TabIndex = 4;
			this.tbShipGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "E-mail";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "GSTIN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "Contact";
			// 
			// tbShipContact
			// 
			this.tbShipContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbShipContact.Location = new System.Drawing.Point(84, 174);
			this.tbShipContact.Name = "tbShipContact";
			this.tbShipContact.Size = new System.Drawing.Size(250, 23);
			this.tbShipContact.TabIndex = 3;
			this.tbShipContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.tbShipContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
			// 
			// cbBillShip
			// 
			this.cbBillShip.AutoSize = true;
			this.cbBillShip.Checked = true;
			this.cbBillShip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBillShip.Location = new System.Drawing.Point(12, 312);
			this.cbBillShip.Name = "cbBillShip";
			this.cbBillShip.Size = new System.Drawing.Size(248, 20);
			this.cbBillShip.TabIndex = 21;
			this.cbBillShip.Text = "Shipping details same as billing";
			this.cbBillShip.UseVisualStyleBackColor = true;
			this.cbBillShip.CheckedChanged += new System.EventHandler(this.cbBillShip_CheckedChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(289, 16);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(45, 23);
			this.btnSearch.TabIndex = 18;
			this.btnSearch.Text = "Go";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// CustomerDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(727, 368);
			this.Controls.Add(this.cbBillShip);
			this.Controls.Add(this.gbShipping);
			this.Controls.Add(this.gbBilling);
			this.Controls.Add(this.btnSave);
			this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(743, 406);
			this.MinimumSize = new System.Drawing.Size(743, 367);
			this.Name = "CustomerDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CustomerDetails";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerDetails_FormClosed);
			this.gbBilling.ResumeLayout(false);
			this.gbBilling.PerformLayout();
			this.gbShipping.ResumeLayout(false);
			this.gbShipping.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.TextBox tbContact;
		private System.Windows.Forms.Label lbContact;
		private System.Windows.Forms.TextBox tbGstin;
		private System.Windows.Forms.Label lbGstin;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label blState;
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.Label lbCode;
		private System.Windows.Forms.ComboBox cbState;
		private System.Windows.Forms.GroupBox gbBilling;
		private System.Windows.Forms.GroupBox gbShipping;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbShipState;
		private System.Windows.Forms.TextBox tbShipCode;
		private System.Windows.Forms.TextBox tbShipName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbShipAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbShipEmail;
		private System.Windows.Forms.TextBox tbShipGstin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbShipContact;
		private System.Windows.Forms.CheckBox cbBillShip;
		private System.Windows.Forms.Button btnSearch;
	}
}