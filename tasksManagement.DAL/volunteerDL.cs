
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using tasksManagement.DAL.models;

namespace tasksManagement.DAL
{
    public  class volunteerDL
    {
        IMongoClient client;
        IMongoDatabase database;
        IMongoCollection<volunteer> collection;
        public volunteerDL()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("volunteersSystem");
            collection = database.GetCollection<volunteer>("volunteers");
        }
        
        //שליפה של מתנדב בודד
        public volunteer GetVolunteer(string address)
        {
            var data = Builders<volunteer>.Filter.Where(b => b.address.Equals(address));
            
            var result = collection.Find(data).First();
            return result;
        }
        public void PostVolunteer(volunteer volunteer)
        {
            collection.InsertOne(volunteer);
        }

        /*            //collection.Find(q=>q.);
            volunteerDTO data = new volunteerDTO();
            data.names = "tamar";
            data.address="home";
            data.telephone = "0000000";
            

            //Add a piece of data
            collection.InsertOne(data);*/
    }
}
