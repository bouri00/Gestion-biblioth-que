using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_And_Education.ViewModel
{
    public class CommanderViewModel
    {
        public int quantite { get; set; }
        public int id_ouvrage { get; set; }
        public float Total { get; set; }
        public float Remise { get; set; }
        public float Prix { get; set; }
        // public float Total { get; set; }

        public int Num_commande { get; set; }
        public int Idcom { get; set; }
    }
}