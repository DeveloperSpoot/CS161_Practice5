namespace CS161_Practice5.Tutorials
{
    public partial class writingData : Form
    {
        public writingData()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter outputFile = new StreamWriter("Friends.txt");
                outputFile.WriteLine(friendsNameTextBox.Text);
                outputFile.Close();
                MessageBox.Show("Friend has been added.");
            }catch(Exception ex)
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
