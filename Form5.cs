using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBox2.Items.Add("Yes");
            comboBox2.Items.Add("No");
            // Optionally, you can set a default selection
            comboBox2.SelectedIndex = 0; // Selects the first item ("Yes")

            // Wire up the event handler for SelectedIndexChanged event
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length == 13) // Check if the text length is 12
            {
                int number;
                if (int.TryParse(textBox10.Text, out number)) // Check if the input is a valid integer
                {

                }
                else
                {
                    // Input is not a valid integer
                    MessageBox.Show("Please enter a valid 12-digit card number.");
                    // Optionally, you can clear the text box or take other action
                    textBox10.Text = "";
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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length == 3) // Check if the text length is 3
            {
                int number;
                if (int.TryParse(textBox12.Text, out number)) // Check if the input is a valid integer
                {
                    // Input is a valid integer with 3 digits
                    // You can proceed with whatever you want to do with the valid input here
                }
                else
                {
                    // Input is not a valid integer
                    MessageBox.Show("Please enter a valid 3-digit ");
                    // Optionally, you can clear the text box or take other action
                    textBox12.Text = "";
                }
            }
            else if (textBox12.Text.Length > 3)
            {
                // Input is longer than 3 characters, so truncate it
                textBox10.Text = textBox10.Text.Substring(0, 3);
                // Optionally, you can inform the user about the limit
                MessageBox.Show("Only 3-digit  are allowed.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "6$";
            textBox10.Text = "";
            textBox12.Text = "";
          
            string selectedOption = comboBox2.SelectedItem.ToString();
            if (selectedOption == "Yes")
            {
                label10.Text = "0";
                MessageBox.Show("You have monthly sub ! have a nice day ;)", "Confirmation ", MessageBoxButtons.OK);
            }
            else if (selectedOption == "No")
            {
                label10.Text = value;
                MessageBox.Show("Your total invoice is 6$ ! Payment done ", "Information ", MessageBoxButtons.OK);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DateTime thirtyMinutesBefore = DateTime.Now.AddMinutes(-30);

            // Set the label's text to the calculated time
            label2.Text = thirtyMinutesBefore.ToString();
        }
    }
}
