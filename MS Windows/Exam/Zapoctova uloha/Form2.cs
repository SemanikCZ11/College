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
    public partial class Form2 : Form
    {
        private List<Question> questions; // prazdný list pro ukládání otazek
        private int currentIndex = 0;// index pro otazky
        public int correctAswer = 0;// pro vypočet
        public string SelectedLanguage;
        public Form2(string a,string language)
        {
            InitializeComponent();
            SelectedLanguage = language;
            LoadLanguage(language);
            LoadQuestions(language);
            ShowQuestion(currentIndex);
     
            this.user.Text = this.user.Text + a + " - CPE_ 14 " ;// Předávání jména
        }

        private void LoadLanguage(string languageF2)
        {
            ResourceManager resourceManager = new ResourceManager("Zapoctova_uloha.Resourcecs_CZ", typeof(Resourcecs_CZ).Assembly);

            if (languageF2 == "Čeština")
            {
                // Načtení překladů pro jednotlivé ovládací prvky
                string translation = resourceManager.GetString("user.Text");
                user.Text = translation;

                string translation2 = resourceManager.GetString("bzpet");
                bprev.Text = translation2;

                string translation3 = resourceManager.GetString("bnext");
                bnext.Text = translation3;

                string translation4 = resourceManager.GetString("bsend");
                bsend.Text = translation4;

                string translation5 = resourceManager.GetString("pozice");
                pozice.Text = translation5;
            }

        }

        public class Question // Nastavení Class pro otázky
        {
            public string Text { get; set; } // do textu pridavav Get pro čtení a set pro zápis a string že to bude řetezec
            public List<string> Options { get; set; }// do textu pridavav Get pro čtení a set pro zápis a List  že to bude objekt odpovědí
            public int CorrectAnswerIndex { get; set; } // nastavení Indexu pro správnou odpověd
            public int UserAnswerIndex { get; set; } //Odpoved Uživatele
            public Question(string text, List<string> options, int correctAnswerIndex) // předávání parametru pro text odpovědi a správne odpovědi
            {
                Text = text;
                Options = options;
                CorrectAnswerIndex = correctAnswerIndex;
                UserAnswerIndex = -1;
            }
        }
        private void Transfer()
        {

            questions = new List<Question>();

            ResourceManager resourceManager = new ResourceManager("Zapoctova_uloha.Resourcecs_CZ", typeof(Resourcecs_CZ).Assembly);

            string translatedQuestion = resourceManager.GetString("question1");
            List<string> translatedAnswers = new List<string> { resourceManager.GetString("answer1"), resourceManager.GetString("answer2"), resourceManager.GetString("answer3") };

            string translatedQuestion1 = resourceManager.GetString("question2");
            List<string> translatedAnswers1 = new List<string> { resourceManager.GetString("answer4"), resourceManager.GetString("answer5"), resourceManager.GetString("answer6") };

            string translatedQuestion2 = resourceManager.GetString("question3");
            List<string> translatedAnswers2 = new List<string> { resourceManager.GetString("answer7"), resourceManager.GetString("answer8"), resourceManager.GetString("answer9") };

            string translatedQuestion3 = resourceManager.GetString("question4");
            List<string> translatedAnswers3 = new List<string> { resourceManager.GetString("answer10"), resourceManager.GetString("answer11"), resourceManager.GetString("answer12") };

            string translatedQuestion4 = resourceManager.GetString("question5");
            List<string> translatedAnswers4 = new List<string> { resourceManager.GetString("answer13"), resourceManager.GetString("answer14"), resourceManager.GetString("answer15") };

            string translatedQuestion5 = resourceManager.GetString("question6");
            List<string> translatedAnswers5 = new List<string> { resourceManager.GetString("answer16"), resourceManager.GetString("answer17"), resourceManager.GetString("answer18") };

            string translatedQuestion6 = resourceManager.GetString("question7");
            List<string> translatedAnswers6 = new List<string> { resourceManager.GetString("answer19"), resourceManager.GetString("answer20"), resourceManager.GetString("answer21") };

            string translatedQuestion7 = resourceManager.GetString("question8");
            List<string> translatedAnswers7 = new List<string> { resourceManager.GetString("answer22"), resourceManager.GetString("answer23"), resourceManager.GetString("answer24") };

            string translatedQuestion8 = resourceManager.GetString("question9");
            List<string> translatedAnswers8 = new List<string> { resourceManager.GetString("answer25"), resourceManager.GetString("answer26"), resourceManager.GetString("answer27") };

            string translatedQuestion9 = resourceManager.GetString("question10");
            List<string> translatedAnswers9 = new List<string> { resourceManager.GetString("answer28"), resourceManager.GetString("answer29"), resourceManager.GetString("answer30") };

            string translatedQuestion10 = resourceManager.GetString("question11");
            List<string> translatedAnswers10 = new List<string> { resourceManager.GetString("answer31"), resourceManager.GetString("answer32"), resourceManager.GetString("answer33") };

            string translatedQuestion11 = resourceManager.GetString("question12");
            List<string> translatedAnswers11 = new List<string> { resourceManager.GetString("answer34"), resourceManager.GetString("answer35"), resourceManager.GetString("answer36") };

            string translatedQuestion12 = resourceManager.GetString("question13");
            List<string> translatedAnswers12 = new List<string> { resourceManager.GetString("answer37"), resourceManager.GetString("answer38"), resourceManager.GetString("answer39") };

            string translatedQuestion13 = resourceManager.GetString("question14");
            List<string> translatedAnswers13 = new List<string> { resourceManager.GetString("answer40"), resourceManager.GetString("answer41"), resourceManager.GetString("answer42") };

            string translatedQuestion14 = resourceManager.GetString("question15");
            List<string> translatedAnswers14 = new List<string> { resourceManager.GetString("answer43"), resourceManager.GetString("answer44"), resourceManager.GetString("answer45") };



            Question question1CZ = new Question(translatedQuestion, translatedAnswers, 2); Question question2CZ = new Question(translatedQuestion1, translatedAnswers1, 1); Question question3CZ = new Question(translatedQuestion2, translatedAnswers2, 1);
            Question question4CZ = new Question(translatedQuestion3, translatedAnswers3, 0); Question question5CZ = new Question(translatedQuestion4, translatedAnswers4, 2); Question question6CZ = new Question(translatedQuestion5, translatedAnswers5, 2);
            Question question7CZ = new Question(translatedQuestion6, translatedAnswers6, 2); Question question8CZ = new Question(translatedQuestion7, translatedAnswers7, 0); Question question9CZ = new Question(translatedQuestion8, translatedAnswers8, 1);
            Question question10CZ = new Question(translatedQuestion9, translatedAnswers9, 2); Question question11CZ = new Question(translatedQuestion10, translatedAnswers10, 2); Question question12CZ = new Question(translatedQuestion11, translatedAnswers11, 2);
            Question question13CZ = new Question(translatedQuestion12, translatedAnswers12, 0); Question question14CZ = new Question(translatedQuestion13, translatedAnswers13, 1); Question question15CZ = new Question(translatedQuestion14, translatedAnswers14, 0);

            questions.Add(question1CZ); questions.Add(question2CZ); questions.Add(question3CZ); questions.Add(question4CZ);
            questions.Add(question5CZ); questions.Add(question6CZ); questions.Add(question7CZ); questions.Add(question8CZ);
            questions.Add(question9CZ); questions.Add(question10CZ); questions.Add(question11CZ); questions.Add(question12CZ);
            questions.Add(question13CZ); questions.Add(question14CZ); questions.Add(question15CZ);










        }
        private void TransferEN()
        {
            questions = new List<Question>(); // Vytváří prázdný list kam ukládám otázky

            Question question1 = new Question("What is the standard health check time limit of a Cloud Foundry application?", new List<string> { "90 seconds", "30 seconds", "60 seconds" }, 2);
            Question question2 = new Question("After what period of time does GitHub remove unused personal access tokens? ", new List<string> { "1 month", "1 year", "100 days" }, 1);
            Question question3 = new Question("According to SAP CAP best practices, which error types should you NOT catch?", new List<string> { "Programming errors", "Unexpected errors", "Runtime errors" }, 1);
            Question question4 = new Question("Which pattern do you use to register an event handler?", new List<string> { "srv.Q", "phase.O", "YAML files relyon correct indentation." }, 0);
            Question question5 = new Question("What are some characteristics of YAML files?", new List<string> { "YAML files are based on XM", "YAML files are also valid JSON files.", "event.()" }, 2);
            Question question6 = new Question("JSON is based on which programming language?", new List<string> { "Julia", "Java", "JavaScript" }, 2);
            Question question7 = new Question("How many event handlers can you register for one event phase?", new List<string> { "exactly one", "exactly three", "multiple" }, 2);
            Question question8 = new Question("What is the maximum number of running threads per application instance?", new List<string> { "10420", "8192", "14200" }, 0);
            Question question9 = new Question("In CAP, which keyword is used to send events?", new List<string> { "throw", "emit", "stream" }, 1);
            Question question10 = new Question("When deploying applications on SAP BTP, what is the maximum application package size?", new List<string> { "2 GB", "2.5 GB", "1.5 GB" }, 2);
            Question question11 = new Question("On SAP BTP, what request rate limit tries to protect the Cloud Foundry API against misuse?", new List<string> { "50k requests per hour for all users", "100k requests per hour per user", "10k requests per hour per user" }, 2);
            Question question12 = new Question("How many administrators can be assigned to a global account?", new List<string> { "0-1", "0-n", "1-n" }, 2);
            Question question13 = new Question("Which criticality value is assigned to Negative criticality?", new List<string> { "1", "2", "3" }, 0);
            Question question14 = new Question("When using namespaces, what does SAP recommend you use to construct names for namespace", new List<string> { "Your organization's name", "Reverse domain names", "Cascades of acronyms" }, 1);
            Question question15 = new Question("At what level can you select a region?", new List<string> { "Global account", "Subaccount", "Directory" }, 0);

            questions.Add(question1); questions.Add(question2); questions.Add(question3); questions.Add(question4);
            questions.Add(question5); questions.Add(question6); questions.Add(question7); questions.Add(question8);
            questions.Add(question9); questions.Add(question10); questions.Add(question11); questions.Add(question12);
            questions.Add(question13); questions.Add(question14); questions.Add(question15);



        }

        private void LoadQuestions(string languageF3) // Načítání  otázek které vytvořím
        {
            if (languageF3 == "English")
            {
                TransferEN();
            }    
            else if (languageF3 == "Čeština")
            {
                Transfer();
            }
        }
        private void ShowQuestion(int currentIndex)
        {
            string TR;

            if (SelectedLanguage == "Čeština") TR = "Otazka: ";
            else TR = "Question: ";

           
            if (currentIndex == questions.Count - 1)
            {
                bsend.Visible = true; // zobrazení Button submit
                bnext.Visible = false;
            }


            if (currentIndex >= 0 && currentIndex < questions.Count)
            {
                int c = currentIndex + 1;// Nastavení indexu na 1 

                pozice.Text = TR + "" + c; 
                Question question = questions[currentIndex];
                otazka.Text = question.Text;

                // Přiřazení správných hodnot k jednotlivým checkboxům
                checkBox1.Text = question.Options[0];
                checkBox2.Text = question.Options[1];
                checkBox3.Text = question.Options[2];

            }
            
        }

        private void bprev_Click(object sender, EventArgs e)// Button pro otazky dozadu
        {
            currentIndex--;
            ShowQuestion(currentIndex);
            bsend.Visible = false;
            bnext.Visible = true;
        }

        private void bnext_Click(object sender, EventArgs e)// button pro otazky dopředu
        {
            Question question = questions[currentIndex];// Otazka 

            checkBox1.Text = question.Options[0];
            checkBox2.Text = question.Options[1];
            checkBox3.Text = question.Options[2];

            if (checkBox1.Checked) question.UserAnswerIndex = 0;
            else if (checkBox2.Checked) question.UserAnswerIndex = 1;
            else if (checkBox3.Checked) question.UserAnswerIndex = 2;
            else question.UserAnswerIndex = -1;

            // přiřazení odpovedí 
            int correctAnswerIndex = question.CorrectAnswerIndex; // index správné odpovědi
            int userAnswerIndex = question.UserAnswerIndex; // index odpovědi uživatele 
            bool isAnswerCorrect = (userAnswerIndex == correctAnswerIndex);

            if (isAnswerCorrect == true) // Pokud je otazka správná připočítá se správná odpověd 
            {
                correctAswer = correctAswer +1;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
            else // pokud není jenom se pro další otázku vymaže poslední zaskrtnutí
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }


            currentIndex++;// posun indexu a vypsání další otázky 
            ShowQuestion(currentIndex);
        }
        private void bsend_Click(object sender, EventArgs e)// Send který se zobrazí až na poslední otázce a poslání výsledku
        {
            // Vyhodnocení poslední otazky už přes odesilácí Button 
            Question question = questions[currentIndex];

            checkBox1.Text = question.Options[0];
            checkBox2.Text = question.Options[1];
            checkBox3.Text = question.Options[2];

            if (checkBox1.Checked) question.UserAnswerIndex = 0;
            else if (checkBox2.Checked) question.UserAnswerIndex = 1;
            else if (checkBox3.Checked) question.UserAnswerIndex = 2;
            else question.UserAnswerIndex = -1;

            // přiřazení odpovedí 
            int correctAnswerIndex = question.CorrectAnswerIndex; // index správné odpovědi
            int userAnswerIndex = question.UserAnswerIndex; // index odpovědi uživatele 
            bool isAnswerCorrect = (userAnswerIndex == correctAnswerIndex);

            if (isAnswerCorrect == true) correctAswer = correctAswer + 1;

            double vys;
            vys = Math.Ceiling((double)correctAswer / 15 * 100); // Výpočet procent 

            Form3 form3 = new Form3(vys,SelectedLanguage);
            form3.Show();
            this.Hide();
        }
        
    }
   
}
