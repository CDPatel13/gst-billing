namespace GST_Billing
{
    partial class SelectFirm
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
            this.lbSelectFirm = new System.Windows.Forms.Label();
            this.tbSelectedFirm = new System.Windows.Forms.ComboBox();
            this.tbSelectedYear = new System.Windows.Forms.ComboBox();
            this.lbSelectYear = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddFirm = new System.Windows.Forms.Button();
            this.btnEditFirm = new System.Windows.Forms.Button();
            this.btnSelectFirm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelectFirm
            // 
            this.lbSelectFirm.AutoSize = true;
            this.lbSelectFirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSelectFirm.Location = new System.Drawing.Point(3, 5);
            this.lbSelectFirm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbSelectFirm.Name = "lbSelectFirm";
            this.lbSelectFirm.Size = new System.Drawing.Size(112, 16);
            this.lbSelectFirm.TabIndex = 1;
            this.lbSelectFirm.Text = "Select Company";
            // 
            // tbSelectedFirm
            // 
            this.tbSelectedFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSelectedFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectedFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSelectedFirm.FormattingEnabled = true;
            this.tbSelectedFirm.Location = new System.Drawing.Point(121, 3);
            this.tbSelectedFirm.Name = "tbSelectedFirm";
            this.tbSelectedFirm.Size = new System.Drawing.Size(209, 22);
            this.tbSelectedFirm.TabIndex = 2;
            // 
            // tbSelectedYear
            // 
            this.tbSelectedYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSelectedYear.FormattingEnabled = true;
            this.tbSelectedYear.Items.AddRange(new object[] {
            "2017-18",
            "2018-19",
            "2019-20",
            "2020-21"});
            this.tbSelectedYear.Location = new System.Drawing.Point(121, 31);
            this.tbSelectedYear.Name = "tbSelectedYear";
            this.tbSelectedYear.Size = new System.Drawing.Size(209, 22);
            this.tbSelectedYear.TabIndex = 3;
            // 
            // lbSelectYear
            // 
            this.lbSelectYear.AutoSize = true;
            this.lbSelectYear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbSelectYear.Location = new System.Drawing.Point(3, 33);
            this.lbSelectYear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbSelectYear.Name = "lbSelectYear";
            this.lbSelectYear.Size = new System.Drawing.Size(74, 16);
            this.lbSelectYear.TabIndex = 4;
            this.lbSelectYear.Text = "Select F.Y.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.56457F));
            this.tableLayoutPanel1.Controls.Add(this.lbSelectFirm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSelectedYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbSelectYear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbSelectedFirm, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 63);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddFirm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditFirm, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectFirm, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 43);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnAddFirm
            // 
            this.btnAddFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFirm.Location = new System.Drawing.Point(3, 3);
            this.btnAddFirm.Name = "btnAddFirm";
            this.btnAddFirm.Size = new System.Drawing.Size(105, 37);
            this.btnAddFirm.TabIndex = 0;
            this.btnAddFirm.Text = "Add";
            this.btnAddFirm.UseVisualStyleBackColor = true;
            this.btnAddFirm.Click += new System.EventHandler(this.btnAddFirm_Click);
            // 
            // btnEditFirm
            // 
            this.btnEditFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditFirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFirm.Location = new System.Drawing.Point(114, 3);
            this.btnEditFirm.Name = "btnEditFirm";
            this.btnEditFirm.Size = new System.Drawing.Size(105, 37);
            this.btnEditFirm.TabIndex = 1;
            this.btnEditFirm.Text = "Edit";
            this.btnEditFirm.UseVisualStyleBackColor = true;
            this.btnEditFirm.Click += new System.EventHandler(this.btnEditFirm_Click);
            // 
            // btnSelectFirm
            // 
            this.btnSelectFirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFirm.Location = new System.Drawing.Point(225, 3);
            this.btnSelectFirm.Name = "btnSelectFirm";
            this.btnSelectFirm.Size = new System.Drawing.Size(105, 37);
            this.btnSelectFirm.TabIndex = 2;
            this.btnSelectFirm.Text = "Select";
            this.btnSelectFirm.UseVisualStyleBackColor = true;
            this.btnSelectFirm.Click += new System.EventHandler(this.btnSelectFirm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SelectFirm
            // 
            this.AcceptButton = this.btnSelectFirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 106);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "SelectFirm";
            this.Text = "Select Company and F.Y.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectFirm_FormClosed);
            this.Load += new System.EventHandler(this.SelectFirm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSelectFirm;
        private System.Windows.Forms.ComboBox tbSelectedFirm;
        private System.Windows.Forms.Label lbSelectYear;
        private System.Windows.Forms.ComboBox tbSelectedYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddFirm;
        private System.Windows.Forms.Button btnEditFirm;
        private System.Windows.Forms.Button btnSelectFirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}