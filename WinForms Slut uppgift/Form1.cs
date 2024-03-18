namespace WinForms_Slut_uppgift
{
    public partial class Form1 : Form
    {
        static string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/answers.txt";
        static string FacitDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/Facit.txt";
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void ProvhanterarenLabel_Click(object sender, EventArgs e)
        {
            //time I messed up
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //time I messed up
        }

        private void MainLayOutPanel_Paint(object sender, PaintEventArgs e)
        {
            //time I messed up
        }

        private void ReturnTest_Click(object sender, EventArgs e)
        {
            sw = File.CreateText(FacitDocPath);
            sw.WriteLine("1. " + "Skapa liv");
            sw.WriteLine("2. " + "Det som står i binär");
            sw.WriteLine("3. " + "Översätter till datorns språk");
            sw.WriteLine("4. " + "Det erbjuder stöd för visst tänkande innom data sparning");
            sw.WriteLine("5. " + "Du låter ett program lära sig utifrån data taget från internet");
            sw.WriteLine("6. " + "1936");
            sw.WriteLine("7. " + "Nej");
            sw.WriteLine("8. " + "Mängden transistorer i ett chip växer exponentiellt och dubblas varje 2 år");
            sw.WriteLine("9. " + "Det kommer den nog inte att göras då vi kommer närmare kvantum nivån och det blir svårare att förutse elektronernas rörelser");
            sw.WriteLine("10. " + "Open source är när källkoden för ett programm finns öppen för allmänheten, detta kan bidra till att programmet får flera uppdateringar som är önskade men kan öven bidra till problem med hacking och säkerhets relaterade frågor");
            sw.WriteLine("11. " + "Det gör det lättare för både dig som egen person och  för möjliga med arbetare att förstå sig på vad det är du har skrivit utan att behöva sätta sig och decifrerea hela tiden.");
            sw.WriteLine("12. " + "Det behövs olika verisoner för olika operativ system då alla system inte har samma funktioner eller ger olika resultat, De olika verisionerna gör så att programmet göt att köra på flera system.");
            sw.WriteLine("13. " + "AI har gjort många delar lättare då man kan få hjälp på dirketten eller få kod förklarad för sig utan att behöva vänta men ingen vet hur detta kommer att ändras i framtiden.");
            sw.Close();
            sw = File.CreateText(docpath);
            MessageBox.Show(docpath);
            List<FlowLayoutPanel> questions = MainLayOutPanel.Controls.OfType<FlowLayoutPanel>().ToList();
            for(int i = 0; i < questions.Count; i++)
            {
                string key = questions[i].Name + ". ";
                List<RadioButton> RadButtons = questions[i].Controls.OfType<RadioButton>().ToList();
                for (int j = 0; j < RadButtons.Count; j++)
                {
                    if (RadButtons[j].Checked)
                    {
                        key += RadButtons[j].Text;
                        sw.WriteLine(key);
                    }

                }
            }
            sw.WriteLine("9. " + textBox1.Text);
            sw.WriteLine("10. " + textBox2.Text);
            sw.WriteLine("11. " + textBox3.Text);
            sw.WriteLine("12." + textBox4.Text);
            sw.WriteLine("13. " + textBox5.Text);
            sw.Close();
           
        }
    }
}