namespace CS161_Practice5.Tutorials
{
    public partial class Ending_Balance : Form
    {
        public Ending_Balance()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal balance;
            int months, count = 1;

            if(decimal.TryParse(startingBalanceTextBox.Text, out balance))
            {

                if(int.TryParse(monthsTextBox.Text, out months))
                {

                    while(count <= months)
                    {
                        count++;
                        balance = balance * 1.005m ;
                    }

                    endingBalanceLabel.Text = balance.ToString("c");

                }else
                {
                    MessageBox.Show("An invalid input has been entered for number of months.");
                }

            }else
            {
                MessageBox.Show("An invalid input has been entered for starting balance.");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalanceTextBox.Text = string.Empty;
            monthsTextBox.Text = string.Empty;
            endingBalanceLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
