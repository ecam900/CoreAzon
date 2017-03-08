using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreAzon.Models;
using CoreAzon.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAzon.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        //[HttpGet]
        [Route("IndexWithForm")]
        public IActionResult IndexWithForm()
        {
            return View("IndexWithForm");
        }

        [Route("")]
        [Route("Index")]
        [Route("Index/{id}")]
        //[HttpPost]
        public IActionResult Index(Contact contact)
        {
            //Contact contact = new Contact()
            //{
            //    Id = 1,
            //    FirstName = "Eric",
            //    LastName = "Crescioni"
            //};

            Customer customer = new Customer()
            {
                Id = 2,
                CustomerName = "The Company"
            };

            HomeIndexViewModel vm = new HomeIndexViewModel()
            {
                Contact = contact,
                Customer = customer
            };

            return View(vm);
        }
    }
}
