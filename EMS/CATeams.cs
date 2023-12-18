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
    class CATeams
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string TeamID { get; set; }
        [BsonElement("TeamName"), BsonRepresentation(BsonType.String)]
        public string TeamName { get; set; }
        [BsonElement("MemberName"), BsonRepresentation(BsonType.String)]
        public List<string> MemberName { get; set; }
        [BsonElement("TeamContact"), BsonRepresentation(BsonType.String)]
        public string TeamContact { get; set; }
    }
}
