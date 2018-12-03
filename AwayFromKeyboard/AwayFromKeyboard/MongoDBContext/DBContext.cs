using AwayFromKeyboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AwayFromKeyboard.MongoDBContext
{
    public class DBContext
    {
        public const string CONNECTION_STRING_NAME = "connectionString";
        public const string DATABASE_NAME = "AFKdb";
        public const string EMPLOYEE_COLLECTION = "Employee";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static DBContext()
        {
            string constr = ConfigurationManager.AppSettings[CONNECTION_STRING_NAME];
            _client = new MongoClient(constr);
            _database = _client.GetDatabase("AFKdb");
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Employee> Employees
        {
            get { return _database.GetCollection<Employee>(EMPLOYEE_COLLECTION); }
        }


    }
}