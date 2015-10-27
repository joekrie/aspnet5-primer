using Microsoft.AspNet.Mvc;

namespace AspNet5Primer.SPA.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
