using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAgencyOrder.Models;

namespace WebAgencyOrder.Controllers
{
    public class ShoppingCartController : Controller
    {
        DevConn db = new DevConn();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var agency = db.Agencies.ToList();
            if(agency != null)
            {
                ViewBag.Agencies = agency;
            }
            return View();
        }

        public ActionResult OrderNow(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            if (Session["Cart"] == null)
            {
                List<Cart> listCart = new List<Cart>
                {
                    new Cart(db.Items.Find(id),1)
                };
                Session["Cart"] = listCart;

            }

            else
            {
                List<Cart> listCart = (List<Cart>)Session["Cart"];
                if(ExistedCheck(id) == -1)
                {
                    listCart.Add(new Cart(db.Items.Find(id), 1));
                }
                else
                {
                    listCart[ExistedCheck(id)].Quantity++;
                }
                Session["Cart"] = listCart;
            }
            return RedirectToAction("Index");
        }

        private int ExistedCheck(string id)
        {
            List<Cart> listCart = (List<Cart>)Session["Cart"];
            for(int i = 0; i < listCart.Count; i++)
            {
                if (listCart[i].Product.ItemsID == id) return i;
            }

            return -1;
        }

        public ActionResult Delete(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            List<Cart> listCart = (List<Cart>)Session["Cart"];
            listCart.RemoveAt(ExistedCheck(id));
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCart(FormCollection frc)
        {
            string[] quantities = frc.GetValues("quantity");
            List<Cart> listCart = (List<Cart>)Session["Cart"];
            for(int i = 0; i < listCart.Count; i++)
            {
                listCart[i].Quantity = Convert.ToInt32(quantities[i]);
            }
            Session["Cart"] = listCart;
            return RedirectToAction("Index");
        }
    }
}