using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreAzon.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAzon.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("Index")]
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            Contact contact = new Models.Contact()
            {
                id = id,
                FirstName = "Eric",
                LastName = "Crescioni"
            };

            return View(contact);
        }
    }
}
