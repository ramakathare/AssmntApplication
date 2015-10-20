using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assmnt.WebApi.Controllers
{
    public class Employee
    {
        [BsonId]
        public object _id{get;set;}
        public string name {get;set;}
    }
}
