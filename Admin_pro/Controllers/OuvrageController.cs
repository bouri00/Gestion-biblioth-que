using Admin_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Admin_pro.ViewModels;

namespace Admin_pro.Controllers
{
    public class OuvrageController : Controller
    {
        Manage_BooksEntities liv = new Manage_BooksEntities();


        // GET: Ouvrage
        public ActionResult ouvrage()
        {
            var list = liv.Ouvrage.ToList();
            return View(list);
        }


        [HttpGet]
        public ActionResult Create()
        {
            OuvrageViewModels omod = new OuvrageViewModels();
            return View();
        }

        [HttpPost]
        public ActionResult Create(OuvrageViewModel model)
        {
            liv.Ouvrage.Add(new Models.Ouvrage
            {
                //id_ouvrage = model.id_ouvrage,
                //titre=model.titre,
                //nb_pages=model.nb_pages,
                //id_Editeur=model.id_Editeur
            });
            return View();
            liv.SaveChanges();
        }

    }
}