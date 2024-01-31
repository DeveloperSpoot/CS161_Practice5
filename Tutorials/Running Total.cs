namespace CS161_Practice5.Tutorials
{
    public partial class Running_Total : Form
    {
        public Running_Total()
        {
            InitializeComponent();
        }

        private void readCalculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader inputFile = File.OpenText("Sales.txt");
                decimal total = 0;

                while(!inputFile.EndOfStream)
                {
                    decimal newSale = decimal.Parse(inputFile.ReadLine());
                    total += newSale;
                }

                inputFile.Close();
                
                totalSalesLabel.Text = total.ToString("C");

            }catch (Exception ex)
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
