using bebas;
using MongoDB.Driver.Core.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitnessTrackers
{
    public partial class Form4 : Form
    {
        private readonly MongoDBHelper mongoDBHandler;
        User currentUser;
        public Form4(User user)
        {
            this.currentUser = user;
            this.mongoDBHandler = new MongoDBHelper();
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Weight = int.Parse(textBox2.Text);
            int Height = int.Parse(textBox1.Text);
            int TargetWeight= int.Parse(textBox3.Text);

            mongoDBHandler.UpdateHeightWeight(currentUser.Username, Height, Weight, TargetWeight);

        }
    }
}
