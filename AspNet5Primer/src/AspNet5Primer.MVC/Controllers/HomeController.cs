using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5Primer.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HtmlHelperFormDemo()
        {
            return View();
        }

        public IActionResult TagHelperFormDemo()
        {
            return View();
        }
    }
}
