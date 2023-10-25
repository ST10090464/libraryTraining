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
    public partial class LibraryBooks : Form
    {
        public LibraryBooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi There!\nOn this page, you can click on the drop down option under the topics to see:\nThe Book Call Numbers, The Book Titles and the Authors.\nYou can click the Home button to go back to the home page.", "Messages");


        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            InitializeComponent();

            // Create an array of items to populate the ComboBox
            string[] items = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };

            // Assign the items to the ComboBox
            comboBox1.Items.AddRange(items);



            // Handle the SelectedIndexChanged event if needed
            // This event is triggered when the user selects an item from the ComboBox
            string selectedValue = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Selected Item: " + selectedValue);

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
