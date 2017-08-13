namespace GST_Billing
{
    partial class InvoicePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePayment));
            this.lbMain = new System.Windows.Forms.Label();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbBillAmount = new System.Windows.Forms.Label();
            this.lbPendingAmount = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.tbInvoice = new System.Windows.Forms.TextBox();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbBillAmount = new System.Windows.Forms.TextBox();
            this.tbPending = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbMain.Location = new System.Drawing.Point(41, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(204, 19);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "Make Payment for Invoice";
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.AutoSize = true;
            this.lbInvoiceNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceNo.Location = new System.Drawing.Point(47, 52);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(91, 16);
            this.lbInvoiceNo.TabIndex = 1;
            this.lbInvoiceNo.Text = "Invoice No. : ";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(17, 80);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(121, 16);
            this.lbCustomer.TabIndex = 2;
            this.lbCustomer.Text = "Customer Name : ";
            // 
            // lbBillAmount
            // 
            this.lbBillAmount.AutoSize = true;
            this.lbBillAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillAmount.Location = new System.Drawing.Point(44, 108);
            this.lbBillAmount.Name = "lbBillAmount";
            this.lbBillAmount.Size = new System.Drawing.Size(94, 16);
            this.lbBillAmount.TabIndex = 3;
            this.lbBillAmount.Text = "Bill Amount : ";
            // 
            // lbPendingAmount
            // 
            this.lbPendingAmount.AutoSize = true;
            this.lbPendingAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPendingAmount.Location = new System.Drawing.Point(12, 136);
            this.lbPendingAmount.Name = "lbPendingAmount";
            this.lbPendingAmount.Size = new System.Drawing.Size(126, 16);
            this.lbPendingAmount.TabIndex = 4;
            this.lbPendingAmount.Text = "Pending Amount : ";
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.Location = new System.Drawing.Point(62, 164);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(76, 16);
            this.lbPayment.TabIndex = 5;
            this.lbPayment.Text = "Payment : ";
            // 
            // tbInvoice
            // 
            this.tbInvoice.Enabled = false;
            this.tbInvoice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoice.Location = new System.Drawing.Point(144, 49);
            this.tbInvoice.Name = "tbInvoice";
            this.tbInvoice.Size = new System.Drawing.Size(100, 22);
            this.tbInvoice.TabIndex = 6;
            // 
            // tbPayment
            // 
            this.tbPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayment.Location = new System.Drawing.Point(144, 161);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(100, 22);
            this.tbPayment.TabIndex = 0;
            this.tbPayment.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            this.tbPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPayment_KeyPress);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Enabled = false;
            this.tbCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(144, 77);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(100, 22);
            this.tbCustomer.TabIndex = 8;
            // 
            // tbBillAmount
            // 
            this.tbBillAmount.Enabled = false;
            this.tbBillAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBillAmount.Location = new System.Drawing.Point(144, 105);
            this.tbBillAmount.Name = "tbBillAmount";
            this.tbBillAmount.Size = new System.Drawing.Size(100, 22);
            this.tbBillAmount.TabIndex = 9;
            // 
            // tbPending
            // 
            this.tbPending.Enabled = false;
            this.tbPending.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPending.Location = new System.Drawing.Point(144, 133);
            this.tbPending.Name = "tbPending";
            this.tbPending.Size = new System.Drawing.Size(100, 22);
            this.tbPending.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSave.Location = new System.Drawing.Point(0, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(284, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InvoicePayment
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPending);
            this.Controls.Add(this.tbBillAmount);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.tbInvoice);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.lbPendingAmount);
            this.Controls.Add(this.lbBillAmount);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.lbInvoiceNo);
            this.Controls.Add(this.lbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 260);
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "InvoicePayment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoicePayment";
            this.Load += new System.EventHandler(this.InvoicePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label lbInvoiceNo;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbBillAmount;
        private System.Windows.Forms.Label lbPendingAmount;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.TextBox tbInvoice;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbBillAmount;
        private System.Windows.Forms.TextBox tbPending;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}