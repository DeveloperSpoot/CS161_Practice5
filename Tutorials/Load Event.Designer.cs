namespace CS161_Practice5.Tutorials
{
    partial class Load_Event
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
            groupBox1 = new GroupBox();
            friendsLIstBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(24, 253);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(352, 35);
            exitButton.TabIndex = 5;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(friendsLIstBox);
            groupBox1.Location = new Point(13, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 221);
            groupBox1.TabIndex = 3;
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
            // Load_Event
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 304);
            Controls.Add(exitButton);
            Controls.Add(groupBox1);
            Name = "Load_Event";
            Text = "Load_Event";
            Load += Load_Event_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private GroupBox groupBox1;
        private ListBox friendsLIstBox;
    }
}