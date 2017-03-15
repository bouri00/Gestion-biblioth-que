using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Admin_pro.Models;
using Admin_pro.ViewModels;

namespace Admin_pro.Controllers
{
    public class EtudiantController : Controller
    {


        Manage_BooksEntities bd_librairie = new Manage_BooksEntities();
      

        public ActionResult Etudiant()
        {
            var list = bd_librairie.Etudiant.ToList();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
        EtudiantViewModel model = new EtudiantViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Create(EtudiantViewModel model)
        {
            bd_librairie.Etudiant.Add(new Models.Etudiant
            {
                num_etudiant=model.num_etudiant,
                nom = model.nom,
                prenom = model.prenom,
                adresse=model.adresse,
                ville=model.ville,
                telephone=model.telephone,
                date_naissance=model.date_naissance,
                code_postal=model.code_postal

            });
            bd_librairie.SaveChanges();
            return View();
        }



        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Select()
        {
            return View();
        }

    }
}