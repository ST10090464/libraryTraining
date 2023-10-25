namespace LibraryTrainingSystems
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            FindingCallNumbersNav = new Button();
            IdentifyingAreasNav = new Button();
            ReplacingBooksNav = new Button();
            LibraryBooksNav = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FindingCallNumbersNav);
            groupBox1.Controls.Add(IdentifyingAreasNav);
            groupBox1.Controls.Add(ReplacingBooksNav);
            groupBox1.Controls.Add(LibraryBooksNav);
            groupBox1.Location = new Point(185, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Page Options";
            // 
            // FindingCallNumbersNav
            // 
            FindingCallNumbersNav.Cursor = Cursors.Hand;
            FindingCallNumbersNav.Enabled = false;
            FindingCallNumbersNav.Location = new Point(127, 125);
            FindingCallNumbersNav.Name = "FindingCallNumbersNav";
            FindingCallNumbersNav.Size = new Size(136, 23);
            FindingCallNumbersNav.TabIndex = 3;
            FindingCallNumbersNav.Text = "Finding Call Numbers";
            FindingCallNumbersNav.UseVisualStyleBackColor = true;
            // 
            // IdentifyingAreasNav
            // 
            IdentifyingAreasNav.Cursor = Cursors.Hand;
            IdentifyingAreasNav.Location = new Point(127, 96);
            IdentifyingAreasNav.Name = "IdentifyingAreasNav";
            IdentifyingAreasNav.Size = new Size(136, 23);
            IdentifyingAreasNav.TabIndex = 2;
            IdentifyingAreasNav.Text = "Identifying Areas";
            IdentifyingAreasNav.UseVisualStyleBackColor = true;
            IdentifyingAreasNav.Click += IdentifyingAreasNav_Click;
            // 
            // ReplacingBooksNav
            // 
            ReplacingBooksNav.Cursor = Cursors.Hand;
            ReplacingBooksNav.Location = new Point(127, 67);
            ReplacingBooksNav.Name = "ReplacingBooksNav";
            ReplacingBooksNav.Size = new Size(136, 23);
            ReplacingBooksNav.TabIndex = 1;
            ReplacingBooksNav.Text = "Replacing Books";
            ReplacingBooksNav.UseVisualStyleBackColor = true;
            ReplacingBooksNav.Click += button2_Click;
            // 
            // LibraryBooksNav
            // 
            LibraryBooksNav.Cursor = Cursors.Hand;
            LibraryBooksNav.Location = new Point(127, 38);
            LibraryBooksNav.Name = "LibraryBooksNav";
            LibraryBooksNav.Size = new Size(136, 23);
            LibraryBooksNav.TabIndex = 0;
            LibraryBooksNav.Text = "Library Books";
            LibraryBooksNav.UseVisualStyleBackColor = true;
            LibraryBooksNav.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Library Training Systems";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 24);
            label2.Name = "label2";
            label2.Size = new Size(696, 15);
            label2.TabIndex = 2;
            label2.Text = "Welcome to the Library Training Systems where you will use fun ways to learn how everything is organised everything in the library.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 53);
            label3.Name = "label3";
            label3.Size = new Size(694, 15);
            label3.TabIndex = 3;
            label3.Text = "You can click the \"Replacing Books\" button which will take you to a page where you will identify which broad area a book belongs ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 39);
            label4.Name = "label4";
            label4.Size = new Size(681, 15);
            label4.TabIndex = 4;
            label4.Text = "You can click the \"Library Books\" button which will take you to a page where you will see all the books that belong to the library.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 54);
            label5.Name = "label5";
            label5.Size = new Size(687, 15);
            label5.TabIndex = 5;
            label5.Text = "You can click the \"Identifying Areas\" button which will take you to a page where you will Find the call number for a specific topic.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 69);
            label6.Name = "label6";
            label6.Size = new Size(760, 15);
            label6.TabIndex = 6;
            label6.Text = "You can click the \"Finding Call Numbers\" button which will take you to a page where you will Correctly replace a book in its position on a shelf.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 99);
            label7.Name = "label7";
            label7.Size = new Size(606, 15);
            label7.TabIndex = 7;
            label7.Text = "If one or more buttons are disabled then do not worry as the Head Librarian will unlock them when he chooses to.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 84);
            label8.Name = "label8";
            label8.Size = new Size(791, 15);
            label8.TabIndex = 8;
            label8.Text = "You can click the \"Identifying Areas\" button which will take you to a page where you will Match the  columns of Call Numbers and their Descriptions.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "HomePage";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button FindingCallNumbersNav;
        private Button IdentifyingAreasNav;
        private Button ReplacingBooksNav;
        private Button LibraryBooksNav;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}