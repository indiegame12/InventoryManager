using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using wgu_968.model;

namespace wgu_968.Forms
{
    public partial class AddProductForm : Form
    {
        private BindingList<Part> tempoaryStorageForAssociatedParts = new BindingList<Part>();

        private int GenerateID()
        {
            if (Inventory.Products.Count == 0)
                return 1;
            return Inventory.Products.Max(p => p.ProductID) + 1;
        }

        public AddProductForm()
        {
            InitializeComponent();
            this.Load += AddProductForm_Load;
            dgvAddProduct.DataSource = Inventory.AllParts;
            dgvAddProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.DataSource = tempoaryStorageForAssociatedParts;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void inputPartTextField_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            dgvAddProduct.ClearSelection();
            if (inputPartTextField.Text != "")
            {
                int partId;

                if (!int.TryParse(inputPartTextField.Text, out partId))
                {
                    MessageBox.Show("Only numbers can be entered into the search. Example 8");
                    return;
                }

                partId = Convert.ToInt32(inputPartTextField.Text);
                Part part = Inventory.lookupPart(partId);
                if (part != null)
                {
                    dgvAddProduct.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part does not exist");
                }
            }
            else
            {
                dgvAddProduct.ClearSelection();
                dgvAddProduct.DataSource = Inventory.AllParts;
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = GenerateID().ToString();
        }

        private void partCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void partsavebtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (!int.TryParse(InventoryBox.Text, out int Instock))
            {
                MessageBox.Show("Inventory field must be a Number/Interger");
                return;
            }

            if (!decimal.TryParse(PriceBox1.Text, out decimal Price))
            {
                MessageBox.Show("Price field must be a Decimal/Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(MinBox.Text))
            {
                MessageBox.Show("Min field must not be empty");
                return;
            }

            if (!int.TryParse(MinBox.Text, out int Min))
            {
                MessageBox.Show("Min field must be a number.");
                return;
            }

            if (!int.TryParse(MaxBox.Text, out int Max))
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

            product.ProductID = int.Parse(textBox1.Text);
            product.Name = NameTextBox.Text;
            product.Price = decimal.Parse(PriceBox1.Text);
            product.Instock = int.Parse(InventoryBox.Text);
            product.Min = int.Parse(MinBox.Text);
            product.Max = int.Parse(MaxBox.Text);

            foreach (Part part in tempoaryStorageForAssociatedParts)
            {
                product.AssociatedParts.Add(part);
            }
            Inventory.AddProduct(product);

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            var part = (Part)dgvAddProduct.CurrentRow.DataBoundItem;
            tempoaryStorageForAssociatedParts.Add(part);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedAssocaitedPart = (Part)dataGridView2.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show(
                  "Are you sure. Associated part will be deleted.",
                  "Deletion confirm?",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tempoaryStorageForAssociatedParts.Remove(selectedAssocaitedPart);
            }
        }

        private void dgvAddProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAddProduct.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }
    }
}