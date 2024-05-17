using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ParkingManagmentSystem
{
    public partial class Form7 : Form
    {
        string connectionString = "Data Source=DESKTOP-KIH1OI6;Initial Catalog=ParkingManagmentSystem;Integrated Security=True";

        public Form7()
        {
                InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "insert into park (space_id, space_name, park_status, vehicle_type, vehicle_plate, check_in, check_out) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "') ;"; 
            SqlConnection condb = new SqlConnection(connectionString);
            SqlCommand cmddatabase = new SqlCommand(Query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("Data has been saved successfully", "Information", MessageBoxButtons.OK);
                while (myreader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                textBox8.Visible = true;
                label8.Visible = true;
                if (textBox8.Text != "")
                {
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from park where space_id='" + textBox8.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    MessageBox.Show("Record deleted successfully");
                    textBox8.Visible = false;
                    label8.Visible = false;
                }
                else
                {
                    // If textBox8 is empty, do nothing
                }


            }

                
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
