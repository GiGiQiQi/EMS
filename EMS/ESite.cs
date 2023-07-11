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
    class ESite
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Evacuation_ID { get; set; }

        [BsonElement("Site_Name"), BsonRepresentation(BsonType.String)]
        public string Evacuation_name { get; set; }
        [BsonElement("Establishment_Type"), BsonRepresentation(BsonType.String)]
        public string Est_type { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Address { get; set; }
        [BsonElement("Capacity"), BsonRepresentation(BsonType.String)]
        public string Capacity { get; set; }
    }
}
