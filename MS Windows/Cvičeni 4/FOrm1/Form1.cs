using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOrm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB1.Text) && TB1.Text != "Zadej Jmeno")
            {
                Form2 form2 = new Form2(this.TB1.Text);
                this.Hide();
            }
            else TB1.Text ="Zadej Jmeno";
        }
    }
}
