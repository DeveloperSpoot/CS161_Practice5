namespace CS161_Practice5.Tutorials
{
    public partial class Ending_Balance_v2 : Form
    {
        public Ending_Balance_v2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            endingBalanceListBox.Items.Clear();

            decimal balance;
            int months, count = 1;

            if (decimal.TryParse(startingBalanceTextBox.Text, out balance))
            {

                if (int.TryParse(monthsTextBox.Text, out months))
                {

                    while (count <= months)
                    {
                        balance = balance * 1.005m;
                        endingBalanceListBox.Items.Add($"Ending balane for month {count} is {balance.ToString("c")}.");
                        count++;
                    }


                }
                else
                {
                    MessageBox.Show("An invalid input has been entered for number of months.");
                }

            }
            else
            {
                MessageBox.Show("An invalid input has been entered for starting balance.");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalanceTextBox.Text = string.Empty;
            monthsTextBox.Text = string.Empty;
            endingBalanceListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
