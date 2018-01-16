using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class InfoUsersViewModel
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Prenom { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
            public string Password { get; set; }
        public string Telephone { get; set; }
        public string Adreese { get; set; }
        public string Photo { get; set; }


    }
}