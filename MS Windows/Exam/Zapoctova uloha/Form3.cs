using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Zapoctova_uloha
{
    public partial class Form3 : Form
    {


        public Form3(double a,string language3)
        {
            ResourceManager resourceManager = new ResourceManager("Zapoctova_uloha.Resourcecs_CZ", typeof(Resourcecs_CZ).Assembly);

            InitializeComponent();

            if(language3 == "Čeština")
            {

                string translation = resourceManager.GetString("label111");
                label1.Text = translation;

            }

            this.label1.Text = this.label1.Text + a + "%";

            
            if (a > 65) this.BackColor = Color.Green;
            else this.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
