using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;
using System.Data.Entity.Validation;
using Library_And_Education.Models;
using Library_And_Education;
using Library_And_Education.ViewModels;

namespace Library_And_Education.Controllers
{
    public class AcheterController : Controller
    {
        Manage_BooksEntities1 co = new Manage_BooksEntities1();
        // GET: Acheter

        public ActionResult Acheter_Ouvrage(int? id_ouvrage)
        {
           
          OuvrageViewModel com = new OuvrageViewModel();

      
            var acheter = co.Ouvrage.Where(x => x.id_ouvrage == id_ouvrage).FirstOrDefault();
            return View(acheter);

          
        }





        }
}