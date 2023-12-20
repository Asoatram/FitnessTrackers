using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bebas;
using Microsoft.AspNetCore.SignalR.Client;
using MongoDB.Bson;
using MongoDB.Driver;


namespace FitnessTrackers
{
    public partial class Form7 : Form
    {
        private IMongoCollection<User> userCollection;
        private IMongoCollection<ChatMessage> messageCollection;
        private User currentUser;
        string Username;
        private readonly ChatroomMongoDBHandler mongoDBHandler;

        public Form7(string username, User user)
        {
            InitializeComponent();
            mongoDBHandler = new ChatroomMongoDBHandler("mongodb+srv://Asoatram:XMhspfgYNdBJeJUF@cluster0.px122pi.mongodb.net/\r\n\r\n", "Cluster0");
            currentUser = user;
            Username = username;
            LoadChatHistory();
        }
        private void InitializeMongoDB()
        {
            userCollection = MongoDBHelper.GetUserCollection();
        }
        private void LoadChatHistory()
        {
            var chatHistory = mongoDBHandler.GetChatHistory();
            foreach (var message in chatHistory)
            {
                listBox1.Items.Add($"{message.Sender}: {message.Content}");
            }
        }

        private void uniqueButtons1_Click(object sender, EventArgs e)
        {
            string user = currentUser.Username;
            string messageText = rjTextBox1.Texts;



            
                var message = new ChatMessage
                {
                    Sender = currentUser.Username,
                    Content = messageText,
                    Timestamp = DateTime.Now
                };
            
            mongoDBHandler.InsertMessage(message);

            // Update the chat history display
            listBox1.Items.Add($"{currentUser.Username}: {message.Content}");

            // Clear the message input
            rjTextBox1.Texts = "";
        }
    
        
        private string GetUsername(ObjectId userId)
        {
            var user = userCollection.Find(u => u.Id == userId).FirstOrDefault();
            return user?.Username ?? "Unknown User";
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}
