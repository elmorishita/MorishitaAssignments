
using Microsoft.AspNetCore.Mvc;
using MorishitaAssignments.Models;
using System.Diagnostics;

namespace MorishitaAssignments.Controllers
{
    public class HomeController : Controller
    {
        public StudentContext context { get; set; }

        public HomeController(StudentContext ctx) => context = ctx;

        public IActionResult Index()
        {
            ViewBag.Assignments = context.Assignments.ToList();
            return View();
        }

      

    }
}