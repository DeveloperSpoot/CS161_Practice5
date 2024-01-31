namespace CS161_Practice5.Tutorials
{
    public partial class For_Loop : Form
    {
        public For_Loop()
        {
            InitializeComponent();
        }

        private void displaySpeedsButton_Click(object sender, EventArgs e)
        {
            // MPH = KPH * 0.6214;
            int kph = 60;
            double mph;

            for(kph = 60; kph <= 130; kph +=10)
            {
                mph = kph * 0.6214;
                outputListBox.Items.Add($"{kph} KPH is the same as {mph.ToString("f")} MPH");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
