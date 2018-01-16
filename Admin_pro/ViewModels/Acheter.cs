using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class Acheter
    {
        public int id_ouvrage { get; set; }

        public int quantite { get; set; }

        public float Prix { get; set; }

        public int Num_commande { get; set; }

        public float remise { get; set; }

    }
}