using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;   //this two line extra added and this class file is extra added for some core configuration
using System.Configuration;
using MongoDB.Bson;

namespace MVCwithMongoDBCRUD.App_Start
{
    public class MongoDBContext
    {
       
        public IMongoDatabase database;

        public MongoDBContext()                        //this is constructor //we are passing everything from database 
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}