using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesManager.ViewModels.Users
{
    public class EditVM
    {
        public int Id { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Err!")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Err!")]
        public string Password { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Err!")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Err!")]
        public string LastName { get; set; }
    }
}