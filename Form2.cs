using bebas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessTrackers
{
    public partial class Form2 : Form
    {
        string userName;
        User user;
        private readonly MongoDBHelper mongoDBhandler;
        public Form2(string username, User users)
        {
            InitializeComponent();
            user = users;
            userName = username;
            mongoDBhandler = new MongoDBHelper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1(userName, user );
            f1.ShowDialog();
            if (f1.DialogResult == DialogResult.OK)
            {

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uniqueButtons1_Click(object sender, EventArgs e)
        {
            mongoDBhandler.UpdateTargetPlan(user.Username, "Weight Loss");
        }

        private void uniqueButtons2_Click(object sender, EventArgs e)
        {
            mongoDBhandler.UpdateTargetPlan(user.Username, "Muscle Gain");
        }
    }
}
