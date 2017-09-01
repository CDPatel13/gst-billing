namespace GST_Billing
{
    partial class SelectInvoicePrint
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
            this.lbMain = new System.Windows.Forms.Label();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.rbDuplicate = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.rbTriplicate = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lbMain.Location = new System.Drawing.Point(75, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(91, 18);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "Select Type";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.rbOriginal.Location = new System.Drawing.Point(78, 40);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(81, 20);
            this.rbOriginal.TabIndex = 1;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Original";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // rbDuplicate
            // 
            this.rbDuplicate.AutoSize = true;
            this.rbDuplicate.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.rbDuplicate.Location = new System.Drawing.Point(78, 66);
            this.rbDuplicate.Name = "rbDuplicate";
            this.rbDuplicate.Size = new System.Drawing.Size(92, 20);
            this.rbDuplicate.TabIndex = 2;
            this.rbDuplicate.Text = "Duplicate";
            this.rbDuplicate.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGo.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnGo.Location = new System.Drawing.Point(0, 123);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(249, 30);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "&Select";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rbTriplicate
            // 
            this.rbTriplicate.AutoSize = true;
            this.rbTriplicate.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.rbTriplicate.Location = new System.Drawing.Point(78, 92);
            this.rbTriplicate.Name = "rbTriplicate";
            this.rbTriplicate.Size = new System.Drawing.Size(90, 20);
            this.rbTriplicate.TabIndex = 4;
            this.rbTriplicate.Text = "Triplicate";
            this.rbTriplicate.UseVisualStyleBackColor = true;
            // 
            // SelectInvoicePrint
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 153);
            this.Controls.Add(this.rbTriplicate);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rbDuplicate);
            this.Controls.Add(this.rbOriginal);
            this.Controls.Add(this.lbMain);
            this.MaximizeBox = false;
            this.Name = "SelectInvoicePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Invoice Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.Windows.Forms.RadioButton rbDuplicate;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton rbTriplicate;
    }
}