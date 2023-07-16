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
    class CRescuers
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Rescuer_ID { get; set; }
        [BsonElement("RescuerName"), BsonRepresentation(BsonType.String)]
        public string RescuerName { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Address { get; set; }
        [BsonElement("ContactNumber"), BsonRepresentation(BsonType.String)]
        public string Contact_Number { get; set; }
        [BsonElement("BirthDate"), BsonRepresentation(BsonType.String)]
        public string BirtDate { get; set; }
        [BsonElement("Gender"), BsonRepresentation(BsonType.String)]
        public string Gender { get; set; }
    }
}
