namespace CS161_Practice5.ProgramingProblems
{
    partial class Tuition_Increase
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
            this.yearsTuitionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(13, 235);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(308, 31);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // yearsTuitionListBox
            // 
            this.yearsTuitionListBox.FormattingEnabled = true;
            this.yearsTuitionListBox.ItemHeight = 19;
            this.yearsTuitionListBox.Location = new System.Drawing.Point(12, 12);
            this.yearsTuitionListBox.Name = "yearsTuitionListBox";
            this.yearsTuitionListBox.Size = new System.Drawing.Size(309, 213);
            this.yearsTuitionListBox.TabIndex = 2;
            // 
            // Tuition_Increase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 277);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.yearsTuitionListBox);
            this.Name = "Tuition_Increase";
            this.Text = "Tuition_Increase";
            this.Load += new System.EventHandler(this.Tuition_Increase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private ListBox yearsTuitionListBox;
    }
}