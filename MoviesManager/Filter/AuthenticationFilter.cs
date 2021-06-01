using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//базова филтрация на ниво аутх. 

namespace MoviesManager.Filter
{
    public class AuthenticationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["loggedUser"] == null)
                filterContext.Result = new RedirectResult("/Home/Login");
        }
    }
}