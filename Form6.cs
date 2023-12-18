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
using bebas;
using System.Windows.Input;
using System.Drawing.Text;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitnessTrackers
{
    
    public partial class Form6 : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        private IMongoCollection<User> userCollection;

        public Form6()
        {
            InitializeComponent();
            InitializeMongoDB();
            LoadCustomFont("DMSans-VariableFont_opsz,wght.ttf");
            richTextBox1.Font = new Font(privateFontCollection.Families[0], 13f, FontStyle.Bold);
            label3.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons1.BackColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons1.Font = new Font(privateFontCollection.Families[0], 10f, FontStyle.Bold);
            label4.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label5.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label6.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label7.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
        }

        private void InitializeMongoDB()
        {
            userCollection = MongoDBHelper.GetDatabase().GetCollection<User>("Users");
        }
        private void LoadCustomFont(string fontFileName)
        {
            // Load the custom font into the PrivateFontCollection
            try
            {
                privateFontCollection.AddFontFile(fontFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading custom font: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uniqueButtons1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (userCollection.Find(u => u.Username == username).Any())
            {
                MessageBox.Show("Username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User newUser = new User();
            newUser.Username =  username;
            newUser.Password = password;

            userCollection.InsertOne(newUser);

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 f1 = new Form1(username, newUser);
            f1.ShowDialog();
            if (f1.DialogResult == DialogResult.OK)
            {

            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
