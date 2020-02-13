using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsonMVC.Models;
using HandsonMVC.Repsitories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsonMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { "","India", "China", "USA" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            Userrep rep = new Userrep();
            rep.Add(item);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");//add model data to table
            }
            else
                return View();
           

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string password)
        {
            Userrep rep = new Userrep();
            User user = rep.Validate(uname, password);
            if (user != null)
            {
                return RedirectToAction("Details");
            }
            else
            {
                ViewData["err"] = "Invalid Credential";
                return View();
            }
           

            
        }
        public IActionResult Details([Bind(include:"Name")]User item)
        {
            return View(item);
        }
    }
}