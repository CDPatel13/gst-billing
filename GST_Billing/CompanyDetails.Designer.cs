namespace GST_Billing
{
    partial class CompanyDetails
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
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(16, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(95, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 23);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(95, 47);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(291, 91);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(16, 50);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 16);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Address";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(95, 144);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(291, 23);
            this.tbEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(16, 147);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 16);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "E-mail";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(95, 176);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(291, 23);
            this.tbContact.TabIndex = 3;
            this.tbContact.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(16, 179);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(62, 16);
            this.lbContact.TabIndex = 10;
            this.lbContact.Text = "Contact";
            // 
            // tbGstin
            // 
            this.tbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGstin.Location = new System.Drawing.Point(95, 208);
            this.tbGstin.Name = "tbGstin";
            this.tbGstin.Size = new System.Drawing.Size(291, 23);
            this.tbGstin.TabIndex = 4;
            this.tbGstin.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lbGstin
            // 
            this.lbGstin.AutoSize = true;
            this.lbGstin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGstin.Location = new System.Drawing.Point(16, 211);
            this.lbGstin.Name = "lbGstin";
            this.lbGstin.Size = new System.Drawing.Size(50, 16);
            this.lbGstin.TabIndex = 12;
            this.lbGstin.Text = "GSTIN";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(0, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(402, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // blState
            // 
            this.blState.AutoSize = true;
            this.blState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blState.Location = new System.Drawing.Point(16, 240);
            this.blState.Name = "blState";
            this.blState.Size = new System.Drawing.Size(44, 16);
            this.blState.TabIndex = 15;
            this.blState.Text = "State";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(95, 266);
            this.tbCode.MaxLength = 2;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(291, 23);
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
            this.lbCode.Location = new System.Drawing.Point(16, 269);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(45, 16);
            this.lbCode.TabIndex = 17;
            this.lbCode.Text = "Code";
            // 
            // cbState
            // 
            this.cbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
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
            this.cbState.Location = new System.Drawing.Point(95, 237);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(291, 24);
            this.cbState.TabIndex = 5;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            this.cbState.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // CompanyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 329);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.blState);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbGstin);
            this.Controls.Add(this.lbGstin);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 367);
            this.MinimumSize = new System.Drawing.Size(418, 367);
            this.Name = "CompanyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyDetails_FormClosed);
            this.Load += new System.EventHandler(this.CompanyDetails_Load);
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
    }
}