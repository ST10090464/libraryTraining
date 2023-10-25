namespace LibraryTrainingSystems
{


    partial class ReplacingBooks
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            UserCallNumbersListBox = new ListBox();
            CallNumbersListBox = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 266);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations Buttons";
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(20, 80);
            button5.Name = "button5";
            button5.Size = new Size(110, 23);
            button5.TabIndex = 4;
            button5.Text = "New Game";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(20, 138);
            button4.Name = "button4";
            button4.Size = new Size(110, 23);
            button4.TabIndex = 3;
            button4.Text = "Rewards";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(20, 109);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 2;
            button3.Text = "Submit Answers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(20, 51);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 1;
            button2.Text = "Instructions ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(20, 22);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UserCallNumbersListBox);
            groupBox2.Controls.Add(CallNumbersListBox);
            groupBox2.Location = new Point(263, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Replacing Books Game";
            // 
            // UserCallNumbersListBox
            // 
            UserCallNumbersListBox.AllowDrop = true;
            UserCallNumbersListBox.Cursor = Cursors.Hand;
            UserCallNumbersListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserCallNumbersListBox.FormattingEnabled = true;
            UserCallNumbersListBox.ItemHeight = 21;
            UserCallNumbersListBox.Location = new Point(250, 19);
            UserCallNumbersListBox.Name = "UserCallNumbersListBox";
            UserCallNumbersListBox.Size = new Size(237, 214);
            UserCallNumbersListBox.TabIndex = 2;
            UserCallNumbersListBox.SelectedIndexChanged += UserCallNumbersListBox_SelectedIndexChanged;
            // 
            // CallNumbersListBox
            // 
            CallNumbersListBox.AllowDrop = true;
            CallNumbersListBox.Cursor = Cursors.Hand;
            CallNumbersListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CallNumbersListBox.FormattingEnabled = true;
            CallNumbersListBox.ItemHeight = 21;
            CallNumbersListBox.Location = new Point(6, 19);
            CallNumbersListBox.Name = "CallNumbersListBox";
            CallNumbersListBox.Size = new Size(193, 214);
            CallNumbersListBox.TabIndex = 0;
            // 
            // ReplacingBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReplacingBooks";
            Text = "ReplacingBooks";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private ListBox CallNumbersListBox;
        private ListBox UserCallNumbersListBox;
    }
}