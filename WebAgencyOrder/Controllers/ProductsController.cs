using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAgencyOrder.Models;

namespace WebAgencyOrder.Controllers
{
    public class ProductsController : Controller
    {
        DevConn db = new DevConn();
        // GET: Products
        public ActionResult Index()
        {
            var product = db.Items.ToList();
            return View(product);
        }

        public ActionResult Layout()
        {
            return View();
        }
    }
}