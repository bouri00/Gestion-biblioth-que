using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_pro.ViewModels
{
    public class ReservationViewModel
    {
        public int id_reservation { get; set; }

        public int quantite { get; set; }

        public string description { get; set; }
        public DateTime datereservation { get; set; }
        public int id_ouvrage { get; set; }
        public DateTime date_envoi { get; set; }
    }
}