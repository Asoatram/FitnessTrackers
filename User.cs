using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessTrackers
{
    public class User
    {
    
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Profile")]
        public byte[] Profile { get; set; }

        [BsonElement("TargetWeight")]
        public int TargetWeight { get; set; }
        [BsonElement("Height")]
        public int Height { get; set; }
        [BsonElement("Weight")]
        public int Weight { get; set; }
        [BsonElement("EXP")]
        public int EXP { get; set; }
        [BsonElement("LastFitnessTime")]
        public DateTime LastFitnessTime { get; set; }
        [BsonElement("CheckBox1")]
        public bool CheckBox1 { get; set; }

        [BsonElement("CheckBox2")]
        public bool CheckBox2 { get; set; }

        [BsonElement("TargetPlan")]
        public string TargetPlan { get; set; }


    }

}
