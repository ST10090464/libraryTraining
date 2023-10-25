using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryTrainingSystems
{
    public partial class ReplacingBooks : Form
    {
        private List<string> generatedCallNumbers;
        private List<string> userAchievements; // Track user's achievements

        // Sorting algorithm: Bubble sort
        private bool IsSorted(List<string> callNumbers)
        {
            bool sorted = true;

            for (int i = 0; i < callNumbers.Count - 1; i++)
            {
                // Compare adjacent call numbers
                if (string.Compare(callNumbers[i], callNumbers[i + 1]) > 0)
                {
                    sorted = false;
                    break;
                }
            }

            return sorted;
        }

        public ReplacingBooks()
        {
            InitializeComponent();
            generatedCallNumbers = new List<string>();
            userAchievements = new List<string>(); // Initialize user's achievements

            // Attach click events for listboxes
            CallNumbersListBox.Click += CallNumbersListBox_Click;
            UserCallNumbersListBox.Click += UserCallNumbersListBox_Click;
        }

        //Home button
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        //Instructions Button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi User! \r\nWelcome to the Replacing Books Game Page. " +
                "This page has five buttons:\r\nThe Home Button will take you back to the Home Page." +
                "\r\nThe Instructions BUtton opens up this message box that you are reading." +
                "\r\nThe New Game Button will generate random call numbers in the first list box. " +
                "\r\nThe Submit Answers Button must be pressed when you want to submit your answers." +
                "\r\nThe Rewards Button will take you to the Rewards page where you will see all the available rewards." +
                "\r\n\r\nFor the Game:\r\nPlease press the New Game button to generate call numbers on the list box. " +
                "\r\nClick the smallest to largest callnumbers to make them appear on the second list box in order." +
                "\r\nIf you made a mistake with the sorting then you can click the callnumber on the right hand side and it will go back to the first ListBox." +
                "\r\nPress Submit Answers once you completed it.\r\n", "Messages");
        }

        // Submit Answers button
        private void button3_Click(object sender, EventArgs e)
        {
            // Get the user's sorted call numbers from UserCallNumbersListBox
            List<string> sortedCallNumbers = new List<string>();
            foreach (var item in UserCallNumbersListBox.Items)
            {
                sortedCallNumbers.Add(item.ToString());
            }

            // Check if the user's sorted call numbers are in ascending order
            bool isCorrect = false;
            if (sortedCallNumbers.Count == 10)
            {
                isCorrect = IsSorted(sortedCallNumbers);
            }
            else
            {
                MessageBox.Show("Please enter all 10 call numbers", "Error");
            }
            if (isCorrect)
            {
                MessageBox.Show("Congratulations! You sorted the call numbers correctly.", "Correct Sorting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Implement achievements here
                CheckAchievements(sortedCallNumbers.Count); // You can pass any relevant data

                // Give the user points or perform other actions
            }
            else
            {
                MessageBox.Show("Sorry, your sorting order is incorrect. Please try again.", "Incorrect Sorting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Implement achievements here
                CheckAchievements(sortedCallNumbers.Count); // You can pass any relevant data

                // Give the user points or perform other actions
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RewardsPage1 rp1 = new RewardsPage1();
            rp1.Show();
            this.Hide();
        }

        // New Game Button
        private void button5_Click(object sender, EventArgs e)
        {
            // Generate 10 different call numbers 
            generatedCallNumbers = GenerateCallNumbers(10);

            // Display the generated call numbers in the ListBox
            CallNumbersListBox.Items.Clear();
            CallNumbersListBox.Items.AddRange(generatedCallNumbers.ToArray());
        }

        // Click event for CallNumbersListBox
        private void CallNumbersListBox_Click(object sender, EventArgs e)
        {
            if (CallNumbersListBox.SelectedItem != null)
            {
                string selectedItem = CallNumbersListBox.SelectedItem.ToString();
                CallNumbersListBox.Items.Remove(selectedItem);
                UserCallNumbersListBox.Items.Add(selectedItem); // Add the item to the second listbox
            }
        }

        // Click event for UserCallNumbersListBox (to move items back to the first listbox)
        private void UserCallNumbersListBox_Click(object sender, EventArgs e)
        {
            if (UserCallNumbersListBox.SelectedItem != null)
            {
                string selectedItem = UserCallNumbersListBox.SelectedItem.ToString();
                UserCallNumbersListBox.Items.Remove(selectedItem);
                CallNumbersListBox.Items.Add(selectedItem); // Move the item back to the first listbox
            }
        }

        private void CheckAchievements(int sortedCallNumbersCount)
        {
            // Check for achievements based on the number of sorted call numbers
            if (sortedCallNumbersCount == 8)
            {
                UnlockAchievement("8/10, You're a Sorting Pro");
            }
            if (sortedCallNumbersCount == 9)
            {
                UnlockAchievement("9/10, You're a Sorting Master");
            }
            if (sortedCallNumbersCount == 5)
            {
                UnlockAchievement("5/10, You must Train Harder");
            }
            if (sortedCallNumbersCount == 7)
            {
                UnlockAchievement("7/10, You are the Beast");
            }
            if (sortedCallNumbersCount == 6)
            {
                UnlockAchievement("6/10, You are Above Average");
            }
            if (sortedCallNumbersCount == 10)
            {
                UnlockAchievement("Perfect Score! You are The Man, The Myth, The legend");
            }
           
        }

        private void UnlockAchievement(string achievementName)
        {
            // You can manage the user's earned achievements here
            // For simplicity, you can store them in a list or display them in a UI element
            // For example:
            userAchievements.Add(achievementName);

            // Display a message or provide feedback to the user
            MessageBox.Show($"Achievement Unlocked: {achievementName}", "Achievement Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<string> GenerateCallNumbers(int count)
        {
            List<string> callNumbers = new List<string>();

            // Generate random call numbers
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                string topic = random.Next(0, 1000).ToString("D3"); // Generate a random 3-digit topic number
                string author = GenerateRandomAuthor();
                string callNumber = $"{topic}.{author}";
                callNumbers.Add(callNumber);
            }

            return callNumbers;
        }

        private string GenerateRandomAuthor()
        {
            // Generate random author name (3 random uppercase letters)
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void UserCallNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UserCallNumbersListBox.AllowDrop = true;
        }
    }
}




//https://www.codeproject.com/Articles/2006/Drag-and-Drop-between-list-boxes-Beginner-s-Tutori
//https://hackernoon.com/how-to-optimize-react-native-map-in-your-application-eeo3nib 