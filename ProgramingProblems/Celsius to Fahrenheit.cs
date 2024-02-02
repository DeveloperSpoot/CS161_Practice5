namespace CS161_Practice5.ProgramingProblems
{
    public partial class Celsius_to_Fahrenheit : Form
    {
        public Celsius_to_Fahrenheit()
        {
            InitializeComponent();
        }

        private void Celsius_to_Fahrenheit_Load(object sender, EventArgs e)
        {
            decimal fahrenheit, celsius;
            decimal maxConversation = 20.00m;

            for (celsius = 0; celsius <= maxConversation; celsius++)
            {
                fahrenheit = ((9.00m / 5.00m) * celsius) + 32;
                tempsListBox.Items.Add($"{celsius}°C is {fahrenheit}°F.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
