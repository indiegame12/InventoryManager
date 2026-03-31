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
using wgu_968.Forms;
using wgu_968.model;

namespace wgu_968
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            dgvParts.DataSource = Inventory.Parts;
            dgvProducts.DataSource = Inventory.Products;
            
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
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
            dgvParts.ClearSelection();
            if (inputPartTextField.Text != "")
            {
                int partId = Convert.ToInt32(inputPartTextField.Text);
                Part part = Inventory.SearchPart(partId);
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
               dgvParts.DataSource = Inventory.Parts;
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
            new ModifyForm().ShowDialog();
        }

        private void addProductbtn_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }

        private void modifyProductbtn_Click(object sender, EventArgs e)
        {
            new ModifyProductForm().ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletePartbtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.DataBoundItem is Part part)
            {
               
                
                bool deleted = Inventory.DeletePart(part);
                if (!deleted)
                {
                    MessageBox.Show("Part could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No part selected.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
