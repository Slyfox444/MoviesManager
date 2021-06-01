using MoviesManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesManager.Repositories
{
    public class ContactsRepository
    {
        MoviesManagerDbContext context = new MoviesManagerDbContext();

        public void Insert(Contact item)
        {
            context.Contacts.Add(item);
            context.SaveChanges();
        }
        public void Update(Contact item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<Contact> GetContacts(int Id)
        {
            return context.Contacts.ToList();
        }
        public Contact GetById(int id)
        {
            return context.Contacts.Where(i => i.Id == id).FirstOrDefault();
        }
        public void Delete(int id)
        {
            Contact item = context.Contacts.Where(i => i.Id == id).FirstOrDefault();
            context.Contacts.Remove(item);
            context.SaveChanges();
        }
    }
}