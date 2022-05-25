using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Ex3Controller : Controller
    {
        List<ShoppingCart> l1 = new List<ShoppingCart>() {new ShoppingCart("CA1","Shoe",3000,"Sport"),
                                                          new ShoppingCart("CA2", "Shirt", 1500, "Men's Wear"),
                                                          new ShoppingCart("CA3","Watch",4000,"Accessories"),
                                                          new ShoppingCart("CA4","Samsung",15000,"Mobiles")};
        // GET: Ex3
        public ActionResult Cart(int id)
        {
            return View("Cart",l1[id-1]);
        }

        [HttpPost]
        public ActionResult Cart(ShoppingCart shoppingCart)
        {
            return View(shoppingCart);
        }
    }
}