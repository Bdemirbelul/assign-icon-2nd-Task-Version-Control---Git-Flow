namespace ParkingManagmentSystem
{
    public partial class LogIn : Form
    {

        public static LogIn instance;
        public int password = 0;

        public LogIn()
        {
            InitializeComponent();
            instance = this;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "demir")
            {
                if(textBox2.Text == "12345")
                {
                    var Form2 = new Form2();
                    Form2.Show();
                    this.Hide();
                }
           
            }
            else if (textBox1.Text != "admin")
            {
                password++;
                if (textBox2.Text != "12345")
                {
                    MessageBox.Show("Please enter your username and password correctly ", "ByDemir", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                }


            }
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "12345")
                {
                    var Form3 = new Form3();
                    Form3.Show();
                    this.Hide();
                }
            }

            if (password == 3)
            {
                MessageBox.Show("You have entered an incorrect password more than once, the system is shutting down", "ByDemir", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}