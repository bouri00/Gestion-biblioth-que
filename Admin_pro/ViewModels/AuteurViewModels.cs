using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class AuteurViewModels
    {

        public int id_Auteur { get; set; }
        public string Nationalite { get; set; }


        public DateTime? date_deces { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
    }
}