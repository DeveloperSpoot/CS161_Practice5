namespace CS161_Practice5.Tutorials
{
    public partial class Load_Event : Form
    {
        public Load_Event()
        {
            InitializeComponent();
        }

        private void Load_Event_Load(object sender, EventArgs e)
        {
            try
            {

                StreamReader inputFile = File.OpenText("Friends.txt");

                friendsLIstBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    friendsLIstBox.Items.Add(inputFile.ReadLine());
                }

                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
