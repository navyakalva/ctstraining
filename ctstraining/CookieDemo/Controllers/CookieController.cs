using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CookieDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CookieDemo.Controllers
{
    public class CookieController : Controller
    {
        // GET: Cookie
        public readonly UserAccountContext _context;
        public CookieController(UserAccountContext context)
        {
            this._context = context;
        }
       // [Route(" ")]
       
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount user )
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
                ViewBag.message = user.Name + "has got successfull";
                return View("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = user.Name + "failed";
            }
            return View();
        }
        // GET: Cookie/Details/5
        [Route("Cookie")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserAccount user)
        {
            var logUser = _context.UserAccounts.Where(e => e.Name == user.Name && e.Password == user.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Uname", user.Name);
                HttpContext.Session.SetString("lastlogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashboard");
            }
        }
        public ActionResult CreateDashboard()
        {
            if (HttpContext.Session.GetString("Uname") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("Uname").ToString();
                ViewBag.lldt = HttpContext.Session.GetString("lastlogin").ToString();
            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cookie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cookie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cookie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cookie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cookie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cookie/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}