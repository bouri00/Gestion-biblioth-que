using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class CommanderViewModel
    {
        public int quantite { get; set; }
        public int id_ouvrage { get; set; }
        public float Total { get; set; }
        public float Remise { get; set; }
        public float Prix { get; set; }
      // public float Total { get; set; }
      public int Idcom { get; set; }
        public DateTime date_envoi { get; set; }

        public string destinataire { get; set; }
        public DateTime datecommande { get; set; }
        public string ville_livraison { get; set; }

        public string pays_livraison { get; set;  }

      

    }
}