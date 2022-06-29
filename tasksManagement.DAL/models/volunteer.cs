using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace tasksManagement.DAL.models
{
    public class volunteer
    {
        public ObjectId _id;
        public string name;
        public string address;
        public string telephone;
    }
}
