using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwayFromKeyboard.Models
{
    public class Status
    {
        [BsonId]
        public int Status_ID { get; set; }

        [BsonElement("Status Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Estimate Time Arrival")]
        public string Eta { get; set; }
    }
}