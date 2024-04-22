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
        

        private void ProvhanterarenLabel_Click(object sender, EventArgs e)// Dont know how to remove these
        {
            //time I messed up :)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //time I messed up
            /*
                             .-----.
                            / 7.  (
                           /   .-.  \
                          /   /   \  \
                         / `  )()
                        / `   )   ).  \
                      .'  _.   \_/  . |
     .--.           .' _.' )`.        |
    (    `---...._.'   `---.'_)    ..  \
     \            `----....___    `. \  |
      `.           _---- - _   `._  )/  |
        `.       / "  \   /"  \`.  `._ |
          `.    ((O)` ) ((O)` ) `.   `._\
            `--'`---'   `---' )  `.    `-.
               /                  ` \      `-.
             .'                      `.       `.
            /                     `  ` `.       `-.
     .--.   \ ===._____.======. `    `   `. .___.--`     .''''.
    ' .` `-. `.                )`. `   ` ` \          .'. '  8)
   (8.  ` `-.`.               ( .  ` `  .`\      .'  '    ' /
    \  `. `    `-.               ) ` .   ` ` \  .'   '.  '  /
     \ ` `.  ` . \`.    .--.     |  ` ) `   .``/ '  // .  /
      `.  ``. .   \ \   .-- `.  (  ` / _   ` . / ' .  ' /   .'
        `. ` \  `  \ \  '-.   `-'.'  `-.  `   .  .' /  .'
          \ `.`.  ` \ \    ) /`._.`       `.  ` .  .'  /
    LGB |  `.`. . \ \  (.'               `.   .'.'
        __ / .. \ \ ` ) \                     \.' .. \__
 .-._.- '     '"  ) .-'   `.                   (  '"     `-._.--.
(_________.-==== ' / .' /\_)`--..__________..-- `==== -._________)
                 (.'(.'
            */
        }

        private void MainLayOutPanel_Paint(object sender, PaintEventArgs e)
        {
            //time I messed up
            /*
                      .--._.--.
          ( O     O )
          /   . .   \
         .`._______.'.
        /(           )\
      _/  \  \   /  /  \_
   .~   `  \  \ /  /  '   ~.
  {    -.   \  V  /   .-    }
_ _`.    \  |  |  |  /    .'_ _
>_       _} |  |  | {_       _<
 /. - ~ ,_-'  .^.  `-_, ~ - .\
         '-'|/   \|`-`
            */
        }

        private void ReturnTest_Click(object sender, EventArgs e)
        {
            sw = File.CreateText(FacitDocPath); //Creates an answer sheet, the answers are written below
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
            List<FlowLayoutPanel> questions = MainLayOutPanel.Controls.OfType<FlowLayoutPanel>().ToList();//Searches through the main panel to find the where all the questions
            for(int i = 0; i < questions.Count; i++)
            {
                string key = questions[i].Name + ". ";
                List<RadioButton> RadButtons = questions[i].Controls.OfType<RadioButton>().ToList();//Serches through all the qestions to find and check what buttons are checked by the user
                for (int j = 0; j < RadButtons.Count; j++)
                {
                    if (RadButtons[j].Checked)//this is the part that looks if the buttons are checked
                    {
                        key += RadButtons[j].Text;
                        sw.WriteLine(key);//saves the cheked buttons to a .txt file
                    }

                }
            }
            sw.WriteLine("9. " + textBox1.Text); //saves all the textbox answes to the same .txt file
            sw.WriteLine("10. " + textBox2.Text);
            sw.WriteLine("11. " + textBox3.Text);
            sw.WriteLine("12." + textBox4.Text);
            sw.WriteLine("13. " + textBox5.Text);
            sw.Close();
           
        }
    }
}