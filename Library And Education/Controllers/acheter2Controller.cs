using Library_And_Education.Models;
using Library_And_Education.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_And_Education.Controllers
{
    public class acheter2Controller : Controller
    {
        // GET: acheter2
        Manage_BooksEntities1 co = new Manage_BooksEntities1();
       

        public ActionResult acheter2(int? id_ouvrage)
        {

            OuvrageViewModel com = new OuvrageViewModel();


            var acheter = co.Ouvrage.Where(x => x.id_ouvrage == id_ouvrage).FirstOrDefault();


            Session["Prix"] = acheter.Prix.ToString();
            Session["Total"] = acheter.Total.ToString();
            Session["Quantite"] = acheter.Quantite.ToString();
            Session["titre"] = acheter.titre;
            Session["Photo"] = acheter.Photo;


            return View(acheter);
            //var pp = co.Commander.ToList();
            //return View(pp);


        }
    }
}