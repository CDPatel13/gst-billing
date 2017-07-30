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
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.colCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustGstin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpSearchInvoice = new System.Windows.Forms.FlowLayoutPanel();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbSearchInvoice = new System.Windows.Forms.TextBox();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbAmountReceived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpInvoiceBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
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
            this.tabMain = new System.Windows.Forms.TabControl();
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
            this.tabProducts.Text = "Products List";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 79);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1254, 586);
            this.dgvProducts.TabIndex = 9;
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
            this.btnFindProduct.Text = "Find";
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
            this.btnClearProduct.Text = "Clear";
            this.btnClearProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnPrintProduct, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddProduct, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteProduct, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEditProduct, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.btnPrintProduct.Location = new System.Drawing.Point(303, 3);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(94, 34);
            this.btnPrintProduct.TabIndex = 3;
            this.btnPrintProduct.Text = "Print";
            this.btnPrintProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintProduct.UseVisualStyleBackColor = true;
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
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 34);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
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
            this.btnDeleteProduct.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(94, 34);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete";
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
            this.btnEditProduct.Location = new System.Drawing.Point(103, 3);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(94, 34);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
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
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCust,
            this.colInvoiceNum,
            this.colInvoiceDate,
            this.colAmount,
            this.colDiscount,
            this.colTaxableAmt,
            this.colCgst,
            this.colSgst,
            this.colIgst,
            this.colCustGstin,
            this.colReceivedAmt});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 79);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.RowTemplate.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1254, 586);
            this.dgvInvoice.TabIndex = 7;
            // 
            // colCust
            // 
            this.colCust.HeaderText = "Customer Name";
            this.colCust.Name = "colCust";
            this.colCust.ReadOnly = true;
            // 
            // colInvoiceNum
            // 
            this.colInvoiceNum.HeaderText = "Invoice No";
            this.colInvoiceNum.Name = "colInvoiceNum";
            this.colInvoiceNum.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.HeaderText = "Invoice Date";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Net Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colTaxableAmt
            // 
            this.colTaxableAmt.HeaderText = "Taxable Amount";
            this.colTaxableAmt.Name = "colTaxableAmt";
            this.colTaxableAmt.ReadOnly = true;
            // 
            // colCgst
            // 
            this.colCgst.HeaderText = "CGST Total";
            this.colCgst.Name = "colCgst";
            this.colCgst.ReadOnly = true;
            // 
            // colSgst
            // 
            this.colSgst.HeaderText = "SGST Total";
            this.colSgst.Name = "colSgst";
            this.colSgst.ReadOnly = true;
            // 
            // colIgst
            // 
            this.colIgst.HeaderText = "IGST Total";
            this.colIgst.Name = "colIgst";
            this.colIgst.ReadOnly = true;
            // 
            // colCustGstin
            // 
            this.colCustGstin.HeaderText = "Customer GSTIN";
            this.colCustGstin.Name = "colCustGstin";
            this.colCustGstin.ReadOnly = true;
            // 
            // colReceivedAmt
            // 
            this.colReceivedAmt.HeaderText = "Payment";
            this.colReceivedAmt.Name = "colReceivedAmt";
            this.colReceivedAmt.ReadOnly = true;
            // 
            // flpSearchInvoice
            // 
            this.flpSearchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSearchInvoice.Controls.Add(this.lbStartDate);
            this.flpSearchInvoice.Controls.Add(this.dateTimePicker1);
            this.flpSearchInvoice.Controls.Add(this.label1);
            this.flpSearchInvoice.Controls.Add(this.dateTimePicker2);
            this.flpSearchInvoice.Controls.Add(this.tbSearchInvoice);
            this.flpSearchInvoice.Controls.Add(this.btnSearchInvoice);
            this.flpSearchInvoice.Controls.Add(this.btnClearInvoice);
            this.flpSearchInvoice.Controls.Add(this.lbTotalAmount);
            this.flpSearchInvoice.Controls.Add(this.lbAmountReceived);
            this.flpSearchInvoice.Controls.Add(this.label2);
            this.flpSearchInvoice.Controls.Add(this.label3);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 8);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // tbSearchInvoice
            // 
            this.tbSearchInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchInvoice.Location = new System.Drawing.Point(249, 8);
            this.tbSearchInvoice.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbSearchInvoice.Name = "tbSearchInvoice";
            this.tbSearchInvoice.Size = new System.Drawing.Size(294, 20);
            this.tbSearchInvoice.TabIndex = 0;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchInvoice.Image")));
            this.btnSearchInvoice.Location = new System.Drawing.Point(549, 3);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(75, 29);
            this.btnSearchInvoice.TabIndex = 1;
            this.btnSearchInvoice.Text = "Find";
            this.btnSearchInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
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
            this.btnClearInvoice.Text = "Clear";
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
            // lbAmountReceived
            // 
            this.lbAmountReceived.AutoSize = true;
            this.lbAmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountReceived.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbAmountReceived.Location = new System.Drawing.Point(905, 10);
            this.lbAmountReceived.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbAmountReceived.Name = "lbAmountReceived";
            this.lbAmountReceived.Size = new System.Drawing.Size(36, 16);
            this.lbAmountReceived.TabIndex = 10;
            this.lbAmountReceived.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(954, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pending Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(1088, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "0.00";
            // 
            // tlpInvoiceBtns
            // 
            this.tlpInvoiceBtns.BackColor = System.Drawing.SystemColors.Control;
            this.tlpInvoiceBtns.ColumnCount = 6;
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpInvoiceBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInvoiceBtns.Controls.Add(this.btnPrintInvoice, 3, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnAddInvoice, 0, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnDeleteInvoice, 2, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnEditInvoice, 1, 0);
            this.tlpInvoiceBtns.Controls.Add(this.btnPayment, 4, 0);
            this.tlpInvoiceBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInvoiceBtns.Location = new System.Drawing.Point(0, 0);
            this.tlpInvoiceBtns.Name = "tlpInvoiceBtns";
            this.tlpInvoiceBtns.RowCount = 1;
            this.tlpInvoiceBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.btnPrintInvoice.Location = new System.Drawing.Point(303, 3);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(94, 34);
            this.btnPrintInvoice.TabIndex = 3;
            this.btnPrintInvoice.Text = "Print";
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
            this.btnAddInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(94, 34);
            this.btnAddInvoice.TabIndex = 0;
            this.btnAddInvoice.Text = "Add";
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
            this.btnDeleteInvoice.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(94, 34);
            this.btnDeleteInvoice.TabIndex = 1;
            this.btnDeleteInvoice.Text = "Delete";
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
            this.btnEditInvoice.Location = new System.Drawing.Point(103, 3);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(94, 34);
            this.btnEditInvoice.TabIndex = 2;
            this.btnEditInvoice.Text = "Edit";
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
            this.btnPayment.Location = new System.Drawing.Point(403, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(94, 34);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
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
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 79);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1254, 586);
            this.dgvCustomer.TabIndex = 8;
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
            this.btnFindCustomer.Text = "Find";
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
            this.btnClearCustomer.Text = "Clear";
            this.btnClearCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrintCust, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddCust, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCust, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditCust, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.btnPrintCust.Location = new System.Drawing.Point(303, 3);
            this.btnPrintCust.Name = "btnPrintCust";
            this.btnPrintCust.Size = new System.Drawing.Size(94, 34);
            this.btnPrintCust.TabIndex = 3;
            this.btnPrintCust.Text = "Print";
            this.btnPrintCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCust.UseVisualStyleBackColor = true;
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
            this.btnAddCust.Location = new System.Drawing.Point(3, 3);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(94, 34);
            this.btnAddCust.TabIndex = 0;
            this.btnAddCust.Text = "Add";
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
            this.btnDeleteCust.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(94, 34);
            this.btnDeleteCust.TabIndex = 1;
            this.btnDeleteCust.Text = "Delete";
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
            this.btnEditCust.Location = new System.Drawing.Point(103, 3);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(94, 34);
            this.btnEditCust.TabIndex = 2;
            this.btnEditCust.Text = "Edit";
            this.btnEditCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tabMain);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnSearchInvoice;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbAmountReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustGstin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedAmt;

    }
}