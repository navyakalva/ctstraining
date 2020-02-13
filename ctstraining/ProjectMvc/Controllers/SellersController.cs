using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectMvc.Models;

namespace ProjectMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerContext _context;
        public readonly IWebHostEnvironment hostingEnvironment;
        public SellersController(SellerContext context,IWebHostEnvironment hostingEnvironment)
        {
            this._context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

       
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Seller seller)
        {
            var logUser = _context.Sellers.Where(e => e.Sname == seller.Sname && e.Password == seller.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "not valid user";
                return View();
            }
            else
            {
                //HttpContext.Session.SetString("Uname", user.Name);
                // HttpContext.Session.SetString("lastlogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashboard");
            }
        }
        // GET: Sellers
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Sellers.ToListAsync());
        //}

        // GET: Sellers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers
                .FirstOrDefaultAsync(m => m.Sid == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // GET: Sellers/Create
        
        [HttpGet]
        public IActionResult RegisterSeller()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterSeller(SellerCreateView model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.PhotoPath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newseller = new Seller
                {
                    Sname = model.Sname,
                    Password=model.Password,
                    PostalAddress=model.PostalAddress,
                    Email = model.Email,
                    Website=model.Website,
                    Companyname=model.Companyname,
                    Bankdetails=model.Bankdetails,

                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    PhotoPath = uniqueFileName
                };

                _context.Add(newseller);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = newseller.Sid });
            }

            return View();
        }
        // POST: Sellers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sid,Sname,Password,PostalAddress,Email,Website,Companyname,Bankdetails")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seller);
        }

        // GET: Sellers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sid,Sname,Password,PostalAddress,Email,Website,Companyname,Bankdetails")] Seller seller)
        {
            if (id != seller.Sid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellerExists(seller.Sid))
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
            return View(seller);
        }

        // GET: Sellers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers
                .FirstOrDefaultAsync(m => m.Sid == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seller = await _context.Sellers.FindAsync(id);
            _context.Sellers.Remove(seller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SellerExists(int id)
        {
            return _context.Sellers.Any(e => e.Sid == id);
        }
    }
}
