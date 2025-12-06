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
            chkConfirmDelete = new CheckBox();
            btnClearAll = new Button();
            btnUpdateStock = new Button();
            btnRemoveSelected = new Button();
            btnAddProduct = new Button();
            numericUpDown1 = new NumericUpDown();
            lblQuantity = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            textBox1 = new TextBox();
            lblName = new Label();
            lblSKU = new Label();
            txtSKU = new TextBox();
            grpProductEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // grpProductEntry
            // 
            grpProductEntry.Controls.Add(chkConfirmDelete);
            grpProductEntry.Controls.Add(btnClearAll);
            grpProductEntry.Controls.Add(btnUpdateStock);
            grpProductEntry.Controls.Add(btnRemoveSelected);
            grpProductEntry.Controls.Add(btnAddProduct);
            grpProductEntry.Controls.Add(numericUpDown1);
            grpProductEntry.Controls.Add(lblQuantity);
            grpProductEntry.Controls.Add(cmbCategory);
            grpProductEntry.Controls.Add(lblCategory);
            grpProductEntry.Controls.Add(textBox1);
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
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(6, 230);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(174, 21);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confimer before deletion";
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
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(6, 168);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(130, 25);
            btnUpdateStock.TabIndex = 8;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(6, 199);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(130, 25);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
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
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(76, 122);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 25);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
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
            // textBox1
            // 
            textBox1.Location = new Point(76, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 25);
            textBox1.TabIndex = 2;
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 692);
            Controls.Add(grpProductEntry);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Manager";
            grpProductEntry.ResumeLayout(false);
            grpProductEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductEntry;
        private Label lblSKU;
        private TextBox txtSKU;
        private TextBox textBox1;
        private Label lblName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private NumericUpDown numericUpDown1;
        private Label lblQuantity;
        private Button btnAddProduct;
        private Button btnUpdateStock;
        private Button btnClearAll;
        private Button btnRemoveSelected;
        private CheckBox chkConfirmDelete;
    }
}
