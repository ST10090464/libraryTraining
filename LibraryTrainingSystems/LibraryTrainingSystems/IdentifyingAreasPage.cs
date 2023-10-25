using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrainingSystems
{
    public partial class IdentifyingAreasPage : Form
    {
        DataClass dataClass = DataClass.getObject();
        Random ran = new Random();
        bool checkPanel = true;

        //Left and right Panels
        private List<Label> selectedLeftLabels = new List<Label>();
        private List<Label> selectedRightLabels = new List<Label>();

        public IdentifyingAreasPage()
        {
            InitializeComponent();
        }
        private void DefinitionLabel_Click(object sender, EventArgs e)
        {
            // Handle the click event for the definition labels here
            // Add your custom logic
        }

        // Home Button
        private void Home_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }
      
        /// <summary>
        /// //Instructions button brings up a message box that explains how to use the whole Identifying Areas Page and play the match the Column game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi User! \r\nWelcome to the Identifying Areas Game Page. " +
                "This page has five buttons:\r\nThe Home Button will take you back to the Home Page." +
                "\r\nThe Instructions Button opens up this message box that you are reading." +
                "\r\nThe New Game Button will generate random call numbers in the first dark blue column and the second column will generate descriptions and it will alternate everytime you press it. " +
                "\r\nThe Submit Answers Button must be pressed when you want to submit your answers." +
                "\r\nThe Rewards Button will take you to the Rewards page where you will see all the available rewards." +
                "\r\n\r\nFor the Game:\r\nPlease press the New Game button to generate call numbers/Descriptions on the left Panel. " +
                "\r\nClick the callnumber/description on the left and click the callnumber/description to match them." +
                "\r\nIf you made a mistake with the matching then you can click the call number/description and it will be unselected." +
                "\r\nPress Submit Answers once you completed it.\r\n", "Messages");
        }

        // Rewards button
        private void Rewards_Click(object sender, EventArgs e)
        {
            Rewards2 rw2 = new Rewards2();
            rw2.Show();
            this.Hide();
        }
        public void SwapLeft()
        {

            Dictionary<string, string> shuffledDict = dataClass.LibraryTraining();
            List<string> listKeys = shuffledDict.Keys.ToList();
            List<string> listValues = shuffledDict.Values.ToList();
            listValues.OrderBy(x => ran.Next());

            bool switchPanels = false;



            int labelY1 = 0; // Initialize the Y coordinate for the first label
            int labelY2 = 0; // Initialize the Y coordinate for the first label


            foreach (string c in listKeys.OrderBy(r => ran.Next()).Take(4))
            {
                Label callLabelLeft = new Label
                {
                    Text = c,
                    Cursor = Cursors.Hand,
                    BackColor = Color.White,
                    Font = new Font("Arial", 11),
                    Width = 534,
                    Height = 30,
                    Margin = new Padding(10),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                callLabelLeft.Location = new Point(0, labelY1);

                callLabelLeft.Click += LeftLabel_Click;
                leftPanel.Controls.Add(callLabelLeft);
                labelY1 += callLabelLeft.Height + 10; // You can adjust the spacing as needed

            }

            foreach (string c in listValues.OrderBy(r => ran.Next()).Take(7))
            {
                Label callLabelRight = new Label
                {
                    Text = c,
                    Cursor = Cursors.Hand,
                    BackColor = Color.White,
                    Font = new Font("Arial", 11),
                    Width = 534,
                    Height = 30,
                    Margin = new Padding(50),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                callLabelRight.Location = new Point(0, labelY2);
                callLabelRight.Click += RightLabel_Click;
                rightPanel.Controls.Add(callLabelRight);
                labelY2 += callLabelRight.Height + 10; // You can adjust the spacing as needed
            }

        }

        public void SwapRight()
        {

            Dictionary<string, string> shuffledDict = dataClass.LibraryTraining();
            List<string> listKeys = shuffledDict.Keys.ToList();
            List<string> listValues = shuffledDict.Values.ToList();
            listValues.OrderBy(x => ran.Next());

            bool switchPanels = false;



            int labelY1 = 0; // Initialize the Y coordinate for the first label
            int labelY2 = 0; // Initialize the Y coordinate for the first label


            foreach (string c in listKeys.OrderBy(r => ran.Next()).Take(7))
            {
                Label callLabelRight = new Label
                {
                    Text = c,
                    Cursor = Cursors.Hand,
                    BackColor = Color.White,
                    Font = new Font("Arial", 11),
                    Width = 534,
                    Height = 30,
                    Margin = new Padding(10),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                callLabelRight.Location = new Point(0, labelY1);

                callLabelRight.Click += RightLabel_Click;
                rightPanel.Controls.Add(callLabelRight);
                labelY1 += callLabelRight.Height + 10; // You can adjust the spacing as needed

            }

            foreach (string c in listValues.OrderBy(r => ran.Next()).Take(4))
            {
                Label callLabelRight = new Label
                {
                    Text = c,
                    Cursor = Cursors.Hand,
                    BackColor = Color.White,
                    Font = new Font("Arial", 11),
                    Width = 534,
                    Height = 30,
                    Margin = new Padding(50),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                callLabelRight.Location = new Point(0, labelY2);
                callLabelRight.Click += LeftLabel_Click;
                leftPanel.Controls.Add(callLabelRight);
                labelY2 += callLabelRight.Height + 10; // You can adjust the spacing as needed
            }

        }
        /// <summary>
        /// //The New Game button generates the Left and Right Panel with Call Numbers and Descriptions. 
        /// Every Time its pressed the Call Numbers and Descriptions switch from the left to the right panel and vice versa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame_Click(object sender, EventArgs e)
        {
            leftPanel.Controls.Clear();
            rightPanel.Controls.Clear();

            if (checkPanel)
            {
                SwapLeft();
                checkPanel = false;
            }
            else
            {
                SwapRight();
                checkPanel = true;
            }

        }

        /// <summary>
        /// This LeftLabel method makes sure that the user can click on the items on the Left Panel and it will be selected
        /// Should the user click on it again then it will be unselected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftLabel_Click(object sender, EventArgs e)
        {
            var clickedLabel = (Label)sender;
            if (selectedLeftLabels.Contains(clickedLabel))
            {
                clickedLabel.BackColor = Color.White;
                selectedLeftLabels.Remove(clickedLabel);
            }
            else
            {
                clickedLabel.BackColor = Color.LightBlue;
                selectedLeftLabels.Add(clickedLabel);
            }
        }

        /// <summary>
        /// This RightLabel method makes sure that the user can click on the items on the right Panel and it will be selected
        /// Should the user click on it again then it will be unselected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightLabel_Click(object sender, EventArgs e)
        {
            var clickedLabel = (Label)sender;
            if (selectedRightLabels.Contains(clickedLabel))
            {
                clickedLabel.BackColor = Color.White;
                selectedRightLabels.Remove(clickedLabel);
            }
            else
            {
                clickedLabel.BackColor = Color.LightBlue;
                selectedRightLabels.Add(clickedLabel);
            }
        }

        /// <summary>
        /// This submit button takes the user inputs and checks to see what score the user got by calling a UserMatches method from the data class
        /// It will display an achievement the user unlocked depending on their score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            if (selectedLeftLabels.Count != selectedRightLabels.Count)
            {
                MessageBox.Show("Please make sure to match all left selections with right selections.");
                return;
            }
            Dictionary<string, string> userSelections = new Dictionary<string, string>();
            for (int i = 0; i < selectedLeftLabels.Count; i++)
            {
                userSelections.Add(selectedRightLabels[i].Text, selectedLeftLabels[i].Text);
            }

            int userMatches = dataClass.UserMatches(userSelections);
            MessageBox.Show($"You got {userMatches} out of 4 matches.");

            string achievementMessage = string.Empty;
            string imagePath = string.Empty;

            if (userMatches >= 2)
            {
                

                //Code to make the images show up for the achievements
                

                switch (userMatches)
                {
                    case 2:
                        achievementMessage = "You are a Joker";
                        imagePath = "C:\\Users\\lab_services_student\\Desktop\\LibraryTrainingSystems\\LibraryTrainingSystems\\LibraryTrainingSystems\\Images\\Joker.jfif";
                        break;
                    case 3:
                        achievementMessage = "Deadpool, you're good";
                        imagePath = "C:\\Users\\lab_services_student\\Desktop\\LibraryTrainingSystems\\LibraryTrainingSystems\\LibraryTrainingSystems\\Images\\Deadpool.jfif";
                        break;
                    case 4:
                        achievementMessage = "You are Thor, a god amongst men";
                        imagePath = "C:\\Users\\lab_services_student\\Desktop\\LibraryTrainingSystems\\LibraryTrainingSystems\\LibraryTrainingSystems\\Images\\Thor.jfif";
                        break;
                    default:
                        achievementMessage = "No achievement";
                        break;
                }

                // Display the achievement message box with the image
                ShowCustomMessageBox(achievementMessage, "Achievement", imagePath);
            }
            

            
            
            

            // Clear the selections after submission
            foreach (var label in selectedLeftLabels)
            {
                label.BackColor = Color.White;
            }
            foreach (var label in selectedRightLabels)
            {
                label.BackColor = Color.White;
            }
            selectedLeftLabels.Clear();
            selectedRightLabels.Clear();
        }

        //Code for the image to show in the Message box
        private void ShowCustomMessageBox(string message, string title, string imagePath)
        {
            Form messageBox = new Form();
            messageBox.Size = new Size(400, 200);
            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.Text = title;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Fill;

            Label label = new Label();
            label.Text = message;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Bottom;

            messageBox.Controls.Add(pictureBox);
            messageBox.Controls.Add(label);

            messageBox.ShowDialog();
        }
    }

}

