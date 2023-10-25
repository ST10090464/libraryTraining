namespace LibraryTrainingSystems
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBooks lb1 = new LibraryBooks();
            lb1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplacingBooks rb1 = new ReplacingBooks();
            rb1.Show();
            this.Hide();
        }

        //Identifying Areas button
        private void IdentifyingAreasNav_Click(object sender, EventArgs e)
        {
            IdentifyingAreasPage iap = new IdentifyingAreasPage();
            iap.Show();
            this.Hide();
        }
    }
}