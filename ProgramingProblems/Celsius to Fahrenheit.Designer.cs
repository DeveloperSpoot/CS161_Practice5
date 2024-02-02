namespace CS161_Practice5.ProgramingProblems
{
    partial class Celsius_to_Fahrenheit
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
            this.tempsListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tempsListBox
            // 
            this.tempsListBox.FormattingEnabled = true;
            this.tempsListBox.ItemHeight = 19;
            this.tempsListBox.Location = new System.Drawing.Point(12, 13);
            this.tempsListBox.Name = "tempsListBox";
            this.tempsListBox.Size = new System.Drawing.Size(311, 308);
            this.tempsListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(12, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(311, 26);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Celsius_to_Fahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 372);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tempsListBox);
            this.Name = "Celsius_to_Fahrenheit";
            this.Text = "Celsius_to_Fahrenheit";
            this.Load += new System.EventHandler(this.Celsius_to_Fahrenheit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox tempsListBox;
        private Button exitButton;
    }
}