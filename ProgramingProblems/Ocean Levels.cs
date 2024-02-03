namespace CS161_Practice5.ProgramingProblems
{
    public partial class Ocean_Levels : Form
    {
        public Ocean_Levels()
        {
            InitializeComponent();
        }

        private void Ocean_Levels_Load(object sender, EventArgs e)
        {
            double levelResin = 0;
            double increaseRate = 1.5;

            for(int year = 1; year <= 10; year++)
            {
                levelResin = (levelResin + increaseRate);
                yearsLevelsListBox.Items.Add($"Year {year}, ocean has resin by {levelResin}mm.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
