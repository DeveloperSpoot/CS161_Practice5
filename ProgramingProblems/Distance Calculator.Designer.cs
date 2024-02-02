namespace CS161_Practice5.ProgramingProblems
{
    partial class Distance_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mphTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.hoursMphListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Speed in MPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Traveled:";
            // 
            // mphTextBox
            // 
            this.mphTextBox.Location = new System.Drawing.Point(163, 6);
            this.mphTextBox.Name = "mphTextBox";
            this.mphTextBox.Size = new System.Drawing.Size(100, 26);
            this.mphTextBox.TabIndex = 2;
            this.mphTextBox.TextChanged += new System.EventHandler(this.onInput);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(163, 46);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 26);
            this.hoursTextBox.TabIndex = 3;
            this.hoursTextBox.TextChanged += new System.EventHandler(this.onInput);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(12, 279);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(251, 29);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hoursMphListbox
            // 
            this.hoursMphListbox.FormattingEnabled = true;
            this.hoursMphListbox.ItemHeight = 19;
            this.hoursMphListbox.Location = new System.Drawing.Point(12, 94);
            this.hoursMphListbox.Name = "hoursMphListbox";
            this.hoursMphListbox.Size = new System.Drawing.Size(251, 175);
            this.hoursMphListbox.TabIndex = 5;
            // 
            // Distance_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 319);
            this.Controls.Add(this.hoursMphListbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.mphTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Distance_Calculator";
            this.Text = "Distance_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox mphTextBox;
        private TextBox hoursTextBox;
        private Button exitButton;
        private ListBox hoursMphListbox;
    }
}