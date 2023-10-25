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
    public partial class Rewards2 : Form
    {
        public Rewards2()
        {
            InitializeComponent();
        }

        //Back Button
        private void Back_Click(object sender, EventArgs e)
        {
            IdentifyingAreasPage iap = new IdentifyingAreasPage();
            iap.Show();
            this.Hide();
        }

        //Instructions Button
        private void Instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi User!\r\nThis Rewards Page contains three Buttons." +
                           "\r\nThe instructions button will open this message that you are currently reading." +
                           "\r\nThe Home button will take you to the Home page." +
                           "\r\nThe Back button will take you to the Replacing Books page." +
                           "\r\n\r\nThe Rewards section shows you the rewards that you can achieve when you play this game.", "Messages");
        }

        //Home Button
        private void Home_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }
    }
}
