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
    class CAdmin
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Admin_ID { get; set; }
        [BsonElement("AdminName"), BsonRepresentation(BsonType.String)]
        public string Admin_Name { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Address { get; set; }
        [BsonElement("ContactNumber"), BsonRepresentation(BsonType.String)]
        public string Contact_Number { get; set; }
        [BsonElement("BirthDate"), BsonRepresentation(BsonType.String)]
        public string BirtDate { get; set; }
        [BsonElement("Gender"), BsonRepresentation(BsonType.String)]
        public string Gender { get; set; }
        [BsonElement("Uasername"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }
        [BsonElement("Password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }
    }
}
