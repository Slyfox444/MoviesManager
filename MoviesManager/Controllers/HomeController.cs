using MoviesManager.Repositories;
using MoviesManager.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesManager.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        //логин

        [HttpGet]
        public ActionResult Login()
        {
            LoginVM model = new LoginVM();
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);


            //данните на потребителя

            UsersRepository rep = new UsersRepository();
            Session["loggedUser"] = rep.GetByUsernameAndPassword(model.Username, model.Password);

            if (Session["loggedUser"] == null)
                ModelState.AddModelError("AuthFailed", "FAILED");

            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction("Index", "Home");


        }

        //при изход
        public ActionResult Logout()
        {
            Session["loggedUser"] = null;

                return RedirectToAction("Index", "Home");

        }
       
    }
}