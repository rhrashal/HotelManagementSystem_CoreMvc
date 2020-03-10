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
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Booking.Include(b => b.Adult).Include(b => b.BeddingType).Include(b => b.Child).Include(b => b.RoomQuantity).Include(b => b.RoomType);
            return View(await applicationDbContext.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Adult)
                .Include(b => b.BeddingType)
                .Include(b => b.Child)
                .Include(b => b.RoomQuantity)
                .Include(b => b.RoomType)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }
        //[ServiceFilter(typeof(InsertActionFilter))]
        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults");
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName");
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild");
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom");
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,FirstName,LastName,Address,Email,Phone,NID_No,ArrivalTime,DepartureDate,AdultId,ChildId,RoomTypeId,BeddingTypeId,RoomQuantityId,Notes")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index),"Home");
            }
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", booking.AdultId);
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", booking.BeddingTypeId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", booking.ChildId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", booking.RoomQuantityId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", booking.RoomTypeId);
            return View(booking);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", booking.AdultId);
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", booking.BeddingTypeId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", booking.ChildId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", booking.RoomQuantityId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", booking.RoomTypeId);
            return View(booking);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: Bookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,FirstName,LastName,Address,Email,Phone,NID_No,ArrivalTime,DepartureDate,AdultId,ChildId,RoomTypeId,BeddingTypeId,RoomQuantityId,Notes")] Booking booking)
        {
            if (id != booking.BookingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
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
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", booking.AdultId);
            ViewData["BeddingTypeId"] = new SelectList(_context.BeddingType, "BeddingTypeId", "BeddingTypeName", booking.BeddingTypeId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", booking.ChildId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", booking.RoomQuantityId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomType, "RoomTypeId", "RoomTypeName", booking.RoomTypeId);
            return View(booking);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Adult)
                .Include(b => b.BeddingType)
                .Include(b => b.Child)
                .Include(b => b.RoomQuantity)
                .Include(b => b.RoomType)
                .FirstOrDefaultAsync(m => m.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Booking.FindAsync(id);
            _context.Booking.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Booking.Any(e => e.BookingId == id);
        }
    }
}
