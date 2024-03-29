﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Practice5.ProgramingProblems
{
    public partial class Distance_Calculator : Form
    {
        public Distance_Calculator()
        {
            InitializeComponent();
        }

        private void onInput(object sender, EventArgs e){
            if(mphTextBox.Text == "" || hoursTextBox.Text == "") { return; }
            hoursMphListbox.Items.Clear();

            int mph, hours;

            try
            {
                StreamWriter outputFile = new StreamWriter("DistanceTraveled.txt");

                if(int.TryParse(mphTextBox.Text, out mph) && int.TryParse(hoursTextBox.Text, out hours)){
                    for (int i = 1; i <= hours; i++) {
                    hoursMphListbox.Items.Add($"After hour {i} distance traveled is {i*mph}.");
                        outputFile.WriteLine($"After hour {i} distance traveled is {i * mph}.");
                    }

                    outputFile.Close();

                    MessageBox.Show("Distance Traveled has been written to the file.");
            }   else
                {
                    MessageBox.Show("Invalid text intered into the inputs, please only input intergers.");
                }
            }catch(Exception ex){
                    MessageBox.Show(ex.Message);
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
