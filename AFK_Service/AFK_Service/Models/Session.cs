using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFK_Service.Models
{
    public class Session
    {
        [BsonId]
        public int Session_Id { get; set; }

        [BsonElement("Time Locked")]
        public DateTime lockTime { get; set; }

        [BsonElement("Time Unlocked")]
        public DateTime unlockTime { get; set; }

        [BsonElement("Active Session Time")]
        public TimeSpan active_Time { get; set; }

    }
}