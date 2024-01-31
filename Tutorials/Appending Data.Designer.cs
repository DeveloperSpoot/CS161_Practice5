namespace CS161_Practice5.Tutorials
{
    partial class Appending_Data
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
            writeButton = new Button();
            friendsNameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(204, 54);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(37, 54);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(122, 23);
            writeButton.TabIndex = 6;
            writeButton.Text = "Write Name";
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // friendsNameTextBox
            // 
            friendsNameTextBox.Location = new Point(141, 12);
            friendsNameTextBox.Name = "friendsNameTextBox";
            friendsNameTextBox.Size = new Size(204, 23);
            friendsNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter a friend's name:";
            // 
            // Appending_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 94);
            Controls.Add(exitButton);
            Controls.Add(writeButton);
            Controls.Add(friendsNameTextBox);
            Controls.Add(label1);
            Name = "Appending_Data";
            Text = "Appending_Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button writeButton;
        private TextBox friendsNameTextBox;
        private Label label1;
    }
}