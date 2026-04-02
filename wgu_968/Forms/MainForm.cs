using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wgu_968.Forms;
using wgu_968.model;


namespace wgu_968
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
            
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (inputPartTextField.Text != "")
            {
                int partId = Convert.ToInt32(inputPartTextField.Text);
                Part part = Inventory.lookupPart(partId);
                if (part != null)
                {
                    
                    dgvParts.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part does not exist");
                }

            }
            else
            {
               dgvParts.DataSource = Inventory.AllParts;
            }
            
        }

        private void leftPartsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void addpartbtn_Click(object sender, EventArgs e)
        {
            new PartForm().ShowDialog();
            dgvParts.ClearSelection();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void modifypartbtn_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("select part first"); 
                return;
            }
            int index = dgvParts.CurrentRow.Index;
            Part chosenPart = (Part)dgvParts.CurrentRow.DataBoundItem;
            ModifyForm form = new ModifyForm(chosenPart, index);
            form.ShowDialog();

            dgvParts.DataSource = null;
            dgvParts.DataSource = Inventory.AllParts;
          
        }

        private void addProductbtn_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }

        private void modifyProductbtn_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Select Product first");
                return;
            }
            int index = dgvProducts.CurrentRow.Index;
            Product chosenPart = (Product)dgvProducts.CurrentRow.DataBoundItem;
            ModifyProductForm form = new ModifyProductForm(chosenPart, index);
            form.ShowDialog();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = Inventory.Products;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletePartbtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part part)
            {
                foreach (Product product in Inventory.Products)
                {
                    if (product.AssociatedParts.Contains(part))
                    {
                        MessageBox.Show("Part is asscociated with a Product.");
                        return;
                    }
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure. Deletion cannot be reversed!",
                    "Deletion confirm?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool deleted = Inventory.DeletePart(part);

                    if (!deleted)
                    {
                        MessageBox.Show("Part could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No part selected.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteProductsbtn_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product product)
            {
                    if (product.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Product can't be deleted because a part is assigned to it.");
                        return;
                    }
                
                DialogResult result = MessageBox.Show(
                    "Are you sure. Deletion Cannot be reversed!",
                    "Deletion confirm?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bool deleted = Inventory.RemoveProduct(product.ProductID);
                    if (!deleted)
                    {
                        MessageBox.Show("Part could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("No part selected.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchProductbtn_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            if (inputProductTextField.Text != "")
            {
                int productId = Convert.ToInt32(inputProductTextField.Text);
                Product product = Inventory.lookupProduct(productId);
                if (product != null)
                {

                    dgvProducts.DataSource = new List<Product> { product };
                }
                else
                {
                    MessageBox.Show("Part does not exist");
                }

            }
            else
            {
                dgvProducts.ClearSelection();
                dgvProducts.DataSource = Inventory.Products;

            }

        }

        private void inputProductTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void dbc(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }
    }
    }

