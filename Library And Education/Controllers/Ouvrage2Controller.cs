using Library_And_Education.Models;
using Library_And_Education.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_And_Education.Controllers
{
    public class Ouvrage2Controller : Controller
    {
        Manage_BooksEntities1 liv = new Manage_BooksEntities1();


        // GET: Ouvrage
        public ActionResult ouvrage2()
        {

            var lt = liv.Ouvrage.ToList();

            return View(lt);

        }

        [HttpPost]

        public ActionResult ouvrage2(QuantiteViewModel qu)
        {
            if (qu.Quantite != 0)
            {
                var jet = liv.Ouvrages.Where(x => x.id_ouvrage == qu.id_ouvrage).First();

                jet.Quantite = (int)qu.Quantite;

            }
            else
            {

                liv.Ouvrage.Add(new Models.Ouvrage
                {
                    Quantite = (int)qu.Quantite
                  
                });
            }


            liv.SaveChanges();
            //return RedirectToAction("reserve");
            return View(liv);
        }


    }
}