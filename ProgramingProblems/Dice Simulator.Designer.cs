namespace CS161_Practice5.ProgramingProblems
{
    partial class Dice_Simulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diceOnePictureBox = new System.Windows.Forms.PictureBox();
            this.diceTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diceOnePictureBox
            // 
            this.diceOnePictureBox.Location = new System.Drawing.Point(9, 14);
            this.diceOnePictureBox.Name = "diceOnePictureBox";
            this.diceOnePictureBox.Size = new System.Drawing.Size(150, 150);
            this.diceOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceOnePictureBox.TabIndex = 0;
            this.diceOnePictureBox.TabStop = false;
            // 
            // diceTwoPictureBox
            // 
            this.diceTwoPictureBox.Location = new System.Drawing.Point(165, 14);
            this.diceTwoPictureBox.Name = "diceTwoPictureBox";
            this.diceTwoPictureBox.Size = new System.Drawing.Size(150, 150);
            this.diceTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceTwoPictureBox.TabIndex = 1;
            this.diceTwoPictureBox.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(9, 170);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(306, 32);
            this.rollButton.TabIndex = 2;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(9, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(306, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Dice_Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceTwoPictureBox);
            this.Controls.Add(this.diceOnePictureBox);
            this.Name = "Dice_Simulator";
            this.Text = "Dice_Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.diceOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox diceOnePictureBox;
        private PictureBox diceTwoPictureBox;
        private Button rollButton;
        private Button exitButton;
    }
}