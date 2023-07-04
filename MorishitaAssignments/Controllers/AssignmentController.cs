using Microsoft.AspNetCore.Mvc;
using MorishitaAssignments.Models;

namespace MorishitaAssignments.Controllers
{
    public class AssignmentController : Controller
    {
        public StudentContext context { get; set; }

        public AssignmentController(StudentContext ctx) => context = ctx;

        

        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.AssignmentIds = context.Assignments.ToList();
            Assignments assignments = context.Assignments.Where(a => a.AssignmentId == id).FirstOrDefault() ?? new Assignments();
            return View(assignments);
        }
    }
}
