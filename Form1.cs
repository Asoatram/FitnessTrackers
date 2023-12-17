using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackers
{
    public partial class Form1 : Form
    {
        string Username;
        Image imagePic;
         public Form1(string username)
        {
            InitializeComponent();
            Username = username;

            string result = "Selamat datang kembali, " + Username + "!";
            label2.Text = result;
            
        }
        private void LoadImage()
        {
            try
            {
                // Specify the path to your image file
                string imagePath = @"C:\Users\Lenovo\source\repos\Asoatram\FitnessTrackers\Resources\20230209002158_IMG_44581.png";

                // Load the image from the file
                Image imagePic = Image.FromFile(imagePath);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
            if(f2.DialogResult == DialogResult.OK)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.ShowDialog();
            if (f4.DialogResult == DialogResult.OK)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            f7.ShowDialog();
            if (f7.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
