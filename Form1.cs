﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
    }
}
