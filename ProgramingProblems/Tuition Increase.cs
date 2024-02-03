namespace CS161_Practice5.ProgramingProblems
{
    public partial class Tuition_Increase : Form
    {
        public Tuition_Increase()
        {
            InitializeComponent();
        }

        private void Tuition_Increase_Load(object sender, EventArgs e)
        {
            decimal tuition = 6000m;
            decimal increaseRate = 1.02m;

            for (int year = 1; year <= 5; year++)
            {
                yearsTuitionListBox.Items.Add($" {year}, tuition is now {tuition.ToString("c")}.");
                tuition = (tuition * increaseRate);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
