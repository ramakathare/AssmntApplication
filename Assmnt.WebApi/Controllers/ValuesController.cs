using Assmnt.WebApi.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Assmnt.WebApi.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        // GET api/Employees
        public string Get()
        {
            //var client = new MongoClient(Settings.Default.MongoConnection);
            //var db = client.GetDatabase(Settings.Default.DBName);
            //return db.GetCollection<Employee>("Employees").AsQueryable();
            return "Hello"; 
        }

        // GET api/Employees/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Employees
        public async void Post(Employee emp)
        {
            var client = new MongoClient(Settings.Default.MongoConnection);
            var db = client.GetDatabase(Settings.Default.DBName);
            var collection = db.GetCollection<Employee>("Employees");
            collection.InsertOneAsync(emp);
        }

        // PUT api/Employees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Employees/5
        public void Delete(Employee emp)
        {
            var client = new MongoClient(Settings.Default.MongoConnection);
            var db = client.GetDatabase(Settings.Default.DBName);
            var collection = db.GetCollection<Employee>("Employees");
            collection.DeleteOneAsync(p=>p.name.Equals(emp.name));
        }
    }
}
