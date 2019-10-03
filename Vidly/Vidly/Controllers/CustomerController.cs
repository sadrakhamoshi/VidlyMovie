using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers=CreatCustomer();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = CreatCustomer();
            if (id > 2)
                return HttpNotFound();
            else
            {
                return View(customers.Where(s=>s.Id==id));
            }
        }
        private static List<Customer> CreatCustomer()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Name="John Smith",Id=1},
                new Customer(){Name="Marry Whiilams",Id=2}
            };
            return customers;
        }
    }
}