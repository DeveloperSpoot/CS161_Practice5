namespace CS161_Practice5.Tutorials
{
    partial class For_Loop
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
            groupBox1 = new GroupBox();
            outputListBox = new ListBox();
            displaySpeedsButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outputListBox);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KPH to MPH";
            // 
            // outputListBox
            // 
            outputListBox.BackColor = SystemColors.ControlLight;
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new Point(11, 22);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(349, 199);
            outputListBox.TabIndex = 0;
            // 
            // displaySpeedsButton
            // 
            displaySpeedsButton.Location = new Point(25, 261);
            displaySpeedsButton.Name = "displaySpeedsButton";
            displaySpeedsButton.Size = new Size(349, 27);
            displaySpeedsButton.TabIndex = 1;
            displaySpeedsButton.Text = "Display Speeds";
            displaySpeedsButton.UseVisualStyleBackColor = true;
            displaySpeedsButton.Click += displaySpeedsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(25, 294);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(349, 27);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // For_Loop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 330);
            Controls.Add(exitButton);
            Controls.Add(displaySpeedsButton);
            Controls.Add(groupBox1);
            Name = "For_Loop";
            Text = "For_Loop";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox outputListBox;
        private Button displaySpeedsButton;
        private Button exitButton;
    }
}