using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesManager.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public List<Contact> Contacts { get; set; }
    }
}