namespace LibraryTrainingSystems
{
    partial class IdentifyingAreasPage
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
            Rewards = new Button();
            Submit = new Button();
            NewGame = new Button();
            Home = new Button();
            Instructions = new Button();
            MatchTheColumnGame = new GroupBox();
            rightPanel = new Panel();
            leftPanel = new Panel();
            groupBox1.SuspendLayout();
            MatchTheColumnGame.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rewards);
            groupBox1.Controls.Add(Submit);
            groupBox1.Controls.Add(NewGame);
            groupBox1.Controls.Add(Home);
            groupBox1.Controls.Add(Instructions);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(125, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation";
            // 
            // Rewards
            // 
            Rewards.Location = new Point(25, 147);
            Rewards.Name = "Rewards";
            Rewards.Size = new Size(75, 23);
            Rewards.TabIndex = 4;
            Rewards.Text = "Rewards";
            Rewards.UseVisualStyleBackColor = true;
            Rewards.Click += Rewards_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(25, 118);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 3;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // NewGame
            // 
            NewGame.Location = new Point(25, 89);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(75, 23);
            NewGame.TabIndex = 2;
            NewGame.Text = "New Game";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Click += NewGame_Click;
            // 
            // Home
            // 
            Home.Location = new Point(25, 31);
            Home.Name = "Home";
            Home.Size = new Size(75, 23);
            Home.TabIndex = 1;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Instructions
            // 
            Instructions.Location = new Point(25, 60);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(75, 23);
            Instructions.TabIndex = 0;
            Instructions.Text = "Instructions";
            Instructions.UseVisualStyleBackColor = true;
            Instructions.Click += Instructions_Click;
            // 
            // MatchTheColumnGame
            // 
            MatchTheColumnGame.Controls.Add(rightPanel);
            MatchTheColumnGame.Controls.Add(leftPanel);
            MatchTheColumnGame.Location = new Point(158, 12);
            MatchTheColumnGame.Name = "MatchTheColumnGame";
            MatchTheColumnGame.Size = new Size(1124, 426);
            MatchTheColumnGame.TabIndex = 1;
            MatchTheColumnGame.TabStop = false;
            MatchTheColumnGame.Text = "Match The Column Game";
            // 
            // rightPanel
            // 
            rightPanel.BackColor = SystemColors.ActiveCaption;
            rightPanel.Location = new Point(557, 31);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(561, 391);
            rightPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = SystemColors.Highlight;
            leftPanel.Cursor = Cursors.Hand;
            leftPanel.Location = new Point(6, 31);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(534, 389);
            leftPanel.TabIndex = 0;
            // 
            // IdentifyingAreasPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 450);
            Controls.Add(MatchTheColumnGame);
            Controls.Add(groupBox1);
            Name = "IdentifyingAreasPage";
            Text = "IdentifyingAreasPage";
            groupBox1.ResumeLayout(false);
            MatchTheColumnGame.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Submit;
        private Button NewGame;
        private Button Home;
        private Button Instructions;
        private GroupBox MatchTheColumnGame;
        private Button Rewards;
        private Panel rightPanel;
        private Panel leftPanel;
    }
}