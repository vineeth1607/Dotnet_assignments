using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer.Models;
namespace Customer.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        NorthwindEntities db = new NorthwindEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        public ActionResult GetCountryByName()
        {
            List<Customer> catname = (from cats in db.Customers
                                      where cats.Country == "Germany"
                                      select cats).ToList();
            return View(catname);
        }





        public ActionResult GetCustomers_ById()
        {
            List<Customer> customers = (from cats in db.Customers
                                        join orders in db.Orders on cats.CustomerID equals orders.CustomerID
                                        where orders.OrderID == 10248
                                        select cats).ToList();
            return View(customers);
        }
    }
    }
}