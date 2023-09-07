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
    class CActiveRescuers
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Rescuer_RFID { get; set; }
        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string RName { get; set; }
        [BsonElement("Rescuer_RFID"), BsonRepresentation(BsonType.String)]
        public string RescuerRFID { get; set; }
    }
}
