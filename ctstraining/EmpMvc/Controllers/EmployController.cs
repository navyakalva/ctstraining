using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmpMvc.Controllers
{
    public class EmployController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}