namespace CS161_Practice5.Tutorials
{
    partial class Coin_Toss_Sim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coin_Toss_Sim));
            headsPictureBox = new PictureBox();
            tailsPictureBox = new PictureBox();
            tossButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headsPictureBox
            // 
            headsPictureBox.Image = (Image)resources.GetObject("headsPictureBox.Image");
            headsPictureBox.Location = new Point(15, 18);
            headsPictureBox.Name = "headsPictureBox";
            headsPictureBox.Size = new Size(152, 152);
            headsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            headsPictureBox.TabIndex = 0;
            headsPictureBox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            tailsPictureBox.BackColor = SystemColors.Control;
            tailsPictureBox.Image = (Image)resources.GetObject("tailsPictureBox.Image");
            tailsPictureBox.Location = new Point(15, 18);
            tailsPictureBox.Name = "tailsPictureBox";
            tailsPictureBox.Size = new Size(152, 152);
            tailsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tailsPictureBox.TabIndex = 1;
            tailsPictureBox.TabStop = false;
            // 
            // tossButton
            // 
            tossButton.Location = new Point(15, 188);
            tossButton.Name = "tossButton";
            tossButton.Size = new Size(75, 23);
            tossButton.TabIndex = 2;
            tossButton.Text = "Toss";
            tossButton.UseVisualStyleBackColor = true;
            tossButton.Click += tossButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(96, 188);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Coin_Toss_Sim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 229);
            Controls.Add(exitButton);
            Controls.Add(tossButton);
            Controls.Add(tailsPictureBox);
            Controls.Add(headsPictureBox);
            Name = "Coin_Toss_Sim";
            Text = "Coin_Toss_Sim";
            Load += Coin_Toss_Sim_Load;
            ((System.ComponentModel.ISupportInitialize)headsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox headsPictureBox;
        private PictureBox tailsPictureBox;
        private Button tossButton;
        private Button exitButton;
    }
}