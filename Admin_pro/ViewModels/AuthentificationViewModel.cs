using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class AuthentificationViewModel
    {
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Password_cle { get; set; }

        public string Name { get; set; }
   
        public string Password { get; set; }
        public string prenom { get; set; }
    
        public string Confirmpassword { get; set; }
        public string Roles { get; set; }
        public string Photouser { get; set; }

    }
}