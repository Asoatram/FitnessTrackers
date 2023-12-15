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

namespace FitnessTrackers
{
    class UserId
    {
        public string Id { get; set; }
        public string Pass { get; set; }
        public UserId(string Id, string Pass) { 
            this.Id = Id;
            this.Pass = Pass;  
        }

    }
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserId user = new UserId(textBox1.Text, textBox2.Text);
            string username = user.Id;
            string password = user.Pass;
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
    }
}
