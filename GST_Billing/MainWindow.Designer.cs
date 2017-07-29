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
            this.tbSearchProducts = new System.Windows.Forms.TextBox();
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
            this.colReceivedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpSearchInvoice = new System.Windows.Forms.FlowLayoutPanel();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbSearchInvoice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tlpInvoiceBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
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
            this.tbSearchCust = new System.Windows.Forms.TextBox();
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
            this.flpSearchInvoice.SuspendLayout();
            this.tlpInvoiceBtns.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProducts.Controls.Add(this.dataGridView2);
            this.tabProducts.Controls.Add(this.flowLayoutPanel3);
            this.tabProducts.Controls.Add(this.tableLayoutPanel3);
            this.tabProducts.Location = new System.Drawing.Point(4, 25);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(1256, 653);
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
            this.dataGridView2.Location = new System.Drawing.Point(0, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1254, 586);
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
            this.flowLayoutPanel3.Controls.Add(this.tbSearchProducts);
            this.flowLayoutPanel3.Controls.Add(this.button7);
            this.flowLayoutPanel3.Controls.Add(this.button8);
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
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(303, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 29);
            this.button7.TabIndex = 1;
            this.button7.Text = "Find";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(384, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Clear";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1254, 40);
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
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1254, 586);
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
            // colReceivedAmt
            // 
            this.colReceivedAmt.HeaderText = "Payment";
            this.colReceivedAmt.Name = "colReceivedAmt";
            // 
            // flpSearchInvoice
            // 
            this.flpSearchInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSearchInvoice.Controls.Add(this.lbStartDate);
            this.flpSearchInvoice.Controls.Add(this.dateTimePicker1);
            this.flpSearchInvoice.Controls.Add(this.label1);
            this.flpSearchInvoice.Controls.Add(this.dateTimePicker2);
            this.flpSearchInvoice.Controls.Add(this.tbSearchInvoice);
            this.flpSearchInvoice.Controls.Add(this.button1);
            this.flpSearchInvoice.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(549, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(630, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
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
            this.tlpInvoiceBtns.Controls.Add(this.btn, 4, 0);
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
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(403, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 34);
            this.btn.TabIndex = 4;
            this.btn.Text = "Payment";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCustomer.Controls.Add(this.dataGridView1);
            this.tabCustomer.Controls.Add(this.flowLayoutPanel1);
            this.tabCustomer.Controls.Add(this.tableLayoutPanel1);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1256, 653);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1254, 586);
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
            this.flowLayoutPanel1.Controls.Add(this.tbSearchCust);
            this.flowLayoutPanel1.Controls.Add(this.btnFind);
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
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
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(303, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 29);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(384, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 40);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.flpSearchInvoice.ResumeLayout(false);
            this.flpSearchInvoice.PerformLayout();
            this.tlpInvoiceBtns.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbSearchCust;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.FlowLayoutPanel flpSearchInvoice;
        private System.Windows.Forms.TextBox tbSearchInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tlpInvoiceBtns;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox tbSearchProducts;
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
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btn;

    }
}