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
    public class BeddingTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BeddingTypesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: BeddingTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BeddingType.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: BeddingTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beddingType = await _context.BeddingType
                .FirstOrDefaultAsync(m => m.BeddingTypeId == id);
            if (beddingType == null)
            {
                return NotFound();
            }

            return View(beddingType);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: BeddingTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BeddingTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BeddingTypeId,BeddingTypeName")] BeddingType beddingType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beddingType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(beddingType);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: BeddingTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beddingType = await _context.BeddingType.FindAsync(id);
            if (beddingType == null)
            {
                return NotFound();
            }
            return View(beddingType);
        }

        // POST: BeddingTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(EditActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BeddingTypeId,BeddingTypeName")] BeddingType beddingType)
        {
            if (id != beddingType.BeddingTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beddingType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeddingTypeExists(beddingType.BeddingTypeId))
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
            return View(beddingType);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: BeddingTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beddingType = await _context.BeddingType
                .FirstOrDefaultAsync(m => m.BeddingTypeId == id);
            if (beddingType == null)
            {
                return NotFound();
            }

            return View(beddingType);
        }

        // POST: BeddingTypes/Delete/5
        [ServiceFilter(typeof(DeleteActionFilter))]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beddingType = await _context.BeddingType.FindAsync(id);
            _context.BeddingType.Remove(beddingType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeddingTypeExists(int id)
        {
            return _context.BeddingType.Any(e => e.BeddingTypeId == id);
        }
    }
}
