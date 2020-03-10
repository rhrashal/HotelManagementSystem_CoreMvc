using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class FoodsController : Controller
    {
        private readonly ApplicationDbContext _context;
        IHostingEnvironment _env;
        public FoodsController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Foods
        public async Task<IActionResult> Index()
        {
            return View(await _context.Food.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food
                .FirstOrDefaultAsync(m => m.FoodId == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: Foods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Foods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodId,FoodName,ImageUrl,Price")] Food food, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (var strem = new FileStream(_env.WebRootPath + "\\images\\Food\\" + formFile.FileName, FileMode.Create))
                    {
                         formFile.CopyTo(strem);
                    }
                    food.ImageUrl = "~/images/Food/" + formFile.FileName;
                 
                    _context.Add(food);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    var aa = ex.Message;
                    return View();
                }


            }
            return View(food);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: Foods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FoodId,FoodName,ImageUrl,Price")] Food food, IFormFile formFile)
        {
            if (id != food.FoodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (formFile != null)
                    {
                        using (var strem = new FileStream(_env.WebRootPath + "\\images\\Food\\" + formFile.FileName, FileMode.Create))
                        {
                            formFile.CopyTo(strem);
                        }
                        food.ImageUrl = "~/images/Food/" + formFile.FileName;
                    }

                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.FoodId))
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
            return View(food);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food
                .FirstOrDefaultAsync(m => m.FoodId == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Food.FindAsync(id);
            _context.Food.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodExists(int id)
        {
            return _context.Food.Any(e => e.FoodId == id);
        }
    }
}
