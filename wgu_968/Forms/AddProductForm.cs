using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgu_968.model;

namespace wgu_968.Forms
{
    public partial class AddProductForm : Form
    {
        private BindingList<Part> tempParts = new BindingList<Part>();
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
            

            dataGridView2.DataSource = tempParts;
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
                int partId = Convert.ToInt32(inputPartTextField.Text);
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
            if (!int.TryParse(InventoryBox.Text, out int Instock) ||
                !decimal.TryParse(PriceBox1.Text, out decimal Price) ||
                !int.TryParse(MinBox.Text, out int Min) ||
                !int.TryParse(MaxBox.Text, out int Max))
            {
                MessageBox.Show("Please enter valid numeric field");
                return;
            }
            if (Min > Max)
            {
                MessageBox.Show("Min cannot be larger than Max");
                return;
            }
            if (Instock < Min || Instock > Max)
            {
                MessageBox.Show("Inventory must between min and max");
                return;
            }



            
            product.ProductID = int.Parse(textBox1.Text);
            product.Name = NameTextBox.Text;
            product.Price = decimal.Parse(PriceBox1.Text);
            product.Instock = int.Parse(InventoryBox.Text);
            product.Min = int.Parse(MinBox.Text);
            product.Max = int.Parse(MaxBox.Text);

            foreach (Part part in tempParts)
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
            tempParts.Add(part);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var assocaitedPart = (Part)dataGridView2.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show(
                  "Are you sure. Associated part will be deleted.",
                  "Deletion confirm?",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                tempParts.Remove(assocaitedPart);
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
