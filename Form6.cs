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

namespace FitnessTrackers
{
    
    public partial class Form6 : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public Form6()
        {
            InitializeComponent();
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
        Koneksi Conn = new Koneksi();

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
            SqlConnection conn = Conn.GetConn();
            SqlCommand command = new SqlCommand("INSERT INTO UserInfo (UserId,  Password) VALUES (@UserId, @Password)", conn);
            command.Parameters.AddWithValue("@UserId", username);
            command.Parameters.AddWithValue("@Password", password);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Form f1 = new Form1(username);
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
