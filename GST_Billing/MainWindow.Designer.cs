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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colProdDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustLandmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustPinCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustPayTerms = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dataGridView2);
            this.tabProducts.Controls.Add(this.flowLayoutPanel3);
            this.tabProducts.Controls.Add(this.tableLayoutPanel3);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(1256, 656);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Products List";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdDes,
            this.colProdId,
            this.colProdRate,
            this.colProdQty});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1256, 586);
            this.dataGridView2.TabIndex = 9;
            // 
            // colProdDes
            // 
            this.colProdDes.HeaderText = "Product Description";
            this.colProdDes.Name = "colProdDes";
            // 
            // colProdId
            // 
            this.colProdId.HeaderText = "Product ID";
            this.colProdId.Name = "colProdId";
            // 
            // colProdRate
            // 
            this.colProdRate.HeaderText = "Product Rate";
            this.colProdRate.Name = "colProdRate";
            // 
            // colProdQty
            // 
            this.colProdQty.HeaderText = "Product Quantity";
            this.colProdQty.Name = "colProdQty";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox2);
            this.flowLayoutPanel3.Controls.Add(this.button7);
            this.flowLayoutPanel3.Controls.Add(this.button8);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1256, 30);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(303, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Find";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(384, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1256, 40);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintProduct.Image")));
            this.btnPrintProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintProduct.Location = new System.Drawing.Point(303, 3);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(94, 34);
            this.btnPrintProduct.TabIndex = 3;
            this.btnPrintProduct.Text = "Print";
            this.btnPrintProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 34);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(94, 34);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.Location = new System.Drawing.Point(103, 3);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(94, 34);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.dgvInvoice);
            this.tabInvoice.Controls.Add(this.flowLayoutPanel2);
            this.tabInvoice.Controls.Add(this.tableLayoutPanel2);
            this.tabInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(1256, 656);
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
            this.colCustGstin});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 70);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1256, 586);
            this.dgvInvoice.TabIndex = 7;
            // 
            // colCust
            // 
            this.colCust.HeaderText = "Customer Name";
            this.colCust.Name = "colCust";
            // 
            // colInvoiceNum
            // 
            this.colInvoiceNum.HeaderText = "Invoice No";
            this.colInvoiceNum.Name = "colInvoiceNum";
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.HeaderText = "Invoice Date";
            this.colInvoiceDate.Name = "colInvoiceDate";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Net Amount";
            this.colAmount.Name = "colAmount";
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            // 
            // colTaxableAmt
            // 
            this.colTaxableAmt.HeaderText = "Taxable Amount";
            this.colTaxableAmt.Name = "colTaxableAmt";
            // 
            // colCgst
            // 
            this.colCgst.HeaderText = "CGST Total";
            this.colCgst.Name = "colCgst";
            // 
            // colSgst
            // 
            this.colSgst.HeaderText = "SGST Total";
            this.colSgst.Name = "colSgst";
            // 
            // colIgst
            // 
            this.colIgst.HeaderText = "IGST Total";
            this.colIgst.Name = "colIgst";
            // 
            // colCustGstin
            // 
            this.colCustGstin.HeaderText = "Customer GSTIN";
            this.colCustGstin.Name = "colCustGstin";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1256, 30);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(384, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrintInvoice, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddInvoice, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteInvoice, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditInvoice, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1256, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.dataGridView1);
            this.tabCustomer.Controls.Add(this.flowLayoutPanel1);
            this.tabCustomer.Controls.Add(this.tableLayoutPanel1);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1256, 656);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customer List";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustName,
            this.colCustAddress,
            this.colCustLandmark,
            this.colCustCity,
            this.colCustPinCode,
            this.colCustState,
            this.dataGridViewTextBoxColumn4,
            this.colCustEmail,
            this.colCustContact,
            this.colCustPayTerms});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1256, 586);
            this.dataGridView1.TabIndex = 8;
            // 
            // colCustName
            // 
            this.colCustName.HeaderText = "Customer Name";
            this.colCustName.Name = "colCustName";
            // 
            // colCustAddress
            // 
            this.colCustAddress.HeaderText = "Customer Address";
            this.colCustAddress.Name = "colCustAddress";
            // 
            // colCustLandmark
            // 
            this.colCustLandmark.HeaderText = "Customer Landmark";
            this.colCustLandmark.Name = "colCustLandmark";
            // 
            // colCustCity
            // 
            this.colCustCity.HeaderText = "Customer City";
            this.colCustCity.Name = "colCustCity";
            // 
            // colCustPinCode
            // 
            this.colCustPinCode.HeaderText = "Customer PIN Code";
            this.colCustPinCode.Name = "colCustPinCode";
            // 
            // colCustState
            // 
            this.colCustState.HeaderText = "Customer State";
            this.colCustState.Name = "colCustState";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer GSTIN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // colCustEmail
            // 
            this.colCustEmail.HeaderText = "Customer Email";
            this.colCustEmail.Name = "colCustEmail";
            // 
            // colCustContact
            // 
            this.colCustContact.HeaderText = "Customer Contact No";
            this.colCustContact.Name = "colCustContact";
            // 
            // colCustPayTerms
            // 
            this.colCustPayTerms.HeaderText = "Customer Payment Terms";
            this.colCustPayTerms.Items.AddRange(new object[] {
            "Immediately",
            "15 Days",
            "30 Days",
            "60 Days",
            "More Than 60 Days"});
            this.colCustPayTerms.Name = "colCustPayTerms";
            this.colCustPayTerms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCustPayTerms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnFind);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1256, 30);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(3, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(294, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(303, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(384, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnPrintCust
            // 
            this.btnPrintCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrintCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPrintCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCust.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCust.Image")));
            this.btnPrintCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintCust.Location = new System.Drawing.Point(303, 3);
            this.btnPrintCust.Name = "btnPrintCust";
            this.btnPrintCust.Size = new System.Drawing.Size(94, 34);
            this.btnPrintCust.TabIndex = 3;
            this.btnPrintCust.Text = "Print";
            this.btnPrintCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintCust.UseVisualStyleBackColor = true;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCust.Image")));
            this.btnAddCust.Location = new System.Drawing.Point(3, 3);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(94, 34);
            this.btnAddCust.TabIndex = 0;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCust.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCust.Image")));
            this.btnDeleteCust.Location = new System.Drawing.Point(203, 3);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(94, 34);
            this.btnDeleteCust.TabIndex = 1;
            this.btnDeleteCust.Text = "Delete";
            this.btnDeleteCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditCust.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCust.Image")));
            this.btnEditCust.Location = new System.Drawing.Point(103, 3);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(94, 34);
            this.btnEditCust.TabIndex = 2;
            this.btnEditCust.Text = "Edit";
            this.btnEditCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCust.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
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
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustLandmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustPinCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustContact;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCustPayTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdQty;

    }
}