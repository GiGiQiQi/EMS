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
        [BsonElement("TeamNumber"), BsonRepresentation(BsonType.String)]
        public string TNum { get; set; }
        [BsonElement("MemberName"), BsonRepresentation(BsonType.String)]
        public List<string> MemberName { get; set; }
        [BsonElement("TeamLocation"), BsonRepresentation(BsonType.String)]
        public string TLoc { get; set; }
    }
}
