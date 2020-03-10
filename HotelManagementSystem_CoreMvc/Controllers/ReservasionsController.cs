using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class ReservasionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservasionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Reservasions
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            //***For paging************
            ViewBag.CurrentSort = sortOrder;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            //*****************

            var reservasions = from s in _context.Reservasion.Include(r => r.Adult).Include(r => r.Child).Include(r => r.Guest).Include(r => r.Room).Include(r => r.RoomQuantity) select s;

            //***for search ****************
            if (!String.IsNullOrEmpty(searchString))
            {
                reservasions = reservasions.Where(s => s.Guest.FirstName.ToUpper().Contains(searchString.ToUpper())
                ||
                s.Guest.LastName.ToUpper().Contains(searchString.ToUpper()));
            }
            //************

            switch (sortOrder)
            {
                case "name_desc":
                    reservasions = reservasions.OrderByDescending(s => s.Guest.FirstName);
                    break;
                case "Date":
                    reservasions = reservasions.OrderBy(s => s.DepartureDate);
                    break;
                case "date_desc":
                    reservasions = reservasions.OrderByDescending(s => s.DepartureDate);
                    break;
                default:
                    reservasions = reservasions.OrderBy(s => s.Guest.FirstName);
                    break;
            }

 

            int pageSize = 3;
            return View(await PaginatedList<Reservasion>.CreateAsync(reservasions.AsNoTracking(), page ?? 1, pageSize));

           
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Reservasions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasion = await _context.Reservasion
                .Include(r => r.Adult)
                .Include(r => r.Child)
                .Include(r => r.Guest)
                .Include(r => r.Room)
                .Include(r => r.RoomQuantity)
                .FirstOrDefaultAsync(m => m.ReservasionId == id);
            if (reservasion == null)
            {
                return NotFound();
            }

            return View(reservasion);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: Reservasions/Create
        public IActionResult Create()
        {
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults");
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild");
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName");
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomTypeName");
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom");
            return View();
        }

        // POST: Reservasions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservasionId,GuestId,RoomId,AdultId,ChildId,RoomQuantityId,ArrivalTime,DepartureDate")] Reservasion reservasion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservasion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", reservasion.AdultId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", reservasion.ChildId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", reservasion.GuestId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomTypeName", reservasion.RoomId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", reservasion.RoomQuantityId);
            return View(reservasion);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Reservasions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasion = await _context.Reservasion.FindAsync(id);
            if (reservasion == null)
            {
                return NotFound();
            }
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", reservasion.AdultId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", reservasion.ChildId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", reservasion.GuestId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomTypeName", reservasion.RoomId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", reservasion.RoomQuantityId);
            return View(reservasion);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: Reservasions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservasionId,GuestId,RoomId,AdultId,ChildId,RoomQuantityId,ArrivalTime,DepartureDate")] Reservasion reservasion)
        {
            if (id != reservasion.ReservasionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservasion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasionExists(reservasion.ReservasionId))
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
            ViewData["AdultId"] = new SelectList(_context.Adult, "AdultId", "NumberOfAdults", reservasion.AdultId);
            ViewData["ChildId"] = new SelectList(_context.Child, "ChildId", "NumberOfChild", reservasion.ChildId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", reservasion.GuestId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomTypeName", reservasion.RoomId);
            ViewData["RoomQuantityId"] = new SelectList(_context.RoomQuantity, "RoomQuantityId", "NumberOfRoom", reservasion.RoomQuantityId);
            return View(reservasion);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Reservasions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasion = await _context.Reservasion
                .Include(r => r.Adult)
                .Include(r => r.Child)
                .Include(r => r.Guest)
                .Include(r => r.Room)
                .Include(r => r.RoomQuantity)
                .FirstOrDefaultAsync(m => m.ReservasionId == id);
            if (reservasion == null)
            {
                return NotFound();
            }

            return View(reservasion);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: Reservasions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservasion = await _context.Reservasion.FindAsync(id);
            _context.Reservasion.Remove(reservasion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasionExists(int id)
        {
            return _context.Reservasion.Any(e => e.ReservasionId == id);
        }

        [ServiceFilter(typeof(SelectActionFilter))]
        public ActionResult getRelatedGuestReserve(int? GuestId, int? OrderId)
        {
            var GeustReserveRoom = new GeustReserveRoom();
            GeustReserveRoom.Guests = _context.Guest.ToList();

            if (GuestId == null)
            {
                byte[] kkk = HttpContext.Session.Get("GuestId");
                if (kkk != null)
                {
                    string someString = Encoding.ASCII.GetString(kkk);
                    GuestId = Convert.ToInt32(someString);
                }
            }

            if (GuestId != null)
            {

                HttpContext.Session.SetString("GuestId", GuestId.ToString());
                GeustReserveRoom.Reservations = _context.Reservasion.Where(w => w.GuestId == GuestId.Value).ToList();


            }

            if (OrderId != null)
            {

                GeustReserveRoom.Rooms = _context.Room.Where(w => w.RoomId == OrderId.Value).ToList();

            }

            return View(GeustReserveRoom);
        }
    }
}
