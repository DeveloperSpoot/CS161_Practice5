namespace CS161_Practice5.ProgramingProblems
{
    public partial class Population : Form
    {
        public Population()
        {
            InitializeComponent();
        }

        private void Population_Load(object sender, EventArgs e)
        {
            decimal populationIncraseRate = 1.30m;
            int maxDays = 10;
            decimal numberOfOrganisms = 2.00m;

            for(int day =1 ; day <= maxDays; day++)
            {
                if(day == 1) { populationListBox.Items.Add($"Day 1 | Approx. Pop. 2 "); continue; }

                numberOfOrganisms = numberOfOrganisms * populationIncraseRate;
                populationListBox.Items.Add($"Day {day} | Approx. Pop. {numberOfOrganisms.ToString("f3")}");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
