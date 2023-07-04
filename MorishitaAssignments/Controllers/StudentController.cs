using Microsoft.AspNetCore.Mvc;

namespace MorishitaAssignments.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
