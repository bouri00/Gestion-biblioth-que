using Library_And_Education.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Library_And_Education.Controllers
{
    public class ConnexionController : Controller
    {
        Manage_BooksEntities1 lip = new Manage_BooksEntities1();
        // GET: Panier

           


        public ActionResult Add2()
        {

            //CommanderViewModel com = new CommanderViewModel();


            //var PA = lip.Ouvrage.Where(x => x.id_ouvrage == id_ouvrage).First();
            //var lis = lip.Commander.ToList();

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





        // GET: Connexion
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
                    if(mk != null)
                    {
                        Session["UserId"] = mk.User_Name.ToString();
                        Session["Password"] = mk.Password_cle.ToString();

                        return RedirectToAction("Add2");

                    }
                    //ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(log);
        }
        public ActionResult PanierCommande()
        {
            
            if(Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                RedirectToAction("login");
            }
            return View();
        }
        //crete compte  get
     
        //public ActionResult compte()
        //{


        //    return View();
        //}
        ////create compte post
        //[HttpPost]
        //[ValidateAntiForgeryToken]


        //public ActionResult compte(InfoUsers us)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (Manage_BooksEntities1 cp = new Manage_BooksEntities1())
        //        {
        //            cp.InfoUsers.Add(us);
        //            cp.SaveChanges();

        //            ViewBag.Message = "Cette Compte est Bien Cree";
        //            RedirectToAction("login");
        //        }
        //    }

        //    return View("login");
        //}



        [HttpGet]
        public ActionResult compte()
        {


            return View();
        }


        //create compte post
        [HttpPost]
        [ValidateAntiForgeryToken]


        public ActionResult compte(Authentifications ath)
        {
            var response = Request["g-recaptcha-response"];
            string secretKey = "your secret key here";
            var client = new WebClient();
            var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
            var obj = JObject.Parse(result);
            var status = (bool)obj.SelectToken("success");
            ViewBag.Message = status ? "Google reCaptcha validation success" : "Google reCaptcha validation failed";


            if (ModelState.IsValid)
            {
                using (Manage_BooksEntities1 ml= new Manage_BooksEntities1())
                {
                    ml.Authentifications.Add(ath);
                   ml.SaveChanges();

                    ViewBag.Message = "Cette Compte est Bien Cree";
                    RedirectToAction("login");
                }
            }

            return View("login");
        }




        //public ActionResult CreateNouveauCompte()
        //{
        //    return View();
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public ActionResult CreateNouveauCompte(InfoUsers cr)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        using (Manage_BooksEntities1 compte = new Manage_BooksEntities1())
        //        {
        //            compte.InfoUsers.Add(cr);
        //            compte.SaveChanges();
        //            ModelState.Clear();
        //            cr = null;
        //            ViewBag.Message = "Cette Compte est Bien Cree";
        //            RedirectToAction("login");
        //        }
        //        }
        //    return View();
        //}
    }
}