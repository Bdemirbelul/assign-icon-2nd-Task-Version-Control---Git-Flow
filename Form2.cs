using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ParkingManagmentSystem
{
    public partial class Form2 : Form
    {
        public class RoundButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

                this.Region = new Region(graphicsPath);

                base.OnPaint(e);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        public void button4_Click(object sender, EventArgs e)
        {
           LogIn form= new LogIn();
            form.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void label7_Click(object sender, EventArgs e)
        {
            DateTime thirtyMinutesBefore = DateTime.Now.AddMinutes(-30);

            // Set the label's text to the calculated time
            label7.Text = thirtyMinutesBefore.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            // Fare butonunun üzerine gelindiğinde görüntülenecek metin
            label1.Text = "Pay Ticket";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Fare butonun üzerinden çıkıldığında metni temizle
            label1.Text = "";
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            // Fare butonunun üzerine gelindiğinde görüntülenecek metin
            label1.Text = "Monthly Sub";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Fare butonun üzerinden çıkıldığında metni temizle
            label1.Text = "";
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            // Fare butonunun üzerine gelindiğinde görüntülenecek metin
            label1.Text = "Log Out";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            // Fare butonun üzerinden çıkıldığında metni temizle
            label1.Text = "";
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            // Fare butonunun üzerine gelindiğinde görüntülenecek metin
            label1.Text = "Previous Payment ";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            // Fare butonun üzerinden çıkıldığında metni temizle
            label1.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            form.Show();
            this.Hide();
        }
    }
}
