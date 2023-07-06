using Microsoft.AspNetCore.Mvc;
using MorishitaAssignments.Models;

namespace MorishitaAssignments.Controllers
{
    public class StudentController : Controller
    {
        public StudentContext context { get; set; }

        public StudentController(StudentContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Students()
        {
            ViewBag.Access = 9; // This determines the students routing access
            var student = context.Students.OrderBy(s => s.Id).ToList();
            return View(student);
        }
    }
}
