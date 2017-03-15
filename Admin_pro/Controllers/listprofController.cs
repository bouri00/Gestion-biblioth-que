using Admin_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin_pro.Controllers
{
    public class listprofController : Controller
    {

        Manage_BooksEntities bd_prof = new Manage_BooksEntities();
        // GET: listprof
        public ActionResult listprof()
        {
            var list = bd_prof.professour.ToList();
            return View(list);
        }
    }
}