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
    class CMNumbers1
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("Mobile Number"), BsonRepresentation(BsonType.String)]
        public string Number { get; set; }
    }
}
