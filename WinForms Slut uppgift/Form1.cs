namespace WinForms_Slut_uppgift
{
    public partial class Form1 : Form
    {
        static string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/answers.txt";
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
            sw = File.CreateText(docpath);
            MessageBox.Show(docpath);
            List<FlowLayoutPanel> questions = MainLayOutPanel.Controls.OfType<FlowLayoutPanel>().ToList();
            for(int i = 0; i < questions.Count(); i++)
            {
                string key = i + 1 + ". ";
                FlowLayoutPanel question = questions[i];
                List<RadioButton> RadButtons = MainLayOutPanel.Controls.OfType<RadioButton>().ToList();
                for (int j = 0; j < RadButtons.Count(); j++)
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