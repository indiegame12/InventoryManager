using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using wgu_968.model;

namespace wgu_968.Forms
{
    public partial class ModifyProductForm : Form
    {
        private Product orginalProduct;
        private int productindex;
        private BindingList<Part> tempoaryStorageForAssociatedParts;

        public ModifyProductForm(Product selectedProduct, int index)
        {
            InitializeComponent();
            dgvModifyParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModifyProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModifyParts.DataSource = Inventory.AllParts;
            tempoaryStorageForAssociatedParts = new BindingList<Part>(selectedProduct.AssociatedParts.ToList());
            orginalProduct = selectedProduct;
            productindex = index;
            idbox.Text = selectedProduct.ProductID.ToString();
            namebox.Text = selectedProduct.Name.ToString();
            invbox.Text = selectedProduct.Instock.ToString();
            PriceBox.Text = selectedProduct.Price.ToString();
            minbox.Text = selectedProduct.Min.ToString();
            maxbox.Text = selectedProduct.Max.ToString();
            dgvModifyProduct.DataSource = tempoaryStorageForAssociatedParts;
        }

        private void partCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
        }

        private void partsavebtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (!int.TryParse(invbox.Text, out int Instock))
            {
                MessageBox.Show("Inventory field must be a Number/Interger");
                return;
            }

            if (!decimal.TryParse(PriceBox.Text, out decimal Price))
            {
                MessageBox.Show("Price field must be a Decimal/Number");
                return;
            }

            if (string.IsNullOrWhiteSpace(minbox.Text))
            {
                MessageBox.Show("Min field must not be empty");
                return;
            }

            if (!int.TryParse(minbox.Text, out int Min))
            {
                MessageBox.Show("Min field must be a number.");
                return;
            }

            if (!int.TryParse(maxbox.Text, out int Max))
            {
                MessageBox.Show("Max field must be a number.");
                return;
            }

            if (Min > Max)
            {
                MessageBox.Show("Min cannot be larger than Max");
                return;
            }

            if (Instock < Min || Instock > Max)
            {
                MessageBox.Show("Inventory is outside the min/max range");
                return;
            }

            product.ProductID = orginalProduct.ProductID;
            product.Name = namebox.Text;
            product.Instock = int.Parse(invbox.Text);
            product.Price = decimal.Parse(PriceBox.Text);
            product.Min = int.Parse(minbox.Text);
            product.Max = int.Parse(maxbox.Text);
            product.AssociatedParts = tempoaryStorageForAssociatedParts;

            Inventory.UpdateProduct(orginalProduct.ProductID, product);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var part = (Part)dgvModifyParts.CurrentRow.DataBoundItem;
            tempoaryStorageForAssociatedParts.Add(part);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var assocaitedPart = (Part)dgvModifyProduct.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show(
                 "Are you sure. Associated part will be deleted.",
                 "Deletion confirm?",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tempoaryStorageForAssociatedParts.Remove(assocaitedPart);
            }
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            dgvModifyParts.ClearSelection();
            if (inputPartTextField.Text != "")
            {
                int partId;
                partId = Convert.ToInt32(inputPartTextField.Text);
                Part part = Inventory.lookupPart(partId);

                if (part != null)
                {
                    dgvModifyParts.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part does not exist");
                }
                if (!int.TryParse(inputPartTextField.Text, out partId))
                {
                    MessageBox.Show("Only numbers can be entered into the search. Example 8");
       
                    return;
                }
             
            }
            else
            {
                dgvModifyParts.ClearSelection();
                dgvModifyParts.DataSource = Inventory.AllParts;
            }
        }

        private void dgvModifyParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModifyParts.ClearSelection();
        }

        private void dgvModifyProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvModifyProduct.ClearSelection();
        }
    }
}