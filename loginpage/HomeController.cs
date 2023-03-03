using Microsoft.AspNetCore.Mvc;

namespace loginpage
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
