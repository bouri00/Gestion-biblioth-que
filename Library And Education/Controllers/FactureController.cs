﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_And_Education.Controllers
{
    public class FactureController : Controller
    {
        // GET: Facture
        public ActionResult PanierFacture()
        {
            return View();
        }
    }
}