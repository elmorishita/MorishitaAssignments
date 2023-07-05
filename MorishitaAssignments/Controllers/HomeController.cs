
using Microsoft.AspNetCore.Mvc;
using MorishitaAssignments.Models;
using System.Diagnostics;

namespace MorishitaAssignments.Controllers
{
    public class HomeController : Controller
    {
        public StudentContext context { get; set; }

        public HomeController(StudentContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

    }
}