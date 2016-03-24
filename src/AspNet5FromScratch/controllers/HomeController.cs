using Microsoft.AspNet.Mvc;

namespace AspNet5FromScratch.controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}