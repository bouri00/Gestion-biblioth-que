﻿using System;
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
    public class CartTotalController : Controller
    {

        Manage_BooksEntities1 cart = new Manage_BooksEntities1();
        // GET: CartTotal
        public ActionResult Cart()
        {

            var car = cart.Commander.ToList();
            return View(car);
           
        }
    }
}