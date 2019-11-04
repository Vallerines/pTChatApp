using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Colour { get; set; }

        public User(string name, string colour)
        {
            Name = name;
            Colour = colour;
        }
    }
}
