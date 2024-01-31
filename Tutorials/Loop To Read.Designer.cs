namespace CS161_Practice5.Tutorials
{
    partial class Loop_To_Read
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
            friendsLIstBox = new ListBox();
            getFriendsButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(friendsLIstBox);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Friends List";
            // 
            // friendsLIstBox
            // 
            friendsLIstBox.BackColor = SystemColors.ControlLight;
            friendsLIstBox.FormattingEnabled = true;
            friendsLIstBox.ItemHeight = 15;
            friendsLIstBox.Location = new Point(11, 23);
            friendsLIstBox.Name = "friendsLIstBox";
            friendsLIstBox.Size = new Size(352, 184);
            friendsLIstBox.TabIndex = 0;
            // 
            // getFriendsButton
            // 
            getFriendsButton.Location = new Point(23, 252);
            getFriendsButton.Name = "getFriendsButton";
            getFriendsButton.Size = new Size(126, 35);
            getFriendsButton.TabIndex = 1;
            getFriendsButton.Text = "Get Friends";
            getFriendsButton.UseVisualStyleBackColor = true;
            getFriendsButton.Click += getFriendsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(249, 252);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 35);
            exitButton.TabIndex = 2;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Loop_To_Read
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 304);
            Controls.Add(exitButton);
            Controls.Add(getFriendsButton);
            Controls.Add(groupBox1);
            Name = "Loop_To_Read";
            Text = "Loop_To_Read";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox friendsLIstBox;
        private Button getFriendsButton;
        private Button exitButton;
    }
}