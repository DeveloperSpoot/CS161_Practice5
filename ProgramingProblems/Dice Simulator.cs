namespace CS161_Practice5.ProgramingProblems
{
    public partial class Dice_Simulator : Form
    {
        public Dice_Simulator()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int diceRoll1 = random.Next(6);
            int diceRoll2 = random.Next(6);
            try
            {

                switch (diceRoll1)
                {
                    case 0:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die1;
                        break;
                    case 1:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die2;
                        break;
                    case 2:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die3;
                        break;
                    case 3:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die4;
                        break;
                    case 4:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die5;
                        break;
                    case 5:
                        diceOnePictureBox.Image = CS161_Practice5.Resource.Die6;
                        break;
                }

                switch (diceRoll2)
                {
                    case 0:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die1;
                        break;
                    case 1:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die2;
                        break;
                    case 2:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die3;
                        break;
                    case 3:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die4;
                        break;
                    case 4:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die5;
                        break;
                    case 5:
                        diceTwoPictureBox.Image = CS161_Practice5.Resource.Die6;
                        break;
                }

            }
            catch(Exception ex)
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
