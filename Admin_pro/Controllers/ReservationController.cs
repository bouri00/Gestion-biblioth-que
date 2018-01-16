using Admin_pro.Models;
using Admin_pro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_pro.Controllers
{
    public class ReservationController : Controller
    {
        Manage_BooksEntities reser = new Manage_BooksEntities(); 
        // GET: Reservation
        public ActionResult reserve()
        {
            var res = reser.Reservations.ToList();
            return View(res);
        }

        [HttpGet]
        public ActionResult Create(int? id_reservation)
        {
            ReservationViewModel rem = new ReservationViewModel();
            if (id_reservation != null)
            {

                var ob= reser.Reservations.Where(x => x.id_reservation == id_reservation).First();
            
                rem.id_reservation = (int)ob.id_reservation;
                rem.quantite = (int)ob.quantite;
                rem.description = ob.description;
                rem.datereservation = (DateTime)ob.datereservation;
                rem.date_envoi = (DateTime)ob.date_envoi;


            }

            return View(rem);
        }

        [HttpPost]

        public ActionResult Create(ReservationViewModel RV)
        {
            if (RV.id_reservation != 0)
            {
                var jet = reser.Reservations.Where(x => x.id_reservation == RV.id_reservation).First();

                jet.description = RV.description;
                jet.datereservation =(DateTime) RV.datereservation;
                jet.quantite = (int)RV.quantite;
                jet.id_reservation = (int)RV.id_reservation;
                jet.date_envoi = (DateTime)RV.date_envoi;

            }
            else
            {

                reser.Reservations.Add(new Models.Reservation
                {
                    id_reservation = (int)RV.id_reservation,
                    quantite = (int)RV.quantite,
                    datereservation = (DateTime)RV.datereservation,
                    description = RV.description,
                    date_envoi=(DateTime)RV.date_envoi

                });
            }


            reser.SaveChanges();
            return RedirectToAction("reserve");
        }


        [HttpGet]
        public ActionResult Delete(int? id_reservation)
        {
            ReservationViewModel od = new ReservationViewModel();
            if (id_reservation != null)
            {

                var et = reser.Reservations.Where(x => x.id_reservation == id_reservation).First();
                od.id_reservation =(int) et.id_reservation;
            }
            return View(od);
        }
        [HttpPost]
        public ActionResult Delete(int? id_reservation, bool confi)
        {

            if (id_reservation != null)
            {

                var _modifier = reser.Reservations.Where(x => x.id_reservation == id_reservation).First();
                reser.Reservations.Remove(_modifier);
                reser.SaveChanges();


            }

            return RedirectToAction("reserve");
        }

    }
}