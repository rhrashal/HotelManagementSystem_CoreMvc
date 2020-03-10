using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class RoomQuantitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomQuantitiesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: RoomQuantities
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomQuantity.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: RoomQuantities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomQuantity = await _context.RoomQuantity
                .FirstOrDefaultAsync(m => m.RoomQuantityId == id);
            if (roomQuantity == null)
            {
                return NotFound();
            }

            return View(roomQuantity);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: RoomQuantities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomQuantities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomQuantityId,NumberOfRoom")] RoomQuantity roomQuantity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomQuantity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomQuantity);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: RoomQuantities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomQuantity = await _context.RoomQuantity.FindAsync(id);
            if (roomQuantity == null)
            {
                return NotFound();
            }
            return View(roomQuantity);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: RoomQuantities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomQuantityId,NumberOfRoom")] RoomQuantity roomQuantity)
        {
            if (id != roomQuantity.RoomQuantityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomQuantity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomQuantityExists(roomQuantity.RoomQuantityId))
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
            return View(roomQuantity);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: RoomQuantities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomQuantity = await _context.RoomQuantity
                .FirstOrDefaultAsync(m => m.RoomQuantityId == id);
            if (roomQuantity == null)
            {
                return NotFound();
            }

            return View(roomQuantity);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: RoomQuantities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomQuantity = await _context.RoomQuantity.FindAsync(id);
            _context.RoomQuantity.Remove(roomQuantity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomQuantityExists(int id)
        {
            return _context.RoomQuantity.Any(e => e.RoomQuantityId == id);
        }
    }
}
