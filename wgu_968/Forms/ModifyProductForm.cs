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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wgu_968.Forms
{
    public partial class ModifyProductForm : Form
    {
        private Product orginalProduct;
        private int productindex;
        private BindingList<Part> tempParts;
        public ModifyProductForm(Product selectedProduct, int index)
        {
            InitializeComponent();
            dgvModifyParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModifyProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModifyParts.DataSource = Inventory.AllParts;
            tempParts = new BindingList<Part>(selectedProduct.AssociatedParts.ToList());
            orginalProduct = selectedProduct;
            productindex = index;
            idbox.Text = selectedProduct.ProductID.ToString();
            namebox.Text = selectedProduct.Name.ToString();
            invbox.Text = selectedProduct.Instock.ToString();
            PriceBox.Text = selectedProduct.Price.ToString();
            minbox.Text = selectedProduct.Min.ToString();
            maxbox.Text = selectedProduct.Max.ToString();
            dgvModifyProduct.DataSource = tempParts;
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
            if (!int.TryParse(invbox.Text, out int Instock) ||
                !decimal.TryParse(PriceBox.Text, out decimal Price) ||
                !int.TryParse(minbox.Text, out int Min) ||
                !int.TryParse(maxbox.Text, out int Max)) 
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

            product.ProductID = orginalProduct.ProductID;
            product.Name = namebox.Text;
            product.Instock = int.Parse(invbox.Text);
            product.Price = decimal.Parse(PriceBox.Text);
            product.Min = int.Parse(minbox.Text);
            product.Max = int.Parse(maxbox.Text);
            product.AssociatedParts = tempParts;

            Inventory.UpdateProduct(orginalProduct.ProductID, product);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var part = (Part)dgvModifyParts.CurrentRow.DataBoundItem;
            tempParts.Add(part);
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
                tempParts.Remove(assocaitedPart);
            }
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            dgvModifyParts.ClearSelection();
            if (inputPartTextField.Text != "")
            {
                int partId = Convert.ToInt32(inputPartTextField.Text);
                Part part = Inventory.lookupPart(partId);
                if (part != null)
                {

                    dgvModifyParts.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part does not exist");
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

