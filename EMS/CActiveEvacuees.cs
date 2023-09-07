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
    class CActiveEvacuees
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Evacuee_ID { get; set; }
        [BsonElement("EID"), BsonRepresentation(BsonType.String)]
        public String RFID { get; set; }
        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string EName { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string EAddress { get; set; }
        [BsonElement("ContactNumber"), BsonRepresentation(BsonType.String)]
        public string CPerson { get; set; }
        [BsonElement("EvacuationSite"), BsonRepresentation(BsonType.String)]
        public string ESite { get; set; }
        [BsonElement("Dependents"), BsonRepresentation(BsonType.Decimal128)]
        public decimal DPS { get; set; }
        [BsonElement("Date"), BsonRepresentation(BsonType.String)]
        public String Date { get; set; }
    }
}
