using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAzon.Controllers
{
    [Route("Members")]
    public class MemberHomeController : Controller
    {
        // GET: /<controller>/
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Access")]
        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}
