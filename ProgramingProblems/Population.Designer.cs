namespace CS161_Practice5.ProgramingProblems
{
    partial class Population
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
            this.exitButton = new System.Windows.Forms.Button();
            this.populationListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(12, 333);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(311, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // populationListBox
            // 
            this.populationListBox.FormattingEnabled = true;
            this.populationListBox.ItemHeight = 19;
            this.populationListBox.Location = new System.Drawing.Point(12, 12);
            this.populationListBox.Name = "populationListBox";
            this.populationListBox.Size = new System.Drawing.Size(311, 308);
            this.populationListBox.TabIndex = 2;
            // 
            // Population
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.populationListBox);
            this.Name = "Population";
            this.Text = "Population";
            this.Load += new System.EventHandler(this.Population_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private ListBox populationListBox;
    }
}