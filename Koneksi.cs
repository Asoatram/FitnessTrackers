using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Driver;
using FitnessTrackers;
using System.IO;
using SharpCompress.Common;
using static MongoDB.Driver.WriteConcern;


namespace bebas
{
    public class MongoDBHelper
    {
        private const string ConnectionString = "mongodb+srv://Asoatram:XMhspfgYNdBJeJUF@cluster0.px122pi.mongodb.net/\r\n\r\n";
        private const string DatabaseName = "Cluster0";

        private static MongoClient client = new MongoClient(ConnectionString);
        private static IMongoDatabase database = client.GetDatabase(DatabaseName);



        private readonly IMongoCollection<ChatMessage> messageCollection;
        private readonly IMongoCollection<User> userCollection;

        public static IMongoDatabase GetDatabase()
        {
            var client = new MongoClient(ConnectionString);
            return client.GetDatabase(DatabaseName);
        }
        public MongoDBHelper()
        {
            try
            {
                var client = new MongoClient(ConnectionString);
                database = client.GetDatabase(DatabaseName);
                userCollection = database.GetCollection<User>("Users");
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new InvalidOperationException("Failed to initialize MongoDB handler.", ex);
            }
        }

        public static IMongoCollection<User> GetUserCollection()
        {
            return database.GetCollection<User>("Users");
        }
        public List<ChatMessage> GetChatHistory()
        {
            return messageCollection.Find(_ => true).ToList();
        }

        public void InsertMessage(ChatMessage message)
        {
            messageCollection.InsertOne(message);
        }

        public void UploadProfilePicture(string userId, string filePath)
        {

            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update = Builders<User>.Update.Set(u => u.Profile, File.ReadAllBytes(filePath));

            userCollection.UpdateOne(userFilter, update);
        }

        public void UpdateHeightWeight(string userId, int height, int weight, int TargetWeight)
        {
            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update_height = Builders<User>.Update.Set(u => u.Height, height);
            var update_weight = Builders<User>.Update.Set(u => u.Weight, weight);
            var update_target_weight = Builders<User>.Update.Set(u => u.TargetWeight, TargetWeight);

            userCollection.UpdateOne(userFilter, update_height);
            userCollection.UpdateOne(userFilter, update_weight);
            userCollection.UpdateOne(userFilter, update_target_weight);

        }

        public void UpdateLastFitness(string userId, DateTime lastFitness)
        {
            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update_last_fitness = Builders<User>.Update.Set(u => u.LastFitnessTime, lastFitness);

            userCollection.UpdateOne(userFilter, update_last_fitness);
        }

        public void UpdateCheckBox1(string userId, bool value)
        {

            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update_check_box1 = Builders<User>.Update.Set(u => u.CheckBox1, value);


            userCollection.UpdateOne(userFilter, update_check_box1);

        }

        public void UpdateCheckBox2(string userId, bool value)
        {

            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update_check_box2 = Builders<User>.Update.Set(u => u.CheckBox2, value);



            userCollection.UpdateOne(userFilter, update_check_box2);

        }
        public void UpdateEXP(string userId, int exp)
        {
            var userFilter = Builders<User>.Filter.Eq(u => u.Username, userId);
            var update_exp = Builders<User>.Update.Set(u => u.EXP, exp);



            userCollection.UpdateOne(userFilter, update_exp);

        }



    }
}