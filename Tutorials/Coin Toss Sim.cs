namespace CS161_Practice5.Tutorials
{
    public partial class Coin_Toss_Sim : Form
    {
        public Coin_Toss_Sim()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUp;
            var rand = new Random();

            sideUp = rand.Next(2);

            switch (sideUp)
            {
                case 0:
                    tailsPictureBox.Visible = true;
                    headsPictureBox.Visible = false;

                    break;
                case 1:
                    tailsPictureBox.Visible = false;
                    headsPictureBox.Visible = true;

                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coin_Toss_Sim_Load(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = false;
            headsPictureBox.Visible = false;
        }
    }
}
