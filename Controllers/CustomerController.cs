using MVCAppDemoWithAuthtentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCAppDemoWithAuthtentication.ViewModel;
using Microsoft.Owin.Security.Provider;

namespace MVCAppDemoWithAuthtentication.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.memberShipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(c => c.memberShipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
            
                return HttpNotFound();
                return View(singleCustomer);
            
        }

        private void SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
        public ActionResult Create()
        {
            var memberShipType = _context.MemberShipTypes.ToList();
            var viewMod = new NewCustomerViewModel
            {
                MemberShipTypes =  memberShipType
            };
             return View(viewMod);
           
        }
        [HttpPost]

        public ActionResult Create(Customer Customers)//Model Binding
        {
            _context.Customers.Add(Customers);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");

        }
      
      
            
      
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}