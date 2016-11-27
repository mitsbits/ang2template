using Microsoft.AspNetCore.Mvc;

namespace CoreMvcAngular.Controllers
{
    public class HomeController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}