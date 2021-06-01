using MoviesManager.Repositories;
using MoviesManager.ViewModels.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesManager.Controllers
{
    public class PhonesController : Controller
    {
        // GET: Phones
        public ActionResult Index(IndexVM model)
        {
            PhonesRepository repo = new PhonesRepository();
            ContactsRepository crepo = new ContactsRepository();

            model.Contact = crepo.GetById(model.Id);
            model.Items = repo.GetPhones(model.Id);

            return View(model);
        }
    }
}