using MoviesManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MoviesManager.Repositories
{
    public class PhonesRepository
    {
        MoviesManagerDbContext contex = new MoviesManagerDbContext();

        public void Insert(Phone item)
        {
            contex.Phones.Add(item);
            contex.SaveChanges();
        }
        public void Update(Phone item)
        {
            contex.Entry(item).State = EntityState.Modified;
            contex.SaveChanges();
        }
        public List<Phone> GetPhones(int id)
        {
            return contex.Phones.ToList();
        }
        public Phone GetById(int id)
        {
            return contex.Phones.Where(i => i.Id == id).FirstOrDefault();
        }
        public void Delete(int id)
        {
            Phone item = contex.Phones.Where(i => i.Id == id).FirstOrDefault();
            contex.Phones.Remove(item);
            contex.SaveChanges();
        }
    }
}