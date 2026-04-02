using InventoryManager.model;
using System;
using System.Linq;
using System.Windows.Forms;
using wgu_968.model;

namespace wgu_968.Forms
{
    public partial class PartForm : Form
    {
        private int GenerateID()
        {
            if (Inventory.AllParts.Count == 0)
                return 1;
            return Inventory.AllParts.Max(p => p.PartID) + 1;
        }

        public PartForm()
        {
            InitializeComponent();
            this.Load += Part_Load;
        }

        private void Part_Load(object sender, EventArgs e)
        {
            textBox1.Text = GenerateID().ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Machine.Text = "Machine ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Part part;
            if (!int.TryParse(inventoryTextBox.Text, out int Instock))
            {
                MessageBox.Show("Inventory field must be a Number/Interger");
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal Price))
            {
                MessageBox.Show("Price field must be a Decimal/Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(minTextBox.Text))
            {
                MessageBox.Show("Min field must not be empty");
                return;
            }
            if (!int.TryParse(minTextBox.Text, out int Min))
            {
                MessageBox.Show("Min field must be a number.");
                return;
            }

            if (!int.TryParse(maxTextBox.Text, out int Max))
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
            if (inHousebtn.Checked)
            {
                if (!int.TryParse(machineTextBox.Text, out int MachineId))
                {
                    MessageBox.Show("MachineID must be a numeric");
                    return;
                }
            }

            if (inHousebtn.Checked)
            {
                part = new Inhouse
                {
                    MachineID = int.Parse(machineTextBox.Text)
                };
            }
            else
            {
                part = new Outsourced()
                { CompanyName = machineTextBox.Text };
            }

            part.PartID = int.Parse(textBox1.Text);
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