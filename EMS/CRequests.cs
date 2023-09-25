using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace EMS
{
    [Serializable]
    class CRequests
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Request_ID { get; set; }
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public String ReqAddress { get; set; }
        [BsonElement("Contact"), BsonRepresentation(BsonType.String)]
        public string ReqNumber { get; set; }
        [JsonIgnore]
        public int __v { get; set; }
    }
}
