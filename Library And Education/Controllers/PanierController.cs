using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;
using System.Data.Entity.Validation;
using Library_And_Education.Models;
using Library_And_Education.ViewModels;

namespace Library_And_Education.Controllers
{
    public class PanierController : Controller
    {
        Manage_BooksEntities1 lipanier = new Manage_BooksEntities1();
        // GET: Panier
        public ActionResult Add()
        {
            var listpan = lipanier.Commander.ToList();


            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                RedirectToAction("login");
            }
            return View(listpan);
        }



        public ActionResult Addx()
        {


            var listpan = lipanier.Commander.ToList();


            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                RedirectToAction("login");
            }
            return View(listpan);
        }
    }
}