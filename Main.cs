using CS161_Practice5.ProgramingProblems;
using CS161_Practice5.Tutorials;

namespace CS161_Practice5
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void accountBalanceLoopButton_Click(object sender, EventArgs e)
        {
            Ending_Balance form = new Ending_Balance();
            form.Show();
        }

        private void endingBalanceButton_Click(object sender, EventArgs e)
        {
            Ending_Balance_v2 form = new Ending_Balance_v2();
            form.Show();
        }

        private void forLoopButton_Click(object sender, EventArgs e)
        {
            For_Loop form = new For_Loop();
            form.Show();
        }

        private void writingDataButton_Click(object sender, EventArgs e)
        {
            writingData form = new writingData();
            form.Show();
        }

        private void appendingDataButton_Click(object sender, EventArgs e)
        {
            Appending_Data form = new Appending_Data();
            form.Show();
        }

        private void loopToReadButton_Click(object sender, EventArgs e)
        {
            Loop_To_Read form = new Loop_To_Read();
            form.Show();
        }

        private void runningTotalButton_Click(object sender, EventArgs e)
        {
            Running_Total form = new Running_Total();
            form.Show();
        }

        private void coinTossSimButton_Click(object sender, EventArgs e)
        {
            Coin_Toss_Sim form = new Coin_Toss_Sim();
            form.Show();
        }

        private void loadEventButton_Click(object sender, EventArgs e)
        {
            Load_Event form = new Load_Event();
            form.Show();
        }

        private void distanceCalculatorButton_Click(object sender, EventArgs e)
        {
            Distance_Calculator form = new Distance_Calculator();
            form.Show();
        }

        private void CelsiusFarenheitButton_Click(object sender, EventArgs e)
        {
            Celsius_to_Fahrenheit form = new Celsius_to_Fahrenheit();
            form.Show();
        }

        private void populationButton_Click(object sender, EventArgs e)
        {
            Population form = new Population();
            form.Show();
        }

        private void pennies4PayButton_Click(object sender, EventArgs e)
        {
            Pennies_for_Pay form = new Pennies_for_Pay();
            form.Show();
        }

        private void oceanLevelsButton_Click(object sender, EventArgs e)
        {
            Ocean_Levels form = new Ocean_Levels();
            form.Show();
        }

        private void tuitionIncreaseButton_Click(object sender, EventArgs e)
        {
            Tuition_Increase form = new Tuition_Increase();
            form.Show();
        }

        private void diceSimulatorButton_Click(object sender, EventArgs e)
        {
            Dice_Simulator form = new Dice_Simulator();
            form.Show();
        }
    }
}