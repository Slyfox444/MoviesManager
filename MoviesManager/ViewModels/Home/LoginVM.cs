using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesManager.ViewModels.Home
{
    public class LoginVM
    {
       // public int Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Error!")]
        public string Username { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Error!")]
        public string Password { get; set; }
    }
}