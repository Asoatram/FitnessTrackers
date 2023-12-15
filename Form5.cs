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


namespace FitnessTrackers
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

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
                        Username = textBox1.Text;
                        Password = textBox2.Text;

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
                        textBox1.Clear();
                        textBox2.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.ShowDialog();
            if (f6.DialogResult == DialogResult.OK)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {
            int x = 10;
            int y = 10;
            int size = 50;
            e.Graphics.FillRectangle(Brushes.Blue, x, y, size, size);

        }
    }
}
