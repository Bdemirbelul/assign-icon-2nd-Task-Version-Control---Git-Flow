using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ParkingManagmentSystem
{
    public partial class Form3 : Form
    {
        string connectionString = "Data Source=DESKTOP-KIH1OI6;Initial Catalog=ParkingManagmentSystem;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateProgressBar()
        {
            // Assuming labelValue is your label's name and progressBar1 is your progress bar's name
            if (int.TryParse(label6.Text, out int value))
            {
                // Ensure the value is within the progress bar's range
                value = Math.Max(progressBar1.Minimum, Math.Min(progressBar1.Maximum, value));
                progressBar1.Value = value;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UpdateProgressBar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            label6.Text = "10";
            label7.Text = "17";
            label8.Text = "3";
            label9.Text = "1";
            label11.Text = "0";
            UpdateProgressBar();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            label6.Text = "26";
            label7.Text = "18";
            label8.Text = "8";
            label9.Text = "13";
            label11.Text = "2";
            UpdateProgressBar();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label6.Text = "18";
            label7.Text = "35";
            label8.Text = "11";
            label9.Text = "14";
            label11.Text = "2";
            UpdateProgressBar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open(); 

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT *  FROM park", sqlcon);

                DataTable dtbl = new DataTable(); 

                sqlda.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }
    }
}
