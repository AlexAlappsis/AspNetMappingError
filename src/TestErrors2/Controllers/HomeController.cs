using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace TestErrors2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content(HttpContext.Request.PathBase);
        }
        
        public IActionResult Error()
        {
            throw new Exception();
        }
    }
}
