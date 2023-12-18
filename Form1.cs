using MongoDB.Driver;
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
        private readonly IMongoCollection<User> personCollection;
        User users;
        Image Profilepic;
        public Form1(string username, User user)
        {
            users = user;
        InitializeComponent();
            Username = username;
            Profilepic = ImageConverter.ConvertBytesToImage(users.Profile);
            if (users.Profile != null)
            {
                try
                {
                    pictureBox1.Image = Profilepic;
                } catch
                {
          
                }
            }
                string result = "Selamat datang kembali, " + Username + "!";
            label2.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2(Username, users);
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

        private void uniqueButtons1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7(Username, users);
            f7.ShowDialog();
            if (f7.DialogResult == DialogResult.OK)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f8 = new FormProfile(Username, users);
            f8.ShowDialog();
            if (f8.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
