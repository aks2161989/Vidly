﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public List<Customer> customers = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "John Smith" },
                new Customer{ Id = 2, Name = "Mary Williams"}
            };
        public ActionResult Index()
        {
 
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            try
            {
                var customer = customers.First(item => item.Id == id);
                return View(customer);
            }
            catch (InvalidOperationException)
            {
                return HttpNotFound();
            }
             
        }
    }
}