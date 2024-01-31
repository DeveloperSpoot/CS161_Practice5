namespace CS161_Practice5.Tutorials
{
    partial class writingData
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
            friendsNameTextBox = new TextBox();
            writeButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a friend's name:";
            // 
            // friendsNameTextBox
            // 
            friendsNameTextBox.Location = new Point(137, 12);
            friendsNameTextBox.Name = "friendsNameTextBox";
            friendsNameTextBox.Size = new Size(204, 23);
            friendsNameTextBox.TabIndex = 1;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(33, 54);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(122, 23);
            writeButton.TabIndex = 2;
            writeButton.Text = "Write Name";
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(200, 54);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // writingData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 97);
            Controls.Add(exitButton);
            Controls.Add(writeButton);
            Controls.Add(friendsNameTextBox);
            Controls.Add(label1);
            Name = "writingData";
            Text = "writingData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox friendsNameTextBox;
        private Button writeButton;
        private Button exitButton;
    }
}