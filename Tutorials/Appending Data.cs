namespace CS161_Practice5.Tutorials
{
    public partial class Appending_Data : Form
    {
        public Appending_Data()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter outputFile = File.AppendText("Friends.txt");
                outputFile.WriteLine(friendsNameTextBox.Text);
                outputFile.Close();

                friendsNameTextBox.Text = string.Empty;
                friendsNameTextBox.Focus();

                MessageBox.Show("Friend has been added.");
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
