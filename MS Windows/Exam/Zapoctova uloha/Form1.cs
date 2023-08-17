// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

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
    public partial class Form1 : Form
    {
        public int cds = 0;// Pro zlepšení jazyka 
        public string SelectedLanguage { get; internal set; } // předávání do ostatních FORMS

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTranslations()
        {
            // Získání vybraného jazyka z ComboBoxu
            string selectedLanguage = ComboBoxLanguage.SelectedItem.ToString();

            if (selectedLanguage == "Čeština")
            {
                // Vytvoření instance ResourceManager pro získání překladů
                ResourceManager resourceManager = new ResourceManager("Zapoctova_uloha.Resourcecs_CZ", typeof(Resourcecs_CZ).Assembly);

                // Načtení překladů pro jednotlivé ovládací prvky
                string translation = resourceManager.GetString("vitej");
                label1.Text = translation;

                string translation1 = resourceManager.GetString("uzivatel");
                label2.Text = translation1;

                string translation2 = resourceManager.GetString("heslo");
                label3.Text = translation2;

                string translation3 = resourceManager.GetString("checkbox");
                checkBox1.Text = translation3;

                string translation4 = resourceManager.GetString("zacatek");
                button1.Text = translation4;

                string translation5 = resourceManager.GetString("konec");
                button2.Text = translation5;
                if (cds == 1)
                {
                    string translation6 = resourceManager.GetString("podminka");
                    label4.Text = translation6;
                }
                if (cds == 2)
                {
                    string translation6 = resourceManager.GetString("label41");
                    label4.Text = translation6;
                }
                if (cds == 3)
                {
                    string translation6 = resourceManager.GetString("label42");
                    label4.Text = translation6;
                }
                if (cds == 4)
                {
                    string translation6 = resourceManager.GetString("label43");
                    label4.Text = translation6;
                }

            }
            else
            {
                label1.Text = "Welcome the Exam C_CPE_14";
                label2.Text = "Name and surname:";
                label3.Text = "Password: ";
                checkBox1.Text = "I agree with the terms of the Exam";
                button1.Text = "Start Exam";
                button2.Text = " Exit";
            }
        }

        string[] pole = { "Lukáš Semecký", "Tomáš Popelka", "Vlasta Burian" };// Pole uživatelů
        
        private void button1_Click(object sender, EventArgs e)
        {
            string vstupniJmeno = jmeno.Text;// přiřazení jmena k porovnání

            string selectedLanguage = ComboBoxLanguage.SelectedItem.ToString();
            ResourceManager resourceManager = new ResourceManager("Zapoctova_uloha.Resourcecs_CZ", typeof(Resourcecs_CZ).Assembly);

            if (pole.Contains(vstupniJmeno) && heslo.Text == "12345" && checkBox1.Checked)//Contains porovnává hodnoty v poli
            {
                Form2 form2 = new Form2(this.jmeno.Text,selectedLanguage);// Předávání jmena 
                form2.SelectedLanguage = selectedLanguage;
                form2.Show();
                this.Hide();
            }
            else if(pole.Contains(vstupniJmeno) && heslo.Text == "12345" && !checkBox1.Checked)// Pokud není zaskrnuty checkbox
            {
                cds = 1;
                label4.Visible = true;
                if (selectedLanguage == "Čeština")// Pro čestinu
                {
                    string translation5 = resourceManager.GetString("podminka");
                    label4.Text = translation5;
                }
                else label4.Text = "You  didn't agree to the terms and conditions";// objeví se label který je schovaný 
  
            }
            else if (pole.Contains(vstupniJmeno) && checkBox1.Checked && heslo.Text != "12345")//Pokud neni správné heslo
            {
                cds = 2;
                label4.Visible = true;
                if (selectedLanguage == "Čeština")// Pro čestinu
                {
                    string translation5 = resourceManager.GetString("label41");
                    label4.Text = translation5;
                }
                else label4.Text =  "You did not enter password correctly";// objeví se label který je schovaný 
                
            }
            else if (checkBox1.Checked && heslo.Text == "12345" && !pole.Contains(vstupniJmeno))//pokud není správné jmeno
            {
                cds = 3;
                label4.Visible = true;
                if (selectedLanguage == "Čeština")// Pro čestinu
                {
                    string translation5 = resourceManager.GetString("label42");
                    label4.Text = translation5;
                }
                else label4.Text = "You did not enter your name correctly";// objeví se label který je schovaný 
                
            }
            else// když není nic vyplněno 
            {
                cds = 4;
                label4.Visible = true;
                if (selectedLanguage == "Čeština")// Pro čestinu
                {
                    string translation5 = resourceManager.GetString("label43");
                    label4.Text = translation5;
                }
                else label4.Text = "You did not enter your name, password correctly or did not agree to the terms and conditions";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = ComboBoxLanguage.SelectedItem.ToString();

            if (selectedLanguage == "English")
            {
                LoadTranslations();
            }
            else if (selectedLanguage == "Čeština")
            {
                LoadTranslations();
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("cs");
                

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ComboBoxLanguage.Items.Add("English");
            ComboBoxLanguage.Items.Add("Čeština");

            ComboBoxLanguage.SelectedItem = "English"; // nastavení na Aglicky

            
        }
    }
}
