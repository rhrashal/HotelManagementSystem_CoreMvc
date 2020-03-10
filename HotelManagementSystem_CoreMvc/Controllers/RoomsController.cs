using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class RoomsController : Controller
    {
        private readonly ApplicationDbContext _context;
        IHostingEnvironment _env;
        public RoomsController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }

        // GET: Rooms

        [ServiceFilter(typeof(SelectActionFilter))]
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Room.Include(r => r.BeddingType).Include(r => r.RoomType);
            return View(await applicationDbContext.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.BeddingType)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        [ServiceFilter(typeof(InsertActionFilter))]
        public IActionResult Create()
        {
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName");
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(InsertActionFilter))]
        public async Task<IActionResult> Create([Bind("RoomId,RoomTypeName,RoomTypeId,BeddingTypeId,ImageUrl,Price")] Room room, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                using (var strem = new FileStream(_env.WebRootPath + "\\images\\Room\\" + formFile.FileName, FileMode.Create))
                {
                    formFile.CopyTo(strem);
                }
                room.ImageUrl = "~/images/Room/" + formFile.FileName;

                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", room.BeddingTypeId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", room.RoomTypeId);
            return View(room);
        }

        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", room.BeddingTypeId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", room.RoomTypeId);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(EditActionFilter))]
        public async Task<IActionResult> Edit(int id, [Bind("RoomId,RoomTypeName,RoomTypeId,BeddingTypeId,ImageUrl,Price")] Room room, IFormFile formFile)
        {
            if (id != room.RoomId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (formFile != null)
                    {
                        using (var strem = new FileStream(_env.WebRootPath + "\\images\\Room\\" + formFile.FileName, FileMode.Create))
                        {
                            formFile.CopyTo(strem);
                        }
                        room.ImageUrl = "~/images/Room/" + formFile.FileName;
                    }

                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.RoomId))
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
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", room.BeddingTypeId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", room.RoomTypeId);
            return View(room);
        }

        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.BeddingType)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(DeleteActionFilter))]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.RoomId == id);
        }
    }
}
