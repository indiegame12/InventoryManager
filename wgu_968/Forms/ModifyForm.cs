using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wgu_968.Forms
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
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
    }
}
