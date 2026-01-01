using Microsoft.AspNetCore.Mvc;

namespace Gemark_Portfolio.Models
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
