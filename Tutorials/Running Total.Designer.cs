namespace CS161_Practice5.Tutorials
{
    partial class Running_Total
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
            totalSalesLabel = new Label();
            readCalculateButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(totalSalesLabel);
            groupBox1.Location = new Point(11, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Sales";
            // 
            // totalSalesLabel
            // 
            totalSalesLabel.BackColor = SystemColors.ControlLight;
            totalSalesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalSalesLabel.Location = new Point(13, 25);
            totalSalesLabel.Name = "totalSalesLabel";
            totalSalesLabel.Size = new Size(288, 37);
            totalSalesLabel.TabIndex = 0;
            totalSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // readCalculateButton
            // 
            readCalculateButton.Location = new Point(24, 112);
            readCalculateButton.Name = "readCalculateButton";
            readCalculateButton.Size = new Size(127, 31);
            readCalculateButton.TabIndex = 1;
            readCalculateButton.Text = "Read and Calculate";
            readCalculateButton.UseVisualStyleBackColor = true;
            readCalculateButton.Click += readCalculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(185, 112);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(127, 31);
            exitButton.TabIndex = 2;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Running_Total
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 164);
            Controls.Add(exitButton);
            Controls.Add(readCalculateButton);
            Controls.Add(groupBox1);
            Name = "Running_Total";
            Text = "Running_Total";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label totalSalesLabel;
        private Button readCalculateButton;
        private Button exitButton;
    }
}