using Gemark_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gemark_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Portfolio Website",
                    Description = "ASP.NET Core MVC portfolio",
                    GitHubUrl = "https://github.com/yourname",
                    ImageUrl = "/images/project1.png"
                }
            };

            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}