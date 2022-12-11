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

        public ActionResult PickAgent()
        {
            var agent = db.Agencies.ToList();
            ViewBag.Agencies = agent;
            return View();
        }
        public ActionResult Payment(FormCollection frc)
        {
            List<Cart> listCart = (List<Cart>)Session["Cart"];
            int sumTotalPrice = (int)listCart.Sum(s => s.Quantity * s.Product.ItemsPrice);
            int sumTotalQuantity = listCart.Sum(s => s.Quantity);

            int totalPrice = sumTotalPrice;
            int totalQuantity = sumTotalQuantity;
            DateTime date = DateTime.Now;
            String agentID = frc["AgentName"];

            OrderReceipt orderReceipt = new OrderReceipt()
            {
                TotalOrderPrice = totalPrice,
                TotalOrderQuantity = totalQuantity,
                OrderedDate = date,
                Status = "Timming",
                AgentID = agentID,

            };

            db.OrderReceipts.Add(orderReceipt);
            db.SaveChanges();

            int length = listCart.Count;
            for(int i = 0; i < length; i++)
            {
                OrderProduct orderPro = new OrderProduct()
                {
                    OrderID = orderReceipt.OrderID,
                    ItemsID = listCart[i].Product.ItemsID,
                    TotalProductQuantity = listCart[i].Quantity,
                    TotalProductPrice = listCart[i].Product.ItemsPrice* listCart[i].Quantity,

                };db.OrderProducts.Add(orderPro); db.SaveChanges();
            }
            Session.Remove("Cart");

            return RedirectToAction("Order");
        }

        public ActionResult Order()
        {
            var order = db.OrderReceipts.ToList();
            ViewBag.Agencies = db.Agencies.ToList();
            return View(order);
        }

        public ActionResult OrderDetail(int id)
        {
            var detail = db.OrderProducts.Where(i => i.OrderID == id);
            var orderDetail = detail.ToList();
            return View(orderDetail);
        }


    }
}