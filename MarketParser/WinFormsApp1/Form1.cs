namespace MarketParser
{
    public partial class Form1 : Form
    {
        public List<string> Items;
       
        IParseFromWebSite parser;

        CitiesAndMarkets cam;

        public Form1()
        {
            InitializeComponent();
            cam = new CitiesAndMarkets();

            Items = new List<string>();

            textBox1.Enabled = false;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listBox1.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Скидки найдены");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Items.Add(listBox1.Items[i].ToString());
            }
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Items.Clear();
            textBox1.Clear();
            textBox1.Enabled = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                if(comboBox1.SelectedItem == "Дикси")
                {
                    parser = new ParseFromDixi();
                }
                else
                {
                    var market = cam.markets[comboBox1.SelectedItem.ToString()];
                    var city = cam.cities[comboBox2.SelectedItem.ToString()];

                    parser = new ParseFromSkidkaOnline(market.id, city.id);
                }

                    
                parser.OnCompleted += Parser_OnCompleted;
                parser.OnNewData += Parser_OnNewData;
                parser.Start();

                button3.Enabled = false;
                button4.Enabled = false;
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public async Task Search(ListBox listBox, List<string> items)
        {
            var indexes = new List<int>();
            
            List<string> s = new();

            List<string> wordsInString = null;

            foreach(var i in items)
            {
                s.Add(i);
            }

            if(textBox1.Text.Contains(' '))
            {
                wordsInString = textBox1.Text.Split(' ').ToList();
            }

            for (int i = 0; i<s.Count; i++)
            {
                if (wordsInString == null)
                {
                    if (s[i].ToLower().Contains(textBox1.Text.ToLower().Trim()))
                    {
                        indexes.Add(i);
                    }
                }
                else
                {
                    bool isWordSuit = true;
                    
                    foreach(var word in wordsInString)
                    {
                        if (!s[i].ToLower().Contains(word.ToLower().Trim()))
                        {
                            isWordSuit = false;
                        }
                    }
                    if(isWordSuit)
                        indexes.Add(i);
                }
            }
            
            listBox.Items.Clear();
               
            foreach(var i in indexes)
            {
                listBox.Items.Add(s[i]);
            }
            
            
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
             await Search(listBox1, Items);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



       
    }
}