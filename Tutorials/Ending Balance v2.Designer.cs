namespace CS161_Practice5.Tutorials
{
    partial class Ending_Balance_v2
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
            exitButton = new Button();
            clearButton = new Button();
            calculateButton = new Button();
            monthsTextBox = new TextBox();
            startingBalanceTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            endingBalanceListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(246, 308);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(133, 308);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(20, 308);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 13;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // monthsTextBox
            // 
            monthsTextBox.Location = new Point(133, 50);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(203, 23);
            monthsTextBox.TabIndex = 12;
            // 
            // startingBalanceTextBox
            // 
            startingBalanceTextBox.Location = new Point(133, 18);
            startingBalanceTextBox.Name = "startingBalanceTextBox";
            startingBalanceTextBox.Size = new Size(203, 23);
            startingBalanceTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endingBalanceListBox);
            groupBox1.Location = new Point(15, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 201);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ending Balance:";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 9;
            label2.Text = "Number of Months:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 8;
            label1.Text = "Starting Balance:";
            // 
            // endingBalanceListBox
            // 
            endingBalanceListBox.BackColor = SystemColors.ControlLight;
            endingBalanceListBox.FormattingEnabled = true;
            endingBalanceListBox.ItemHeight = 15;
            endingBalanceListBox.Location = new Point(12, 23);
            endingBalanceListBox.Name = "endingBalanceListBox";
            endingBalanceListBox.Size = new Size(300, 169);
            endingBalanceListBox.TabIndex = 0;
            // 
            // Ending_Balance_v2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 343);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(monthsTextBox);
            Controls.Add(startingBalanceTextBox);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ending_Balance_v2";
            Text = "Ending_Balance_v2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button clearButton;
        private Button calculateButton;
        private TextBox monthsTextBox;
        private TextBox startingBalanceTextBox;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ListBox endingBalanceListBox;
    }
}