using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class EtudiantViewModel
    {
       
        public int num_etudiant { get; set; }
        public string nom { get; set; }

        public string prenom { get; set; }
        public DateTime date_naissance { get; set; }
        public string telephone { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }
    }
}