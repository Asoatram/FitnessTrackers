using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace FitnessTrackers
{
    public class ChatMessage
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("SenderId")]
        public string Sender { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("Timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
