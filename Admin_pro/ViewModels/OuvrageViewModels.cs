using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class OuvrageViewModels
    {
        public int id_ouvrage { get; set; }
        public string titre { get; set; }
        public int nb_pages { get; set; }
        public string id_Editeur { get; set; }

    }
}