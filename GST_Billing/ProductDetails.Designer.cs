namespace GST_Billing
{
    partial class ProductDetails
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
            this.tbProdHsnCode = new System.Windows.Forms.TextBox();
            this.lbProdHsnCode = new System.Windows.Forms.Label();
            this.tbProdQty = new System.Windows.Forms.TextBox();
            this.lbProdQty = new System.Windows.Forms.Label();
            this.tbProdRate = new System.Windows.Forms.TextBox();
            this.lbProdRate = new System.Windows.Forms.Label();
            this.tbProdDes = new System.Windows.Forms.TextBox();
            this.lbProdDes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProdHsnCode
            // 
            this.tbProdHsnCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdHsnCode.Location = new System.Drawing.Point(487, 12);
            this.tbProdHsnCode.Name = "tbProdHsnCode";
            this.tbProdHsnCode.Size = new System.Drawing.Size(256, 23);
            this.tbProdHsnCode.TabIndex = 36;
            // 
            // lbProdHsnCode
            // 
            this.lbProdHsnCode.AutoSize = true;
            this.lbProdHsnCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdHsnCode.Location = new System.Drawing.Point(403, 15);
            this.lbProdHsnCode.Name = "lbProdHsnCode";
            this.lbProdHsnCode.Size = new System.Drawing.Size(78, 16);
            this.lbProdHsnCode.TabIndex = 37;
            this.lbProdHsnCode.Text = "HSN Code";
            // 
            // tbProdQty
            // 
            this.tbProdQty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdQty.Location = new System.Drawing.Point(487, 41);
            this.tbProdQty.Name = "tbProdQty";
            this.tbProdQty.Size = new System.Drawing.Size(256, 23);
            this.tbProdQty.TabIndex = 34;
            this.tbProdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRateQty_KeyPress);
            // 
            // lbProdQty
            // 
            this.lbProdQty.AutoSize = true;
            this.lbProdQty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdQty.Location = new System.Drawing.Point(415, 44);
            this.lbProdQty.Name = "lbProdQty";
            this.lbProdQty.Size = new System.Drawing.Size(66, 16);
            this.lbProdQty.TabIndex = 35;
            this.lbProdQty.Text = "Quantity";
            // 
            // tbProdRate
            // 
            this.tbProdRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdRate.Location = new System.Drawing.Point(107, 41);
            this.tbProdRate.Name = "tbProdRate";
            this.tbProdRate.Size = new System.Drawing.Size(256, 23);
            this.tbProdRate.TabIndex = 24;
            this.tbProdRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRateQty_KeyPress);
            // 
            // lbProdRate
            // 
            this.lbProdRate.AutoSize = true;
            this.lbProdRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdRate.Location = new System.Drawing.Point(61, 44);
            this.lbProdRate.Name = "lbProdRate";
            this.lbProdRate.Size = new System.Drawing.Size(40, 16);
            this.lbProdRate.TabIndex = 29;
            this.lbProdRate.Text = "Rate";
            // 
            // tbProdDes
            // 
            this.tbProdDes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdDes.Location = new System.Drawing.Point(107, 12);
            this.tbProdDes.Name = "tbProdDes";
            this.tbProdDes.Size = new System.Drawing.Size(256, 23);
            this.tbProdDes.TabIndex = 22;
            // 
            // lbProdDes
            // 
            this.lbProdDes.AutoSize = true;
            this.lbProdDes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdDes.Location = new System.Drawing.Point(12, 15);
            this.lbProdDes.Name = "lbProdDes";
            this.lbProdDes.Size = new System.Drawing.Size(89, 16);
            this.lbProdDes.TabIndex = 23;
            this.lbProdDes.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(0, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(755, 29);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 280);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbProdHsnCode);
            this.Controls.Add(this.lbProdHsnCode);
            this.Controls.Add(this.tbProdQty);
            this.Controls.Add(this.lbProdQty);
            this.Controls.Add(this.tbProdRate);
            this.Controls.Add(this.lbProdRate);
            this.Controls.Add(this.tbProdDes);
            this.Controls.Add(this.lbProdDes);
            this.MaximizeBox = false;
            this.Name = "ProductDetails";
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProdHsnCode;
        private System.Windows.Forms.Label lbProdHsnCode;
        private System.Windows.Forms.TextBox tbProdQty;
        private System.Windows.Forms.Label lbProdQty;
        private System.Windows.Forms.TextBox tbProdRate;
        private System.Windows.Forms.Label lbProdRate;
        private System.Windows.Forms.TextBox tbProdDes;
        private System.Windows.Forms.Label lbProdDes;
        private System.Windows.Forms.Button btnSave;
    }
}