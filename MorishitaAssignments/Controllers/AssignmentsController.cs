﻿using Microsoft.AspNetCore.Mvc;
using MorishitaAssignments.Models;


namespace MorishitaAssignments.Controllers
{
    public class AssignmentsController : Controller
    {
        public StudentContext context { get; set; }

        public AssignmentsController(StudentContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Assignments()
        {
            var assign = context.Assigns.OrderBy(r => r.AssignmentId).ToList();
            return View(assign);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            //ViewBag.AssignmentIds = context.Assigns.ToList();
            Assignments assignments = context.Assigns.Where(a => a.AssignmentId == id).FirstOrDefault() ?? new Assignments();
            return View(assignments);
        }
    }
}
