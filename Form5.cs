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
using System.Security.Policy;
using System.Drawing.Text;
using MongoDB.Bson;
using MongoDB.Driver;



namespace FitnessTrackers
{
    public partial class Form5 : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public Form5()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 33, 37, 31);
            uniqueButtons1.BackColor = Color.FromArgb(255, 200,245, 96);
            uniqueButtons2.BackColor = Color.FromArgb(255, 37, 37, 37);
            rjTextBox1.BackColor = Color.FromArgb(255, 78, 81, 92);
            rjTextBox2.BackColor = Color.FromArgb(255, 78, 81, 92);

            LoadCustomFont("DMSans-VariableFont_opsz,wght.ttf");

            richTextBox1.Font = new Font(privateFontCollection.Families[0], 13f, FontStyle.Bold);
            uniqueButtons1.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            uniqueButtons1.ForeColor = Color.FromArgb(255, 121, 38, 250);
            uniqueButtons2.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            uniqueButtons2.ForeColor = Color.FromArgb(255, 255, 255, 255);
            rjTextBox1.BorderColor = Color.FromArgb(255, 78, 81, 92);
            rjTextBox2.BorderColor = Color.FromArgb(255, 78, 81, 92);
            label2.Font = new Font(privateFontCollection.Families[0], 16f, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 200, 245, 96 );
            label4.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label5.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label6.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label7.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label1.Font = new Font(privateFontCollection.Families[0], 10f, FontStyle.Bold);
            label3.Font = new Font(privateFontCollection.Families[0], 10f, FontStyle.Bold);
            CreateColorfulLabel();

        }
        private void CreateColorfulLabel()
        {
            
            // Set the text
            string sentence = "FitnessTrackers";
            richTextBox1.Text = sentence;

            // Set different colors for each word
            int currentIndex = 0;
            foreach (string word in sentence.Split('T'))
            {
                richTextBox1.SelectionStart = currentIndex;
                richTextBox1.SelectionLength = word.Length;
                bool change = false;
                if (word[currentIndex] == 'T')
                {
                    change = true;
                }
                // Set the color for the current word
                if (!change)
                    richTextBox1.SelectionColor = Color.FromArgb(255, 200, 245, 96);
                else
                    richTextBox1.SelectionColor = Color.FromArgb(255,121, 98, 250);

                 
            }

            // Disable selection
            richTextBox1.SelectionLength = 0;

           
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
            

private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uniqueButtons1_Click(object sender, EventArgs e)
        {
            string Username = rjTextBox1.Texts;
            string Password = rjTextBox2.Texts;

                SqlConnection conn = Conn.GetConn();
                try
                {
                    conn.Open();
                    string querry = "SELECT * FROM UserInfo NEW WHERE UserId= '" + Username + "' AND Password = '" + Password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        Username = rjTextBox1.Texts;
                        Password = rjTextBox2.Texts;
                        Form1 f1 = new Form1(Username);
                        f1.ShowDialog();

                        if (f1.DialogResult == DialogResult.OK)
                        {

                        }
                    this.Close();
                }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rjTextBox1.Texts = "";
                    rjTextBox2.Texts = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Error");

                }
                finally
                {
                    conn.Close();
                }
        }

        private void uniqueButtons2_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.ShowDialog();
            if (f6.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
