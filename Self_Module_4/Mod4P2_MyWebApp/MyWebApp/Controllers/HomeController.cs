using Microsoft.AspNetCore.Mvc;

namespace MyWebApp {
    public class HomeController : Controller {
        public IActionResult Index() {
            ViewData["country"] = "United States";
            ViewData["state"] = "Washington";
            ViewData["county"] = "King";
            ViewData["city"] = "Redmond";
            return View();
        }
    }
}