using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class AdultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Adults
        [ServiceFilter(typeof(SelectActionFilter))]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adult.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Adults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adult = await _context.Adult
                .FirstOrDefaultAsync(m => m.AdultId == id);
            if (adult == null)
            {
                return NotFound();
            }

            return View(adult);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: Adults/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(InsertActionFilter))]
        public async Task<IActionResult> Create([Bind("AdultId,NumberOfAdults")] Adult adult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adult);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Adults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adult = await _context.Adult.FindAsync(id);
            if (adult == null)
            {
                return NotFound();
            }
            return View(adult);
        }

        // POST: Adults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(EditActionFilter))]
        public async Task<IActionResult> Edit(int id, [Bind("AdultId,NumberOfAdults")] Adult adult)
        {
            if (id != adult.AdultId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdultExists(adult.AdultId))
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
            return View(adult);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Adults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adult = await _context.Adult
                .FirstOrDefaultAsync(m => m.AdultId == id);
            if (adult == null)
            {
                return NotFound();
            }

            return View(adult);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: Adults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adult = await _context.Adult.FindAsync(id);
            _context.Adult.Remove(adult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdultExists(int id)
        {
            return _context.Adult.Any(e => e.AdultId == id);
        }
    }
}
