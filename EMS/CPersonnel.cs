using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EMS
{
    [Serializable]
    class CPersonnel
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Personnel_ID { get; set; }
        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string Personnel_Name { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Personnel_Address { get; set; }
        [BsonElement("ContactNumber"), BsonRepresentation(BsonType.String)]
        public string Personnel_CNumber { get; set; }
        [BsonElement("BirthDate"), BsonRepresentation(BsonType.String)]
        public string BirthDate { get; set; }
        [BsonElement("Gender"), BsonRepresentation(BsonType.String)]
        public string Gender { get; set; }
        [BsonElement("Username"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }
        [BsonElement("Password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }
    }
}
