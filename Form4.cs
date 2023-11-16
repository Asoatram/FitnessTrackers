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
        public Form4()
        {
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
            float Height = float.Parse(textBox1.Text);
            float Weight = float.Parse(textBox2.Text);
            Height /= 100;

            float BMI = (Weight)/(Height *Height);
            if (BMI < 18.5)
            {
                MessageBox.Show($"You are severely underweight \nYour calculated body mass index: {BMI}");
            } else if(BMI >= 18.5 && BMI < 25)
            {
                MessageBox.Show($"You have a normal bodyweight \nYour calculated body mass index: {BMI}");
            }
            else if (BMI >= 25.1 && BMI < 29.9)
            {
                MessageBox.Show($"You are overweight \nYour calculated body mass index: {BMI}");
            }
            else if (BMI >= 29.9 && BMI < 34.9)
            {
                MessageBox.Show($"You are obese \nYour calculated body mass index: {BMI}");
            }
            else if (BMI >= 34.9)
            {
                MessageBox.Show($"You are severely obese \nYour calculated body mass index: {BMI}");
            }
        }
    }
}
