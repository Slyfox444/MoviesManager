using MoviesManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MoviesManager.Repositories
{
    public class UsersRepository
    {
        MoviesManagerDbContext context = new MoviesManagerDbContext();

        public User GetByID(int id)
        {
            return context.Users.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Insert(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
        }
        public void Update(User item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }
        
        public void Delete(int id)
        {
            User item = context.Users.Where(i => i.Id == id).FirstOrDefault();
            context.Users.Remove(item);
            context.SaveChanges();

        }
        public User GetByUsernameAndPassword(string username, string password)
        {
            return context.Users.Where(i => i.Username == username && i.Password == password).FirstOrDefault();
        }
    }
}