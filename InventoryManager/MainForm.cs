using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class MainForm : Form
    {
        private readonly List<Product> _catalog = new();

        public MainForm()
        {
            InitializeComponent();
            btnAddProduct.Enabled = false;
            btnUpdateStock.Enabled = false;
            cmbFilterCategory.SelectedItem = "All";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string sku = txtSKU.Text.Trim();
            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();
            int quantity = (int)nudQuantity.Value;

            if (string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
            {
                lblStatus.Text = "Please fill all fields.";
                return;
            }

            if (_catalog.Any(p => p.SKU.Equals(sku, StringComparison.OrdinalIgnoreCase)))
            {
                lblStatus.Text = $"SKU {sku} already exists!";
                return;
            }

            _catalog.Add(new Product
            {
                SKU = sku,
                Name = name,
                Category = category,
                Quantity = quantity
            });

            lblStatus.Text = $"Product {sku} added!";
            ClearInput();
            RenderInventory();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            string sku = txtSKU.Text.Trim();
            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();
            int quantity = (int)nudQuantity.Value;

            var product = _catalog.FirstOrDefault(p => p.SKU.Equals(sku, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                lblStatus.Text = $"Product {sku} not found!";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                var result = MessageBox.Show($"Are you sure you want to update product {sku}?", "Confirm Update", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;
            }

            // Update all fields
            product.Name = name;
            product.Category = category;
            product.Quantity = quantity;

            lblStatus.Text = $"Product {sku} updated!";
            RenderInventory();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgInventory.SelectedRows.Count == 0)
            {
                lblStatus.Text = "No item selected!";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                var result = MessageBox.Show("Are you sure you want to remove selected products?", "Confirm Remove", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;
            }

            foreach (DataGridViewRow row in dgInventory.SelectedRows)
            {
                string sku = row.Cells["colSKU"].Value.ToString();
                var product = _catalog.FirstOrDefault(p => p.SKU.Equals(sku, StringComparison.OrdinalIgnoreCase));
                if (product != null) _catalog.Remove(product);
            }

            lblStatus.Text = "Selected products removed!";
            RenderInventory();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (_catalog.Count == 0) return;

            bool confirm = true;

            if (chkConfirmDelete.Checked)
            {
                var result = MessageBox.Show("Are you sure you want to clear all products?", "Confirm Clear", MessageBoxButtons.YesNo);
                confirm = result == DialogResult.Yes;
            }

            if (!confirm) return;

            _catalog.Clear();
            lblStatus.Text = "All products cleared!";
            RenderInventory();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            RenderInventory();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbFilterCategory.SelectedItem = "All";
            txtSearch.Clear();
            RenderInventory();
        }

        private void dgInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgInventory.SelectedRows.Count > 0)
            {
                var row = dgInventory.SelectedRows[0];
                lblStatus.Text = $"{row.Cells["colSKU"].Value} | {row.Cells["colName"].Value} | {row.Cells["colCategory"].Value} | Qty: {row.Cells["colQuantity"].Value}";

                // Auto-fill inputs for easier update
                txtSKU.Text = row.Cells["colSKU"].Value.ToString();
                txtName.Text = row.Cells["colName"].Value.ToString();
                cmbCategory.SelectedItem = row.Cells["colCategory"].Value.ToString();
                nudQuantity.Value = Convert.ToInt32(row.Cells["colQuantity"].Value);
            }
        }

        private void InputChanged(object sender, EventArgs e)
        {
            bool inputsValid = !string.IsNullOrWhiteSpace(txtSKU.Text)
                               && !string.IsNullOrWhiteSpace(txtName.Text)
                               && cmbCategory.SelectedItem != null;

            btnAddProduct.Enabled = inputsValid;
            btnUpdateStock.Enabled = _catalog.Any(p => p.SKU.Equals(txtSKU.Text.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void RenderInventory()
        {
            dgInventory.Rows.Clear();

            string filterCategory = cmbFilterCategory.SelectedItem?.ToString();
            string search = txtSearch.Text.Trim().ToLower();

            var filtered = _catalog.Where(p =>
                (filterCategory == "All" || p.Category == filterCategory) &&
                (string.IsNullOrEmpty(search) || p.SKU.ToLower().Contains(search) || p.Name.ToLower().Contains(search))
            );

            int totalQty = 0;

            foreach (var p in filtered)
            {
                dgInventory.Rows.Add(p.SKU, p.Name, p.Category, p.Quantity);
                totalQty += p.Quantity;
            }

            lblTotalQty.Text = $"Total Quantity: {totalQty}";
        }

        private void ClearInput()
        {
            txtSKU.Clear();
            txtName.Clear();
            cmbCategory.SelectedIndex = -1;
            nudQuantity.Value = 0;
            InputChanged(null, null);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblCategoryFilter_Click(object sender, EventArgs e) { }
    }
}
