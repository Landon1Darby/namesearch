namespace namesearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<string> Names = new List<string>();

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("popular_names.txt");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                Names.Add(line);
            }
            streamReader.Close();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
                if (Names.Contains(InputTextBox.Text))
                {
                    answerLabel.Text = "this name is amoung the popular ones";
                }
                else 
                {
                    answerLabel.Text = "this name is NOT amoung the popular ones";
                }

        }
    }

}
