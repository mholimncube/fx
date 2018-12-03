using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFK_Service.MongoRepos
{
    public class MongoDbRepos
    {
        public MongoClient Client;
        //The interface that manage the database
        public IMongoDatabase Db;

        public MongoDbRepos(string url, string database)
        {
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(database);
        }
    }
}