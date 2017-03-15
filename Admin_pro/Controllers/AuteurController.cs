using Admin_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_pro.Controllers
{
    public class AuteurController : Controller
    {
        Models.Manage_BooksEntities bd_auteur = new Manage_BooksEntities();
        // GET: Auteur
        public ActionResult Auteur()
        {
            var list = bd_auteur.Auteur.ToList();
            return View(list);
        }
    }
}