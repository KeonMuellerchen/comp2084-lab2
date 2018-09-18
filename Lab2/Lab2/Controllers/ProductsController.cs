using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//reference Models namespace
//using Lab2.Models;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details
        public ActionResult Details(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}