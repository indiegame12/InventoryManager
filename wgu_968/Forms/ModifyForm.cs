using InventoryManager.model;
using System;
using System.Windows.Forms;
using wgu_968.model;

namespace wgu_968.Forms
{
    public partial class ModifyForm : Form
    {
        private Part orginalPart;
        private int partindex;

        public ModifyForm(Part selectedPart, int index)
        {
            InitializeComponent();
            orginalPart = selectedPart;
            partindex = index;
            textBox1.Text = selectedPart.PartID.ToString();
            textBox2.Text = selectedPart.Name.ToString();
            textBox3.Text = selectedPart.Instock.ToString();
            textBox4.Text = selectedPart.Price.ToString();
            textBox7.Text = selectedPart.Min.ToString();
            textBox6.Text = selectedPart.Max.ToString();
            if (selectedPart is Inhouse inhouse)
            {
                inHousebtn.Checked = true;
                Machine.Text = "MachineID";
                textBox5.Text = inhouse.MachineID.ToString();
            }
            else if (selectedPart is Outsourced outsourced)
            {
                OutSourcedbtn.Checked = true;
                Machine.Text = "CompanyName";
                textBox5.Text = outsourced.CompanyName.ToString();
            }
        }

        private void inHousebtn_CheckedChanged(object sender, EventArgs e)
        {
            Machine.Text = "Machine ID";
        }

        private void OutSourcedbtn_CheckedChanged(object sender, EventArgs e)
        {
            Machine.Text = "Company Name";
        }

        private void partCancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
        }

        private void partsavebtn_Click(object sender, EventArgs e)
        {
            Part part;
            if (!int.TryParse(textBox3.Text, out int Instock))
            {
                MessageBox.Show("Inventory field must be a Number/Interger");
                return;
            }
            if (!decimal.TryParse(textBox4.Text, out decimal Price))
            {
                MessageBox.Show("Price field must be a Decimal/Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Min field must not be empty");
                return;
            }
            if (!int.TryParse(textBox7.Text, out int Min))
            {
                MessageBox.Show("Min field must be a number.");
                return;
            }
            if (!int.TryParse(textBox6.Text, out int Max))
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
                MessageBox.Show("Inventory is outside of min/max range");
                return;
            }
            if (inHousebtn.Checked)
            {
                if (!int.TryParse(textBox5.Text, out int MachineId))
                {
                    MessageBox.Show("MachineID must be a numeric");
                    return;
                }
            }

            if (inHousebtn.Checked)
            {
                part = new Inhouse();

                ((Inhouse)part).MachineID = int.Parse(textBox5.Text);
            }
            else
            {
                part = new Outsourced();
                ((Outsourced)part).CompanyName = textBox5.Text.ToString();
            }

            part.PartID = orginalPart.PartID;
            part.Name = textBox2.Text;
            part.Instock = int.Parse(textBox3.Text);
            part.Price = decimal.Parse(textBox4.Text);
            part.Min = int.Parse(textBox7.Text);
            part.Max = int.Parse(textBox6.Text);

            Inventory.updatePart(orginalPart.PartID, part);
            this.Close();
        }

        private void Machine_Click(object sender, EventArgs e)
        {
        }
    }
}