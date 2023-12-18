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


namespace bebas
{
    public class MongoDBHelper
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "UserInfo";

        private static MongoClient client = new MongoClient(ConnectionString);
        private static IMongoDatabase database = client.GetDatabase(DatabaseName);
   


        private readonly IMongoCollection<ChatMessage> messageCollection;
        private readonly IMongoCollection<User> userCollection;
        
        public static IMongoDatabase GetDatabase()
        {
            var client = new MongoClient(ConnectionString);
            return client.GetDatabase(DatabaseName);
        }
        public MongoDBHelper(string connectionString, string databaseName)
        {
            try
            {
                var client = new MongoClient(connectionString);
                database = client.GetDatabase(databaseName);
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


    }
}
