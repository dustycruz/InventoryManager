namespace InventoryManager

{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpProductEntry = new GroupBox();
            lblStatus = new Label();
            lblTotalQty = new Label();
            btnResetFilter = new Button();
            btnApplyFilter = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbFilterCategory = new ComboBox();
            lblCategoryFilter = new Label();
            chkConfirmDelete = new CheckBox();
            btnClearAll = new Button();
            btnUpdateStock = new Button();
            btnRemoveSelected = new Button();
            btnAddProduct = new Button();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblSKU = new Label();
            txtSKU = new TextBox();
            dgInventory = new DataGridView();
            colSKU = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            grpProductEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgInventory).BeginInit();
            SuspendLayout();
            // 
            // grpProductEntry
            // 
            grpProductEntry.Controls.Add(lblStatus);
            grpProductEntry.Controls.Add(lblTotalQty);
            grpProductEntry.Controls.Add(btnResetFilter);
            grpProductEntry.Controls.Add(btnApplyFilter);
            grpProductEntry.Controls.Add(txtSearch);
            grpProductEntry.Controls.Add(lblSearch);
            grpProductEntry.Controls.Add(cmbFilterCategory);
            grpProductEntry.Controls.Add(lblCategoryFilter);
            grpProductEntry.Controls.Add(chkConfirmDelete);
            grpProductEntry.Controls.Add(btnClearAll);
            grpProductEntry.Controls.Add(btnUpdateStock);
            grpProductEntry.Controls.Add(btnRemoveSelected);
            grpProductEntry.Controls.Add(btnAddProduct);
            grpProductEntry.Controls.Add(nudQuantity);
            grpProductEntry.Controls.Add(lblQuantity);
            grpProductEntry.Controls.Add(cmbCategory);
            grpProductEntry.Controls.Add(lblCategory);
            grpProductEntry.Controls.Add(txtName);
            grpProductEntry.Controls.Add(lblName);
            grpProductEntry.Controls.Add(lblSKU);
            grpProductEntry.Controls.Add(txtSKU);
            grpProductEntry.Location = new Point(20, 20);
            grpProductEntry.Name = "grpProductEntry";
            grpProductEntry.Size = new Size(952, 314);
            grpProductEntry.TabIndex = 0;
            grpProductEntry.TabStop = false;
            grpProductEntry.Text = "Add/Update Product";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(481, 207);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 17);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Ready";
            // 
            // lblTotalQty
            // 
            lblTotalQty.AutoSize = true;
            lblTotalQty.Location = new Point(481, 168);
            lblTotalQty.Name = "lblTotalQty";
            lblTotalQty.Size = new Size(106, 17);
            lblTotalQty.TabIndex = 15;
            lblTotalQty.Text = "Total Quantity : 0";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(719, 89);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(130, 25);
            btnResetFilter.TabIndex = 14;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(583, 89);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(130, 25);
            btnApplyFilter.TabIndex = 13;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(553, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by SKU/Name";
            txtSearch.Size = new Size(310, 25);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += InputChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(497, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(50, 17);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search:";
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "Food", "Beverage", "Household", "Stationery", "Misc", "All" });
            cmbFilterCategory.Location = new Point(583, 54);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(120, 25);
            cmbFilterCategory.TabIndex = 10;
            cmbFilterCategory.SelectedIndexChanged += InputChanged;
            // 
            // lblCategoryFilter
            // 
            lblCategoryFilter.AutoSize = true;
            lblCategoryFilter.Location = new Point(481, 57);
            lblCategoryFilter.Name = "lblCategoryFilter";
            lblCategoryFilter.Size = new Size(96, 17);
            lblCategoryFilter.TabIndex = 9;
            lblCategoryFilter.Text = "Category Filter:";
            lblCategoryFilter.Click += lblCategoryFilter_Click;
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(6, 230);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(162, 21);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confim before deletion";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(142, 199);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(130, 25);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(6, 168);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(130, 25);
            btnUpdateStock.TabIndex = 8;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(6, 199);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(130, 25);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Transparent;
            btnAddProduct.Location = new Point(142, 168);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(130, 25);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(76, 122);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 25);
            nudQuantity.TabIndex = 6;
            nudQuantity.ValueChanged += InputChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(6, 124);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(59, 17);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Food", "Beverage", "Household", "Stationery", "Misc" });
            cmbCategory.Location = new Point(76, 86);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(120, 25);
            cmbCategory.TabIndex = 4;
            cmbCategory.TextChanged += InputChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 89);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 25);
            txtName.TabIndex = 2;
            txtName.TextChanged += InputChanged;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(6, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(46, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            lblName.Click += label1_Click;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(6, 21);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(35, 17);
            lblSKU.TabIndex = 0;
            lblSKU.Text = "SKU:";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(76, 18);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(310, 25);
            txtSKU.TabIndex = 0;
            txtSKU.TextChanged += InputChanged;
            // 
            // dgInventory
            // 
            dgInventory.AllowUserToAddRows = false;
            dgInventory.BackgroundColor = SystemColors.ButtonFace;
            dgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInventory.Columns.AddRange(new DataGridViewColumn[] { colSKU, colName, colCategory, colQuantity });
            dgInventory.Location = new Point(20, 362);
            dgInventory.Name = "dgInventory";
            dgInventory.ReadOnly = true;
            dgInventory.RowHeadersVisible = false;
            dgInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgInventory.Size = new Size(952, 200);
            dgInventory.TabIndex = 1;
            dgInventory.SelectionChanged += dgInventory_SelectionChanged;
            // 
            // colSKU
            // 
            colSKU.FillWeight = 121.827408F;
            colSKU.HeaderText = "SKU";
            colSKU.Name = "colSKU";
            colSKU.ReadOnly = true;
            colSKU.Width = 140;
            // 
            // colName
            // 
            colName.FillWeight = 78.17259F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 420;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 220;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 169;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 692);
            Controls.Add(dgInventory);
            Controls.Add(grpProductEntry);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Manager";
            grpProductEntry.ResumeLayout(false);
            grpProductEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductEntry;
        private Label lblSKU;
        private TextBox txtSKU;
        private TextBox txtName;
        private Label lblName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private Button btnAddProduct;
        private Button btnUpdateStock;
        private Button btnClearAll;
        private Button btnRemoveSelected;
        private CheckBox chkConfirmDelete;
        private Label lblSearch;
        private ComboBox cmbFilterCategory;
        private Label lblCategoryFilter;
        private TextBox txtSearch;
        private Button btnResetFilter;
        private Button btnApplyFilter;
        private DataGridView dgInventory;
        private DataGridViewTextBoxColumn colSKU;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private Label lblStatus;
        private Label lblTotalQty;
    }
}
