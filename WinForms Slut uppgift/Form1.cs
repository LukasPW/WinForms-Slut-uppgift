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
            sw.WriteLine("2. " + "Det som st�r i bin�r");
            sw.WriteLine("3. " + "�vers�tter till datorns spr�k");
            sw.WriteLine("4. " + "Det erbjuder st�d f�r visst t�nkande innom data sparning");
            sw.WriteLine("5. " + "Du l�ter ett program l�ra sig utifr�n data taget fr�n internet");
            sw.WriteLine("6. " + "1936");
            sw.WriteLine("7. " + "Nej");
            sw.WriteLine("8. " + "M�ngden transistorer i ett chip v�xer exponentiellt och dubblas varje 2 �r");
            sw.WriteLine("9. " + "Det kommer den nog inte att g�ras d� vi kommer n�rmare kvantum niv�n och det blir sv�rare att f�rutse elektronernas r�relser");
            sw.WriteLine("10. " + "Open source �r n�r k�llkoden f�r ett programm finns �ppen f�r allm�nheten, detta kan bidra till att programmet f�r flera uppdateringar som �r �nskade men kan �ven bidra till problem med hacking och s�kerhets relaterade fr�gor");
            sw.WriteLine("11. " + "Det g�r det l�ttare f�r b�de dig som egen person och  f�r m�jliga med arbetare att f�rst� sig p� vad det �r du har skrivit utan att beh�va s�tta sig och decifrerea hela tiden.");
            sw.WriteLine("12. " + "Det beh�vs olika verisoner f�r olika operativ system d� alla system inte har samma funktioner eller ger olika resultat, De olika verisionerna g�r s� att programmet g�t att k�ra p� flera system.");
            sw.WriteLine("13. " + "AI har gjort m�nga delar l�ttare d� man kan f� hj�lp p� dirketten eller f� kod f�rklarad f�r sig utan att beh�va v�nta men ingen vet hur detta kommer att �ndras i framtiden.");
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