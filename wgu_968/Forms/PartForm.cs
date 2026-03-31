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

namespace wgu_968.Forms
{
    public partial class PartForm : Form
    {
        public PartForm()
        {
            InitializeComponent();
        }

        private void Part_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Machine.Text = "Machine ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Part part;
            if (inHousebtn.Checked)
            {
                part = new Inhouse
                {
                    MachineId = int.Parse(machineTextBox.Text)
                };
            }
            else
            {
                part = new Outsourced()
                { CompanyName = machineTextBox.Text };
            }
            Random rand = new Random();
            part.PartID = rand.Next(1000,9999);
            part.Name = nameTextBox.Text;
            part.Price = decimal.Parse(priceTextBox.Text);
            part.Instock = int.Parse(inventoryTextBox.Text);
            part.Min = int.Parse(minTextBox.Text);
            part.Max = int.Parse(maxTextBox.Text);

            Inventory.AddPart(part);
            
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void OutSourcedbtn_CheckedChanged(object sender, EventArgs e)
        {
           Machine.Text = "Company Name";
        }

        private void partMaxLA_Click(object sender, EventArgs e)
        {

        }

        private void partCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
