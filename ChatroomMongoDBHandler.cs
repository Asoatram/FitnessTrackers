using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackers
{
    internal class ChatroomMongoDBHandler
    {
        private readonly IMongoDatabase database;
        private readonly IMongoCollection<ChatMessage> messageCollection;
        private readonly ChangeStreamOptions changeStreamOptions;

        public ChatroomMongoDBHandler(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            messageCollection = database.GetCollection<ChatMessage>("ChatMessages");

            changeStreamOptions = new ChangeStreamOptions { FullDocument = ChangeStreamFullDocumentOption.UpdateLookup };
        }

        public IChangeStreamCursor<ChangeStreamDocument<ChatMessage>> WatchChatCollection()
        {
            return messageCollection.Watch(changeStreamOptions);
        }

        public void InsertMessage(ChatMessage message)
        {
            messageCollection.InsertOne(message);
        }

        public List<ChatMessage> GetChatHistory()
        {
            return messageCollection.Find(_ => true).ToList();
        }
    }
}
