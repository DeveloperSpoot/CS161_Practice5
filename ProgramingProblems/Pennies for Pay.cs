namespace CS161_Practice5.ProgramingProblems
{
    public partial class Pennies_for_Pay : Form
    {
        public Pennies_for_Pay()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int days = int.Parse(daysTextBox.Text);
                int currentPennies = 1;

                for(int currentDay = 1; currentDay <= days; currentDay++)
                {
                    penniesPerDayListBox.Items.Add($"Day {currentDay} | {currentPennies} Pennies");
                    currentPennies = currentPennies * 2;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
