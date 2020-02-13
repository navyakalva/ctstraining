﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpMvc.Data;
using EmpMvc.Models;

namespace EmpMvc.Controllers
{
    public class EmploysController : Controller
    {
        private readonly EmpMvcContext _context;

        public EmploysController(EmpMvcContext context)
        {
            _context = context;
        }

        // GET: Employs
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Employ.ToListAsync());
        //}

        public IActionResult Index()
        {
            return View(_context.Employ.ToList());
        }
        // GET: Employs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employ == null)
            {
                return NotFound();
            }

            return View(employ);
        }

        // GET: Employs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Dept")] Employ employ)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employ);
        }

        // GET: Employs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employ.FindAsync(id);
            if (employ == null)
            {
                return NotFound();
            }
            return View(employ);
        }

        // POST: Employs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Dept")] Employ employ)
        {
            if (id != employ.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployExists(employ.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employ);
        }

        // GET: Employs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employ = await _context.Employ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employ == null)
            {
                return NotFound();
            }

            return View(employ);
        }

        // POST: Employs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employ = await _context.Employ.FindAsync(id);
            _context.Employ.Remove(employ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployExists(int id)
        {
            return _context.Employ.Any(e => e.Id == id);
        }
    }
}
