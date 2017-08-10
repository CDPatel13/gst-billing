namespace GST_Billing
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.tbOldUserName = new System.Windows.Forms.TextBox();
            this.lbOldUserName = new System.Windows.Forms.Label();
            this.tbNewUserName = new System.Windows.Forms.TextBox();
            this.lbNewUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOldPassword.Location = new System.Drawing.Point(59, 84);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(101, 16);
            this.lbOldPassword.TabIndex = 0;
            this.lbOldPassword.Text = "Old Password : ";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPassword.Location = new System.Drawing.Point(53, 110);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(107, 16);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "New Password : ";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbConfirmPassword.Location = new System.Drawing.Point(5, 136);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(155, 16);
            this.lbConfirmPassword.TabIndex = 2;
            this.lbConfirmPassword.Text = "Confirm New Password : ";
            // 
            // btnChange
            // 
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Brown;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(0, 161);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(378, 25);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldPassword.Location = new System.Drawing.Point(167, 83);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(199, 20);
            this.tbOldPassword.TabIndex = 2;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPassword.Location = new System.Drawing.Point(167, 109);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(199, 20);
            this.tbNewPassword.TabIndex = 3;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(167, 135);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(199, 20);
            this.tbConfirmPassword.TabIndex = 4;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbMain
            // 
            this.lbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbMain.Location = new System.Drawing.Point(121, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(149, 18);
            this.lbMain.TabIndex = 7;
            this.lbMain.Text = "Change Credentials";
            // 
            // tbOldUserName
            // 
            this.tbOldUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldUserName.Enabled = false;
            this.tbOldUserName.Location = new System.Drawing.Point(167, 31);
            this.tbOldUserName.Name = "tbOldUserName";
            this.tbOldUserName.Size = new System.Drawing.Size(199, 20);
            this.tbOldUserName.TabIndex = 0;
            // 
            // lbOldUserName
            // 
            this.lbOldUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOldUserName.AutoSize = true;
            this.lbOldUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOldUserName.Location = new System.Drawing.Point(50, 32);
            this.lbOldUserName.Name = "lbOldUserName";
            this.lbOldUserName.Size = new System.Drawing.Size(110, 16);
            this.lbOldUserName.TabIndex = 8;
            this.lbOldUserName.Text = "Old User Name : ";
            // 
            // tbNewUserName
            // 
            this.tbNewUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewUserName.Location = new System.Drawing.Point(167, 57);
            this.tbNewUserName.Name = "tbNewUserName";
            this.tbNewUserName.Size = new System.Drawing.Size(199, 20);
            this.tbNewUserName.TabIndex = 1;
            // 
            // lbNewUserName
            // 
            this.lbNewUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNewUserName.AutoSize = true;
            this.lbNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNewUserName.Location = new System.Drawing.Point(44, 58);
            this.lbNewUserName.Name = "lbNewUserName";
            this.lbNewUserName.Size = new System.Drawing.Size(116, 16);
            this.lbNewUserName.TabIndex = 10;
            this.lbNewUserName.Text = "New User Name : ";
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.btnChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(378, 186);
            this.Controls.Add(this.tbNewUserName);
            this.Controls.Add(this.lbNewUserName);
            this.Controls.Add(this.tbOldUserName);
            this.Controls.Add(this.lbOldUserName);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbOldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 181);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Credentials";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.TextBox tbOldUserName;
        private System.Windows.Forms.Label lbOldUserName;
        private System.Windows.Forms.TextBox tbNewUserName;
        private System.Windows.Forms.Label lbNewUserName;
    }
}