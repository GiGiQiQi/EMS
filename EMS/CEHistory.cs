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
    class CEHistory
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Evacuee_ID { get; set; }
        [BsonElement("EvacueeName"), BsonRepresentation(BsonType.String)]
        public string EvacueeName { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string EvacueeAddress { get; set; }
        [BsonElement("EvacuationSite"), BsonRepresentation(BsonType.String)]
        public string EvacSite { get; set; }
        [BsonElement("Dependents"), BsonRepresentation(BsonType.Decimal128)]
        public decimal Dependents { get; set; }
        [BsonElement("DateIn"), BsonRepresentation(BsonType.String)]
        public String dateIn { get; set; }
        [BsonElement("DateOut"), BsonRepresentation(BsonType.String)]
        public String dateOut { get; set; }
    }
}
