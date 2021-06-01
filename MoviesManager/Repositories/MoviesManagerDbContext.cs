using MoviesManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesManager.Repositories
{
    public class MoviesManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public MoviesManagerDbContext()
            : base(@"Server =.\SQLEXPRESS; Database=TESTUDB;Trusted_Connection=True;")
        {
            Users = Set<User>();
            Contacts = Set<Contact>();
            Phones = Set<Phone>();
        }
    }
}