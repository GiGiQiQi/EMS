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
    class CEvacuee
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Evacuee_ID { get; set; }
        [BsonElement("RFIDNum"), BsonRepresentation(BsonType.String)]
        public string RFID_Number { get; set; }
        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string Evacuee_Name { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Evacuee_Address { get; set; }
        [BsonElement("Barangay"), BsonRepresentation(BsonType.String)]
        public string Barangay { get; set; }
        [BsonElement("ContactNumber"), BsonRepresentation(BsonType.String)]
        public string Contact_Number { get; set; }
        [BsonElement("Dependents"), BsonRepresentation(BsonType.Decimal128)]
        public decimal Dependents { get; set; }
        [BsonElement("ContactPerson"), BsonRepresentation(BsonType.String)]
        public string Contact_Person { get; set; }
        [BsonElement("Contact"), BsonRepresentation(BsonType.String)]
        public string Contact_Person_Number { get; set; }
        [BsonElement("Relationship"), BsonRepresentation(BsonType.String)]
        public string Relationship { get; set; }
    }
}
