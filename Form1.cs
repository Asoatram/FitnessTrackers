using bebas;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FitnessTrackers
{

    public partial class Form1 : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        string Username;
        private readonly IMongoCollection<User> personCollection;
        User users;
        Image Profilepic;
        private readonly MongoDBHelper mongoDBHandler;
        public Form1(string username, User user)
        {
            LoadCustomFont("DMSans-VariableFont_opsz,wght.ttf");
            this.mongoDBHandler = new MongoDBHelper();
            users = user;
            InitializeComponent();
            Username = username;
            checkBox1.ForeColor = Color.White;
            checkBox2.ForeColor = Color.White;
            label2.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            label3.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            label4.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            label5.Font = new Font(privateFontCollection.Families[0], 12f, FontStyle.Bold);
            label6.Font = new Font(privateFontCollection.Families[0], 13f, FontStyle.Regular);
            label7.Font = new Font(privateFontCollection.Families[0], 13f, FontStyle.Regular);
            label8.Font = new Font(privateFontCollection.Families[0], 13f, FontStyle.Regular);
            label10.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 200, 245, 96);
            label4.ForeColor = Color.FromArgb(255, 200, 245, 96);
            label5.ForeColor = Color.FromArgb(255, 200, 245, 96);
            Profilepic = ImageConverter.ConvertBytesToImage(users.Profile);
            if (users.Profile != null)
            {
                try
                {
                    pictureBox1.Image = Profilepic;
                }
                catch
                {

                }
            }
            loadUserData();
            circularProgressBar1.Value = users.EXP % 100;

            float absValue = (Math.Abs(users.TargetWeight - users.Weight));
            float value = 100 * (absValue / users.TargetWeight);
            roundCorneredProgressBar1.Value = 100 - (int)(value);
            roundCorneredProgressBar1.Animate();
            string result = "Hi, " + Username + "!";
            label2.Text = result;
            if (users.CheckBox1 == false)
            {
                checkBox1.Checked = false;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox1.Enabled = true;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
            }
            else
            {
                checkBox1.Checked = true;
                mongoDBHandler.UpdateCheckBox2(users.Username, true);
                checkBox1.CheckState = CheckState.Checked;
                checkBox1.Enabled = false;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
            }
            if (users.CheckBox2 == false)
            {
                checkBox2.Checked = false;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox2.Enabled = true;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
            }
            else
            {
                checkBox2.Checked = true;
                mongoDBHandler.UpdateCheckBox2(users.Username, true);
                checkBox2.CheckState = CheckState.Checked;
                checkBox2.Enabled = false;
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
            }
            DateTime today = DateTime.Today;


            if (users.LastFitnessTime.Day != today.Day)
            {
                mongoDBHandler.UpdateCheckBox1(users.Username, false);
                mongoDBHandler.UpdateCheckBox2(users.Username, false);
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;

            }
            int Level;
            Level = users.EXP / 100;
            label12.Text = $"Level {Level}";
            UpdatePlan();
           
        }

        private void UpdatePlan()
        {
            if(users.TargetPlan == "Muscle Gain")
            {
                label11.Text = "- Squat: 4 sets x 8-12 reps\r\n\r\n- Deadlift: 4 sets x 8-12 reps\r\n\r\n- Bench press: 4 sets x 8-12 reps\r\n\r\n- Pull-up: 4 sets x 8-12 reps\r\n\r\n- Shoulder press: 3 sets x 10-15 reps";
                label31.Text = "- Leg press: 4 sets x 12-15 reps\r\n\r\n- Lunges: 3 sets x 12-15 reps per leg\r\n\r\n- Cable flyes: 3 sets x 12-15 reps\r\n\r\n- Bent-over rows: 4 sets x 12-15 reps\r\n\r\n- Bicep curls: 3 sets x 12-15 reps\r\n\r\n- Tricep dips: 3 sets x 12-15 reps";
                label20.Text = "- Oatmeal Protein Bowl\r\n\r\n- Telur dan Sayuran ";
                label23.Text = "- Ayam Panggang Quinoa Bowl\r\n\r\n- Ikan Bakar dan Kentang Manis ";
                label26.Text = "- Grilled Beef dan Kentang Tumbuk\r\n\r\n- Tofu dan Sayuran Stir-Fry ";
                label13.Text = "Snack";
                label14.Text = "- Smoothie Protein\r\n\r\n- Kacang Almond atau Pistachio\r\n\r\n- Yogurt Greek";
            }
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadUserData()
        {
            if (users.TargetWeight == 0)
            {
                label5.Text = "Null";
            }
            else
            {
                label5.Text = users.TargetWeight.ToString();
            }
            if (users.Height == 0)
            {
                label3.Text = "Null";
            }
            else
            {
                label3.Text = users.Height.ToString();
            }
            if (users.Weight == 0)
            {
                label4.Text = "Null";
            }
            else
            {
                label4.Text = users.Weight.ToString();
            }
            label9.Font = new Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
            label9.Text = $"{users.Username}";

        }

        private void uniqueButtons1_Click_1(object sender, EventArgs e)
        {
            Form f2 = new Form2(Username, users);
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {

            }
        }
       
        private void uniqueButtons3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4(users);
            f4.ShowDialog();
            if (f4.DialogResult == DialogResult.OK)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void uniqueButtons4_Click(object sender, EventArgs e)
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

        private void uniqueButtons2_Click(object sender, EventArgs e)
        {
            Form f8 = new FormProfile(Username, users);
            f8.ShowDialog();
            if (f8.DialogResult == DialogResult.OK)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void uniqueButtons1_MouseLeave(object sender, EventArgs e)
        {
            uniqueButtons1.BackColor = Color.Transparent;
            uniqueButtons1.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }
        private void uniqueButtons1_MouseEnter(object sender, EventArgs e)
        {
            uniqueButtons1.BackColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons1.ForeColor = Color.FromArgb(255, 120, 98, 248);
        }

        private void uniqueButtons2_MouseEnter(object sender, EventArgs e)
        {
            uniqueButtons2.BackColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons2.ForeColor = Color.FromArgb(255, 120, 98, 248);
        }

        private void uniqueButtons2_MouseLeave(object sender, EventArgs e)
        {
            uniqueButtons2.BackColor = Color.Transparent;
            uniqueButtons2.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void uniqueButtons3_MouseEnter(object sender, EventArgs e)
        {
            uniqueButtons3.BackColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons3.ForeColor = Color.FromArgb(255, 120, 98, 248);
        }

        private void uniqueButtons3_MouseLeave(object sender, EventArgs e)
        {
            uniqueButtons3.BackColor = Color.Transparent;
            uniqueButtons3.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void uniqueButtons4_MouseEnter(object sender, EventArgs e)
        {
            uniqueButtons4.BackColor = Color.FromArgb(255, 200, 245, 96);
            uniqueButtons4.ForeColor = Color.FromArgb(255, 120, 98, 248);
        }

        private void uniqueButtons4_MouseLeave(object sender, EventArgs e)
        {
            uniqueButtons4.BackColor = Color.Transparent;
            uniqueButtons4.ForeColor = Color.FromArgb(255, 255, 255, 255);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            DateTime lastFitness = DateTime.Today;
            lastFitness = lastFitness.AddDays(1);

            mongoDBHandler.UpdateLastFitness(users.Username, lastFitness);
            if (checkBox2.Checked && !users.CheckBox2)
            {
                mongoDBHandler.UpdateEXP(users.Username, users.EXP + 50);
            }
            mongoDBHandler.UpdateCheckBox1(users.Username, checkBox1.Checked);
            checkBox1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            DateTime lastFitness = DateTime.Today;
            lastFitness = lastFitness.AddDays(1);
            if (checkBox2.Checked && !users.CheckBox2)
            {
                mongoDBHandler.UpdateEXP(users.Username, users.EXP + 50);
            }

            mongoDBHandler.UpdateLastFitness(users.Username, lastFitness);
            mongoDBHandler.UpdateCheckBox2(users.Username, checkBox2.Checked);
            checkBox2.Enabled = false;

        }


        private void roundCorneredProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}