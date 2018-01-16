using Library_And_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_And_Education.Controllers
{
    public class Authentifier2Controller : Controller
    {
        // GET: Authentifier
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult login(Authentifications log)
        {
            if (ModelState.IsValid)
            {
                using (Manage_BooksEntities1 con = new Manage_BooksEntities1())
                {
                    var mk = con.Authentifications.Where(a => a.User_Name.Equals(log.User_Name) && a.Password_cle.Equals(log.Password_cle)).FirstOrDefault();
                    if (mk != null)
                    {
                        Session["UserId"] = mk.User_Name.ToString();
                        Session["Password"] = mk.Password_cle.ToString();

                        return RedirectToAction("list");

                    }
                    //ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(log);
        }

        public ActionResult list()
        {
            //if (Session["UserId"] != null)
            //{
            //    return View();
            //}
            //else
            //{
            //    RedirectToAction("login");
            //}
            return View();
        }
    }
}