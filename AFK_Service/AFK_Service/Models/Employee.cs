using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFK_Service.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Employee_ID { get; set; }

        [BsonElement("Name")]
        public string  Name { get; set; }

        public IList<Session> Sessions { get; set; }

        [BsonElement("Status")]
        public Status Status { get; set; }
    }
}