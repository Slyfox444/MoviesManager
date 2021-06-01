using MoviesManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesManager.ViewModels.Phones
{
    public class IndexVM
    {
        public int Id { get; set; }

        public Contact Contact { get; set; }
        public List<Phone> Items { get; set; }
    }
}