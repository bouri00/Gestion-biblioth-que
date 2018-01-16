using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_And_Education.ViewModels
{
    public class OuvrageViewModel
    {
        public int id_ouvrage { get; set; }
        public string titre { get; set; }
        public int nb_pages { get; set; }
        public int id_Editeur { get; set; }
        public int Quantite { get; set;}
        public string nom { get; set; }
        public string prenom { get; set; }
        public string nomE { get; set; }
        public string prenomE { get; set; }
        public string Type { get; set; }

        public int id_Auteur { get; set; }

        public string Photo { get; set; }
        public HttpPostedFileBase file_ouvrage { get; set; }
        public string Description { get; set; }
        public float Prix { get; set; }

        public float Total { get; set; }
        //public string NomEDIT { get; set; }
        //public string prenom { get; set; }

    }
}