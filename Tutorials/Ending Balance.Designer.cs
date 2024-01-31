namespace CS161_Practice5.Tutorials
{
    partial class Ending_Balance
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            endingBalanceLabel = new Label();
            startingBalanceTextBox = new TextBox();
            monthsTextBox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Starting Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Number of Months:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endingBalanceLabel);
            groupBox1.Location = new Point(14, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 76);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ending Balance:";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // endingBalanceLabel
            // 
            endingBalanceLabel.BackColor = SystemColors.ControlLight;
            endingBalanceLabel.Location = new Point(10, 30);
            endingBalanceLabel.Name = "endingBalanceLabel";
            endingBalanceLabel.Size = new Size(302, 29);
            endingBalanceLabel.TabIndex = 0;
            endingBalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startingBalanceTextBox
            // 
            startingBalanceTextBox.Location = new Point(132, 19);
            startingBalanceTextBox.Name = "startingBalanceTextBox";
            startingBalanceTextBox.Size = new Size(203, 23);
            startingBalanceTextBox.TabIndex = 3;
            // 
            // monthsTextBox
            // 
            monthsTextBox.Location = new Point(132, 51);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(203, 23);
            monthsTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(24, 187);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(137, 187);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(250, 187);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Ending_Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 224);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(monthsTextBox);
            Controls.Add(startingBalanceTextBox);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ending_Balance";
            Text = "Ending_Balance";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label endingBalanceLabel;
        private TextBox startingBalanceTextBox;
        private TextBox monthsTextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}