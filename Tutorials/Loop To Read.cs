namespace CS161_Practice5.Tutorials
{
    public partial class Loop_To_Read : Form
    {
        public Loop_To_Read()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getFriendsButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader inputFile = File.OpenText("Friends.txt");

                friendsLIstBox.Items.Clear();

                while(!inputFile.EndOfStream)
                {
                    friendsLIstBox.Items.Add(inputFile.ReadLine());
                }

                inputFile.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
