using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork1.Controllers
{
    public class UserController : Controller
    {   
        [HttpGet("/User")]
        public IActionResult GetUser()
        {
            return View("User");
        }

        public IActionResult GetContact()
        {
            return RedirectToAction("Admin", "AdminController");

        }
        [HttpGet("/Empty")]
        public IActionResult GetEmpty()
        {
            return new EmptyResult();
        }

        [HttpGet("/Id/{id}")]
        public IActionResult GetId(int? id)
        {
            if (id.HasValue)
            {
                return View("Id");
            }

            return new EmptyResult();
        }
    }
}
