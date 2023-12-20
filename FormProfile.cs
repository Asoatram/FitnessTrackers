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
using System.IO;


namespace FitnessTrackers
{
    public partial class FormProfile : Form
    {
        private readonly MongoDBHelper mongoDBHandler;
        User currentUser;
        String username;
        public FormProfile(String username,User users)
        {
            InitializeComponent();
            mongoDBHandler = new MongoDBHelper();
            currentUser = users;
            this.username = username;
            LoadUserProfile();
        }
        private void LoadUserProfile()
        {
            if (currentUser != null)
            {
                // Display user information
                

                // Display profile picture if available
                if (currentUser.Profile != null && currentUser.Profile.Length > 0)
                {
                    pictureBox1.Image = ImageConverter.ConvertBytesToImage(currentUser.Profile);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.png)|*.png;|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Upload profile picture to MongoDB
                    mongoDBHandler.UploadProfilePicture(currentUser.Username, selectedFilePath);

                    // Reload user profile to display the updated picture
                    LoadUserProfile();
                }
            }
        }
    }


    
}
