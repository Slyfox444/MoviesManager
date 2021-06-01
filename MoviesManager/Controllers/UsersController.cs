using MoviesManager.Filter;
using MoviesManager.Entities;
using MoviesManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesManager.ViewModels.Users;

namespace MoviesManager.Controllers
{
   [AuthenticationFilter]  
    public class UsersController : Controller
    {
       
        // GET: Movies
        public ActionResult Index()
        {
            UsersRepository ur = new UsersRepository();
            List<User> users = ur.GetUsers();

            ViewData["users"] = users;

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            UsersRepository ur = new UsersRepository();
            User item = id == null ? new User() : ur.GetByID(id.Value);

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            UsersRepository ur = new UsersRepository();

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            if (item.Id == 0)
            {
                ur.Insert(item);
            }

            else
            {
                ur.Update(item);
               
            }
               

            return RedirectToAction("Index", "Users");
        }
        public ActionResult Delete(int id)
        {
            UsersRepository ur = new UsersRepository();
            ur.Delete(id);
            return RedirectToAction("Index", "Users");
        }
    }
}