using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolAdmin.MongoDBDemo
{


    
    public class MongoDBService
    {
        MongoClient mongo = new MongoClient("mongodb://localhost:27017/school_admin_db");

        IMongoDatabase database;
        IMongoCollection<BsonDocument> teachersCollection, studentsCollection;

        public MongoDBService()
        {

            database = mongo.GetDatabase("school_admin_db");
            teachersCollection = database.GetCollection<BsonDocument>("teachers");
            studentsCollection = database.GetCollection<BsonDocument>("students");
            var Filter = Builders<BsonDocument>.Filter.Eq("reg_num", 1001);



        }

        public void Insert(string collectionName, BsonDocument dataToInsert)
        {
            switch (collectionName)
            {
                case "teachers":
                    teachersCollection.InsertOne(dataToInsert);



                    break;



                case "students":
                    studentsCollection.InsertOne(dataToInsert);
                    break;



                default:
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");



                    //include error message



                    break;
            }
        }

        public List<BsonDocument> FetchAll(string collectionName)
        {

            List<BsonDocument> result;
            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(new BsonDocument()).ToList();



                    break;



                case "students":
                    result = studentsCollection.Find(new BsonDocument()).ToList();
                    break;



                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed");



                    //include error message



                    break;
            }
            return result;
        }

        public List<BsonDocument> FetchWithFilter(string collectionName, KeyValuePair<string, object> filterPair, string comparer)
        {
            List<BsonDocument> result;
            FilterDefinition<BsonDocument> filter = GetFilter(filterPair, comparer);

            switch (collectionName)
            {
                case "teachers":
                    result = teachersCollection.Find(filter).ToList();
                    break;
                case "students":
                    result = studentsCollection.Find(filter).ToList();
                    break;
                default:
                    result = null;
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed.");
                    break;
            }
            return result;
        }


        public void Update(string collectionName, KeyValuePair<string, object> filterPair, string comparer, KeyValuePair<string, object> newData)
        {
            FilterDefinition<BsonDocument> filter = GetFilter(filterPair, comparer);
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(newData.Key, newData.Value.ToString());

            switch (collectionName)
            {
                case "teachers":
                    teachersCollection.UpdateOne(filter, update);
                    break;
                case "students":
                    studentsCollection.UpdateOne(filter, update);
                    break;
                default:
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed.");
                    break;
            }
        }


        public void Delete(string collectionName, KeyValuePair<string, object> filterPair, string comparer)
        {
            FilterDefinition<BsonDocument> filter = GetFilter(filterPair, comparer);

            switch (collectionName)
            {
                case "teachers":
                    teachersCollection.DeleteOne(filter);
                    break;
                case "students":
                    studentsCollection.DeleteOne(filter);
                    break;
                default:
                    Console.WriteLine("Invalid collection! Only 'teachers' and 'students' are allowed.");
                    break;
            }
        }


        private FilterDefinition<BsonDocument> GetFilter(KeyValuePair<string, object> filterPair, string comparer)
        {
            FilterDefinition<BsonDocument> filter;
            switch (comparer)
            {
                case "<":
                    filter = Builders<BsonDocument>.Filter.Lt(filterPair.Key, filterPair.Value);
                    break;
                case "<=":
                    filter = Builders<BsonDocument>.Filter.Lte(filterPair.Key, filterPair.Value);
                    break;
                case ">":
                    filter = Builders<BsonDocument>.Filter.Gt(filterPair.Key, filterPair.Value);
                    break;
                case ">=":
                    filter = Builders<BsonDocument>.Filter.Gte(filterPair.Key, filterPair.Value);
                    break;
                default:
                    filter = Builders<BsonDocument>.Filter.Eq(filterPair.Key, filterPair.Value);
                    break;
            }
            return filter;
        }



        public void TestConnection()
        {
            var dbList = mongo.ListDatabases().ToList();
            Console.WriteLine("This is the list of databases on this server: ");

            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
         }
    }

   

   
}
