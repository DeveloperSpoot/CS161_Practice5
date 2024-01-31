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
    }
}