namespace LibraryTrainingSystems
{
    partial class Rewards2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rewards2));
            groupBox1 = new GroupBox();
            Back = new Button();
            Instructions = new Button();
            Home = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Back);
            groupBox1.Controls.Add(Instructions);
            groupBox1.Controls.Add(Home);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(129, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation";
            // 
            // Back
            // 
            Back.Location = new Point(6, 109);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Instructions
            // 
            Instructions.Location = new Point(6, 70);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(75, 23);
            Instructions.TabIndex = 7;
            Instructions.Text = "Instructions";
            Instructions.UseVisualStyleBackColor = true;
            Instructions.Click += Instructions_Click;
            // 
            // Home
            // 
            Home.Location = new Point(6, 29);
            Home.Name = "Home";
            Home.Size = new Size(75, 23);
            Home.TabIndex = 6;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(147, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Identifying Areas Game Rewards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 222);
            label3.Name = "label3";
            label3.Size = new Size(245, 15);
            label3.TabIndex = 5;
            label3.Text = "4/4 Perfect Score, You're a god amongst men";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 38);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 4;
            label2.Text = "3/4 Great!!! Precise like Deadpool ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "2/4 You are a Joker";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 240);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(629, 180);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(344, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(291, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Rewards2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Rewards2";
            Text = "Rewards2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button Back;
        private Button Instructions;
        private Button Home;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}