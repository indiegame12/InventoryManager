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
    public partial class ModifyForm : Form
    {
        private Part part;
        private int partindex;

        public ModifyForm(Part selectedPart, int index)
        {
            InitializeComponent();
            part = selectedPart;
            partindex = index;
            textBox1.Text = part.PartID.ToString();
            textBox2.Text = part.Name.ToString();
            textBox3.Text = part.Instock.ToString();
            textBox4.Text = part.Price.ToString();
            textBox7.Text = part.Min.ToString();
            textBox6.Text = part.Max.ToString();
            if (part is Inhouse inhouse)
            {
                inHousebtn.Checked = true;
                Machine.Text = "Machine ID";
                textBox5.Text = inhouse.MachineId.ToString();
            }
            else if (part is Outsourced outsourced)
            {
                OutSourcedbtn.Checked = true;
                Machine.Text = "CompanyName";
                textBox5.Text = outsourced.CompanyName;
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
            Part updatedPart;
            if (inHousebtn.Checked)
            {
                updatedPart = new Inhouse();
                ((Inhouse)updatedPart).MachineId = int.Parse(Machine.Text);
            }
            else
            {
                updatedPart = new Outsourced();
                ((Outsourced)updatedPart).CompanyName = Machine.Text;
            }
            updatedPart.PartID = int.Parse(textBox1.Text);
            updatedPart.Name = textBox2.Text;
            updatedPart.Instock = int.Parse(textBox3.Text);
            updatedPart.Price = int.Parse(textBox4.Text);   
            updatedPart.Min = int.Parse(textBox7.Text);
            updatedPart.Max = int.Parse(textBox6.Text);

            Inventory.modifyPart(partindex, updatedPart);
            this.Close();
        }
    }
}
