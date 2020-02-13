using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Coredemo.Models;

namespace Coredemo.Controllers
{
    public class EmployController:Controller
    {
        //Interface empr = new Employr();
       private readonly Interface empr;
        public EmployController(Interface emr)
        {
            empr = emr;
        }

        //public IActionResult Search(int id)
        //{
        //    Employ emp1 = empr.GetEmploy(id);   //if we give id respective details will be printed
        //    if (emp1 != null)
        //    {
        //        return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
        //    }
        //    else
        //        return Content("employ does not exist");


        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employ emp1 = empr.GetEmploy(ID);
            //if (emp1 != null)
            //{
            //    return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
            //}
            //else
            //    return Content("employ does not exist");

            //ViewData["id"] = emp1.Id;
            //ViewData["name"] = emp1.Name;
            //ViewData["email"] = emp1.Email;
            //ViewData["dept"] = emp1.dept;
            ViewData["Employ"]=emp1;
            ViewBag.Employ = emp1;

            //ViewBag.id = emp1.Id;
            //ViewBag.name = emp1.Name;
            //ViewBag.email = emp1.Email;
            //ViewBag.dept = emp1.dept;
            return View(emp1);


        }
        public IActionResult Index()
        {
            List<Employ> elist = empr.DisplayDetails();
            return View(elist);
           
        }
        public ViewResult AboutEmploy()
        {
            Employ emp1 = empr.GetEmploy(2);
            // ViewBag.projectname = "BOOKHIVE";
            Employprojviewmodel ep = new Employprojviewmodel();
            ep.employ = emp1;
            ep.projectname = "BOOK HIVE";
            return View(ep);
        }
        public IActionResult Getallemploys()
        {
            List<Employ> elist = (empr.DisplayDetails()).Where(e => e.dept == Dept.Insurance).ToList();
            //absolute path to refer a view
            //return View("~/Views/Employ/Index.cshtml", elist);

            //realtive path
            return View("Index", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Employ emp1 = empr.GetEmploy(2);
            //return View(emp1);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employ emp)
        {
            if (ModelState.IsValid)
            {
                empr.AddEmploy(emp);
                return RedirectToAction("Index");
            }
            //else
            //    return View("Fail"); 
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employ> elist = empr.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employ employ)
        {
            bool res = empr.AddEmploy(employ);
            return RedirectToAction("Index");
        }
        public bool IsExist(string email)
        {
            var result = (empr.DisplayDetails()).Find(r => r.Email == email);
            if (result == null) return true;
            else
                return false;
        }
        [AcceptVerbs("Get","Post")]
        
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exist");
        }
        public IActionResult _myPartial()
        {
            return View();
        }
    }


}

