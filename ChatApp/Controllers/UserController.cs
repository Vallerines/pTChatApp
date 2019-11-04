using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        List<User> Users = new List<User>
        {
            new User("shaun", "#FF0000"),
            new User("ben", "#00FF00"),
            new User("james", "#0000FF")
        };

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // Internal class to assist with JSON posting
        public class UserWrapper
        {
            public string name { get; set; }
            public string colour { get; set; }
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] UserWrapper user)
        {
            Users.Add(new User(user.name, user.colour));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(string name)
        {
            foreach (User u in Users)
            {
                if(u.Name == name)
                {
                    Users.Remove(u);
                }
            }

        }
    }
}
