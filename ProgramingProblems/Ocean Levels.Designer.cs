namespace CS161_Practice5.ProgramingProblems
{
    partial class Ocean_Levels
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
            this.yearsLevelsListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearsLevelsListBox
            // 
            this.yearsLevelsListBox.FormattingEnabled = true;
            this.yearsLevelsListBox.ItemHeight = 19;
            this.yearsLevelsListBox.Location = new System.Drawing.Point(8, 9);
            this.yearsLevelsListBox.Name = "yearsLevelsListBox";
            this.yearsLevelsListBox.Size = new System.Drawing.Size(309, 213);
            this.yearsLevelsListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ocean_Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearsLevelsListBox);
            this.Name = "Ocean_Levels";
            this.Text = "Ocean_Levels";
            this.Load += new System.EventHandler(this.Ocean_Levels_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox yearsLevelsListBox;
        private Button button1;
    }
}