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
    public partial class RewardsPage1 : Form
    {
        public RewardsPage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplacingBooks rb1 = new ReplacingBooks();
            rb1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi User!\r\nThis Rewards Page contains three Buttons." +
                            "\r\nThe instructions button will open this message that you are currently reading." +
                            "\r\nThe Home button will take you to the Home page." +
                            "\r\nThe Back button will take you to the Replacing Books page." +
                            "\r\n\r\nThe Rewards section shows you the rewards that you can achieve when you play this game.", "Messages");
        }
    }
}
