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
using MySql.Data.MySqlClient;


namespace ParkingManagmentSystem
{
    public partial class Form4 : Form
    {
        private Dictionary<string, int> itemValueMap;
        private Action<object, EventArgs> checkedListBox1_SelectedIndexChangedk;
        string connectionString = "Data Source=DESKTOP-KIH1OI6;Initial Catalog=ParkingManagmentSystem;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("3 Year");
            checkedListBox1.Items.Add("1 Year");
            checkedListBox1.Items.Add("6 Month");
            checkedListBox1.Items.Add("3 Month");
            checkedListBox1.Items.Add("1 Month");
            checkedListBox1.Items.Add("2 Week");
            checkedListBox1.Items.Add("1 Week");
            checkedListBox1.Items.Add("3 Day");
            itemValueMap = new Dictionary<string, int>
            {
                { "3 Year", 1355 },
                { "1 Year", 1120 },
                { "6 Month", 679 },
                { "3 Month", 345 },
                { "1 Month", 134 },
                { "2 Week", 68 },
                { "1 Week", 33 },
                { "3 Day", 14 }
            };

            // Subscribe to the ItemCheck event
            checkedListBox1.SelectedIndexChanged += CheckedListBox1_SelectedIndexChanged;

        }
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected items
            List<string> selectedItems = checkedListBox1.SelectedItems.Cast<string>().ToList();

            // If multiple items are selected, only display the value of the first selected item
            if (selectedItems.Count > 0)
            {
                string selectedItem = selectedItems[0];
                int value = itemValueMap[selectedItem];
                label15.Text = value.ToString();
            }
            else
            {
                // If no item is selected, clear the label
                label15.Text = "";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
            else if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
            else if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
           else if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
            else  if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                MessageBox.Show("Please fill every text box ");
                // You can choose to take additional actions here, such as disabling a submit button.
            }
            else
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                timer1.Start();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox10.Text = "";

                label15.Text = "";
            }
            string Query = "insert into monthlysubs (username, name, surname , plate, password, mail, color) values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" +textBox6.Text+"','"+ textBox7.Text  + "') ; "; 
            SqlConnection condb = new SqlConnection(connectionString);
            SqlCommand cmddatabase = new SqlCommand(Query, condb);
            SqlDataReader myreader;
            try
            {
                condb.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10; // Increase by 10% each time
            }
            else
            {
                // Stop the timer and show the information box
                timer1.Stop();
                MessageBox.Show("Payment completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length == 3) // Check if the text length is 3
            {
                int number;
                if (int.TryParse(textBox10.Text, out number)) // Check if the input is a valid integer
                {
                    // Input is a valid integer with 3 digits
                    // You can proceed with whatever you want to do with the valid input here
                }
                else
                {
                    // Input is not a valid integer
                    MessageBox.Show("Please enter a valid 3-digit ");
                    // Optionally, you can clear the text box or take other action
                    textBox10.Text = "";
                }
            }
            else if (textBox10.Text.Length > 3)
            {
                // Input is longer than 3 characters, so truncate it
                textBox10.Text = textBox10.Text.Substring(0, 3);
                // Optionally, you can inform the user about the limit
                MessageBox.Show("Only 3-digit  are allowed.");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 13) // Check if the text length is 12
            {
                int number;
                if (int.TryParse(textBox12.Text, out number)) // Check if the input is a valid integer
                {
                   
                }
                else
                {
                    // Input is not a valid integer
                    MessageBox.Show("Please enter a valid 12-digit card number.");
                    // Optionally, you can clear the text box or take other action
                    textBox12.Text = "";
                }
                 
            }
            else if (textBox10.Text.Length > 12)
            {
                // Input is longer than 12 characters, so truncate it
                textBox12.Text = textBox12.Text.Substring(0, 12);
                // Optionally, you can inform the user about the limit
                MessageBox.Show("Only 12-digit card numbers are allowed.");
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
