namespace GST_Billing
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearchProducts = new System.Windows.Forms.TextBox();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.flpSearchInvoice = new System.Windows.Forms.FlowLayoutPanel();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearchInvoice = new System.Windows.Forms.TextBox();
            this.btnFindInvoice = new System.Windows.Forms.Button();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbAmountTotal = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.lbAmountPending = new System.Windows.Forms.Label();
            this.tlpInvoiceBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearchCust = new System.Windows.Forms.TextBox();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompanyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSelectedCompany = new System.Windows.Forms.Label();
            this.lbFinancialYear = new System.Windows.Forms.Label();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.flpSearchInvoice.SuspendLayout();
            this.tlpInvoiceBtns.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProducts.Controls.Add(this.dgvProducts);
            this.tabProducts.Controls.Add(this.flowLayoutPanel3);
            this.tabProducts.Controls.Add(this.tableLayoutPanel3);
            this.tabProducts.Location = new System.Drawing.Point(4, 25);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(1256, 653);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Item Master";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 79);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1254, 572);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tbSearchProducts);
            this.flowLayoutPanel3.Controls.Add(this.btnFindProduct);
            this.flowLayoutPanel3.Controls.Add(this.btnClearProduct);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1254, 39);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // tbSearchProducts
            // 
            this.tbSearchProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearchProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchProducts.Location = new System.Drawing.Point(3, 8);
            this.tbSearchProducts.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchProducts.Name = "tbSearchProducts";
            this.tbSearchProducts.Size = new System.Drawing.Size(294, 20);
            this.tbSearchProducts.TabIndex = 0;
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnFindProduct.Image")));
            this.btnFindProduct.Location = new System.Drawing.Point(303, 3);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(75, 29);
            this.btnFindProduct.TabIndex = 1;
            this.btnFindProduct.Text = "&Find";
            this.btnFindProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnClearProduct.Image")));
            this.btnClearProduct.Location = new System.Drawing.Point(384, 3);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(75, 29);
            this.btnClearProduct.TabIndex = 2;
            this.btnClearProduct.Text = "C&lear";
            this.btnClearProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnPrintProduct, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddProduct, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteProduct, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditProduct, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClose3, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1254, 40);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrintProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintProduct.Image")));
            this.btnPrintProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintProduct.Location = new System.Drawing.Point(408, 3);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(129, 34);
            this.btnPrintProduct.TabIndex = 3;
            this.btnPrintProduct.Text = "&Print (F4)";
            this.btnPrintProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintProduct.UseVisualStyleBackColor = true;
            this.btnPrintProduct.Visible = false;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(129, 34);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "&New (F2)";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(273, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(129, 34);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "&Delete (F10)";
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProduct.Location = new System.Drawing.Point(138, 3);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(129, 34);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "&Edit (F3)";
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnClose3
            // 
            this.btnClose3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose3.ForeColor = System.Drawing.Color.Red;
            this.btnClose3.Image = ((System.Drawing.Image)(resources.GetObject("btnClose3.Image")));
            this.btnClose3.Location = new System.Drawing.Point(1176, 3);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(75, 34);
            this.btnClose3.TabIndex = 7;
            this.btnClose3.Text = "&Close";
            this.btnClose3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose3.UseVisualStyleBackColor = true;
            this.btnClose3.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // tabInvoice
            // 
            this.tabInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInvoice.Controls.Add(this.dgvInvoice);
            this.tabInvoice.Controls.Add(this.flpSearchInvoice);
            this.tabInvoice.Controls.Add(this.tlpInvoiceBtns);
            this.tabInvoice.Location = new System.Drawing.Point(4, 25);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(1256, 653);
            this.tabInvoice.TabIndex = 1;
            this.tabInvoice.Text = "Invoice List";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 79);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowTemplate.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1254, 572);
            this.dgvInvoice.TabIndex = 7;
            this.dgvInvoice.DoubleClick += new System.EventHandler(this.dgvInvoice_DoubleClick);
            this.dgvInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            // 
            // flpSearchInvoice
            // 
            this.flpSearchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSearchInvoice.Controls.Add(this.lbStartDate);
            this.flpSearchInvoice.Controls.Add(this.dtpStartDate);
            this.flpSearchInvoice.Controls.Add(this.lbEndDate);
            this.flpSearchInvoice.Controls.Add(this.dtpEndDate);
            this.flpSearchInvoice.Controls.Add(this.tbSearchInvoice);
            this.flpSearchInvoice.Controls.Add(this.btnFindInvoice);
            this.flpSearchInvoice.Controls.Add(this.btnClearInvoice);
            this.flpSearchInvoice.Controls.Add(this.lbTotalAmount);
            this.flpSearchInvoice.Controls.Add(this.lbAmountTotal);
            this.flpSearchInvoice.Controls.Add(this.lbPending);
            this.flpSearchInvoice.Controls.Add(this.lbAmountPending);
            this.flpSearchInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSearchInvoice.Location = new System.Drawing.Point(0, 40);
            this.flpSearchInvoice.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flpSearchInvoice.Name = "flpSearchInvoice";
            this.flpSearchInvoice.Size = new System.Drawing.Size(1254, 39);
            this.flpSearchInvoice.TabIndex = 6;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(5, 10);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(34, 13);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "From";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(45, 8);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpStartDate.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(82, 20);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(133, 10);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(22, 13);
            this.lbEndDate.TabIndex = 5;
            this.lbEndDate.Text = "To";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(161, 8);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(82, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // tbSearchInvoice
            // 
            this.tbSearchInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearchInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchInvoice.Location = new System.Drawing.Point(249, 8);
            this.tbSearchInvoice.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchInvoice.Name = "tbSearchInvoice";
            this.tbSearchInvoice.Size = new System.Drawing.Size(294, 20);
            this.tbSearchInvoice.TabIndex = 0;
            // 
            // btnFindInvoice
            // 
            this.btnFindInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnFindInvoice.Image")));
            this.btnFindInvoice.Location = new System.Drawing.Point(549, 3);
            this.btnFindInvoice.Name = "btnFindInvoice";
            this.btnFindInvoice.Size = new System.Drawing.Size(75, 29);
            this.btnFindInvoice.TabIndex = 1;
            this.btnFindInvoice.Text = "&Find";
            this.btnFindInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindInvoice.UseVisualStyleBackColor = true;
            this.btnFindInvoice.Click += new System.EventHandler(this.btnFindInvoice_Click);
            // 
            // btnClearInvoice
            // 
            this.btnClearInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInvoice.Image")));
            this.btnClearInvoice.Location = new System.Drawing.Point(630, 3);
            this.btnClearInvoice.Name = "btnClearInvoice";
            this.btnClearInvoice.Size = new System.Drawing.Size(75, 29);
            this.btnClearInvoice.TabIndex = 2;
            this.btnClearInvoice.Text = "C&lear";
            this.btnClearInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearInvoice.UseVisualStyleBackColor = true;
            this.btnClearInvoice.Click += new System.EventHandler(this.btnClearInvoice_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTotalAmount.Location = new System.Drawing.Point(738, 10);
            this.lbTotalAmount.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(161, 16);
            this.lbTotalAmount.TabIndex = 7;
            this.lbTotalAmount.Text = "Total Invoice Amount :";
            // 
            // lbAmountTotal
            // 
            this.lbAmountTotal.AutoSize = true;
            this.lbAmountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbAmountTotal.Location = new System.Drawing.Point(905, 10);
            this.lbAmountTotal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbAmountTotal.Name = "lbAmountTotal";
            this.lbAmountTotal.Size = new System.Drawing.Size(36, 16);
            this.lbAmountTotal.TabIndex = 10;
            this.lbAmountTotal.Text = "0.00";
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPending.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbPending.Location = new System.Drawing.Point(954, 10);
            this.lbPending.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(128, 16);
            this.lbPending.TabIndex = 9;
            this.lbPending.Text = "Pending Amount :";
            // 
            // lbAmountPending
            // 
            this.lbAmountPending.AutoSize = true;
            this.lbAmountPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPending.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbAmountPending.Location = new System.Drawing.Point(1088, 10);
            this.lbAmountPending.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbAmountPending.Name = "lbAmountPending";
            this.lbAmountPending.Size = new System.Drawing.Size(36, 16);
            this.lbAmountPending.TabIndex = 11;
            this.lbAmountPending.Text = "0.00";
            // 
            // tlpInvoiceBtns
            // 
            this.tlpInvoiceBtns.BackColor = System.Drawing.SystemColors.Control;
            this.tlpInvoiceBtns.ColumnCount = 6;
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInvoiceBtns.Controls.Add(this.btnPrintInvoice, 3, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnAddInvoice, 0, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnDeleteInvoice, 2, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnEditInvoice, 1, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnPayment, 4, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnClose1, 5, 0);
            this.tlpInvoiceBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInvoiceBtns.Location = new System.Drawing.Point(0, 0);
            this.tlpInvoiceBtns.Name = "tlpInvoiceBtns";
            this.tlpInvoiceBtns.RowCount = 1;
            this.tlpInvoiceBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInvoiceBtns.Size = new System.Drawing.Size(1254, 40);
            this.tlpInvoiceBtns.TabIndex = 5;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintInvoice.Image")));
            this.btnPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintInvoice.Location = new System.Drawing.Point(408, 3);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(129, 34);
            this.btnPrintInvoice.TabIndex = 3;
            this.btnPrintInvoice.Text = "&Print (F4)";
            this.btnPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInvoice.Image")));
            this.btnAddInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddInvoice.Size = new System.Drawing.Size(129, 34);
            this.btnAddInvoice.TabIndex = 0;
            this.btnAddInvoice.Text = "&New (F2)";
            this.btnAddInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteInvoice.Image")));
            this.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(273, 3);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(129, 34);
            this.btnDeleteInvoice.TabIndex = 1;
            this.btnDeleteInvoice.Text = "&Delete (F10)";
            this.btnDeleteInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInvoice.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInvoice.Image")));
            this.btnEditInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditInvoice.Location = new System.Drawing.Point(138, 3);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(129, 34);
            this.btnEditInvoice.TabIndex = 2;
            this.btnEditInvoice.Text = "&Edit (F3)";
            this.btnEditInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(543, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(129, 34);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Pa&yment (F6)";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose1.ForeColor = System.Drawing.Color.Red;
            this.btnClose1.Image = ((System.Drawing.Image)(resources.GetObject("btnClose1.Image")));
            this.btnClose1.Location = new System.Drawing.Point(1176, 3);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(75, 34);
            this.btnClose1.TabIndex = 5;
            this.btnClose1.Text = "&Close";
            this.btnClose1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // tabCustomer
            // 
            this.tabCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCustomer.Controls.Add(this.dgvCustomer);
            this.tabCustomer.Controls.Add(this.flowLayoutPanel1);
            this.tabCustomer.Controls.Add(this.tableLayoutPanel1);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1256, 653);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer List";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 79);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1254, 572);
            this.dgvCustomer.TabIndex = 8;
            this.dgvCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbSearchCust);
            this.flowLayoutPanel1.Controls.Add(this.btnFindCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnClearCustomer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1254, 39);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tbSearchCust
            // 
            this.tbSearchCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearchCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchCust.Location = new System.Drawing.Point(3, 8);
            this.tbSearchCust.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchCust.Name = "tbSearchCust";
            this.tbSearchCust.Size = new System.Drawing.Size(294, 20);
            this.tbSearchCust.TabIndex = 0;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.Image")));
            this.btnFindCustomer.Location = new System.Drawing.Point(303, 3);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnFindCustomer.TabIndex = 1;
            this.btnFindCustomer.Text = "&Find";
            this.btnFindCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCustomer.Image")));
            this.btnClearCustomer.Location = new System.Drawing.Point(384, 3);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(75, 29);
            this.btnClearCustomer.TabIndex = 2;
            this.btnClearCustomer.Text = "C&lear";
            this.btnClearCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnPrintCust, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCust, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCust, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditCust, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose2, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnPrintCust
            // 
            this.btnPrintCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCust.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrintCust.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCust.Image")));
            this.btnPrintCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintCust.Location = new System.Drawing.Point(408, 3);
            this.btnPrintCust.Name = "btnPrintCust";
            this.btnPrintCust.Size = new System.Drawing.Size(129, 34);
            this.btnPrintCust.TabIndex = 3;
            this.btnPrintCust.Text = "&Print (F4)";
            this.btnPrintCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCust.UseVisualStyleBackColor = true;
            this.btnPrintCust.Visible = false;
            this.btnPrintCust.Click += new System.EventHandler(this.btnPrintCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddCust.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCust.Image")));
            this.btnAddCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCust.Location = new System.Drawing.Point(3, 3);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(129, 34);
            this.btnAddCust.TabIndex = 0;
            this.btnAddCust.Text = "&New (F2)";
            this.btnAddCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteCust.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCust.Image")));
            this.btnDeleteCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCust.Location = new System.Drawing.Point(273, 3);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(129, 34);
            this.btnDeleteCust.TabIndex = 1;
            this.btnDeleteCust.Text = "&Delete (F10)";
            this.btnDeleteCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditCust.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCust.Image")));
            this.btnEditCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCust.Location = new System.Drawing.Point(138, 3);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(129, 34);
            this.btnEditCust.TabIndex = 2;
            this.btnEditCust.Text = "&Edit (F3)";
            this.btnEditCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose2.ForeColor = System.Drawing.Color.Red;
            this.btnClose2.Image = ((System.Drawing.Image)(resources.GetObject("btnClose2.Image")));
            this.btnClose2.Location = new System.Drawing.Point(1176, 3);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(75, 34);
            this.btnClose2.TabIndex = 6;
            this.btnClose2.Text = "&Close";
            this.btnClose2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabInvoice);
            this.tabMain.Controls.Add(this.tabCustomer);
            this.tabMain.Controls.Add(this.tabProducts);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1264, 682);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            this.tabMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiTools});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripMain.Location = new System.Drawing.Point(1085, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripMain.ShowItemToolTips = true;
            this.menuStripMain.Size = new System.Drawing.Size(173, 25);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.BackColor = System.Drawing.Color.LightCyan;
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompanyInfo,
            this.tsmiChangePassword});
            this.tsmiSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSettings.ForeColor = System.Drawing.Color.DarkGreen;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(71, 21);
            this.tsmiSettings.Text = "&Settings";
            // 
            // tsmiCompanyInfo
            // 
            this.tsmiCompanyInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCompanyInfo.Name = "tsmiCompanyInfo";
            this.tsmiCompanyInfo.Size = new System.Drawing.Size(189, 22);
            this.tsmiCompanyInfo.Text = "C&ompany";
            this.tsmiCompanyInfo.Click += new System.EventHandler(this.tsmiCompanyInfo_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(189, 22);
            this.tsmiChangePassword.Text = "C&hange Credentials";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.tsmiTools.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTools.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(53, 21);
            this.tsmiTools.Text = "&Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculatorToolStripMenuItem.Text = "Calc&ulator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // lbSelectedCompany
            // 
            this.lbSelectedCompany.AutoSize = true;
            this.lbSelectedCompany.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSelectedCompany.ForeColor = System.Drawing.Color.LightCoral;
            this.lbSelectedCompany.Location = new System.Drawing.Point(350, 5);
            this.lbSelectedCompany.Name = "lbSelectedCompany";
            this.lbSelectedCompany.Size = new System.Drawing.Size(110, 14);
            this.lbSelectedCompany.TabIndex = 8;
            this.lbSelectedCompany.Text = "Selected Company";
            // 
            // lbFinancialYear
            // 
            this.lbFinancialYear.AutoSize = true;
            this.lbFinancialYear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbFinancialYear.ForeColor = System.Drawing.Color.Salmon;
            this.lbFinancialYear.Location = new System.Drawing.Point(650, 5);
            this.lbFinancialYear.Name = "lbFinancialYear";
            this.lbFinancialYear.Size = new System.Drawing.Size(81, 14);
            this.lbFinancialYear.TabIndex = 8;
            this.lbFinancialYear.Text = "Financial Year";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F);
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupToolStripMenuItem.Text = "&Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.lbSelectedCompany);
            this.Controls.Add(this.lbFinancialYear);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.flpSearchInvoice.ResumeLayout(false);
            this.flpSearchInvoice.PerformLayout();
            this.tlpInvoiceBtns.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbSearchCust;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.FlowLayoutPanel flpSearchInvoice;
        private System.Windows.Forms.TextBox tbSearchInvoice;
        private System.Windows.Forms.Button btnFindInvoice;
        private System.Windows.Forms.Button btnClearInvoice;
        private System.Windows.Forms.TableLayoutPanel tlpInvoiceBtns;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox tbSearchProducts;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbAmountTotal;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label lbAmountPending;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompanyInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.Label lbSelectedCompany;
        private System.Windows.Forms.Label lbFinancialYear;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;

    }
}