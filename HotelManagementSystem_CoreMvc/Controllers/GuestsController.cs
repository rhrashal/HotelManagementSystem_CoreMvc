using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using Newtonsoft.Json;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class GuestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuestsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Guests
        public async Task< IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";


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

            //*******************************
            var guestList = from s in _context.Guest select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                guestList = guestList.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper()) || s.FirstName.ToUpper().Contains(searchString.ToUpper()));
            }
            //******************************
            switch (sortOrder)
            {
                case "name_desc":
                    guestList = guestList.OrderByDescending(s => s.FirstName);
                    break;
                default:
                    guestList = guestList.OrderBy(s => s.FirstName);
                    break;
            }

            //return View(await guestList.AsNoTracking().ToListAsync());

            int pageSize = 3;
            return View(await PaginatedList<Guest>.CreateAsync(guestList.AsNoTracking(), page ?? 1, pageSize));
            //int pageSize = 6;
            //int pageNumber = (page ?? 1);
            //return View(guestList.ToPagedList(pageNumber, pageSize));

            // return View(await _context.Guest.ToListAsync());
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: Guests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guest
                .FirstOrDefaultAsync(m => m.GuestId == id);
            if (guest == null)
            {
                return NotFound();
            }

            return View(guest);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: Guests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GuestId,FirstName,LastName,Address,Email,Phone,NID_No")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guest);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: Guests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guest.FindAsync(id);
            if (guest == null)
            {
                return NotFound();
            }
            return View(guest);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: Guests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GuestId,FirstName,LastName,Address,Email,Phone,NID_No")] Guest guest)
        {
            if (id != guest.GuestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestExists(guest.GuestId))
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
            return View(guest);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: Guests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guest = await _context.Guest
                .FirstOrDefaultAsync(m => m.GuestId == id);
            if (guest == null)
            {
                return NotFound();
            }

            return View(guest);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guest = await _context.Guest.FindAsync(id);
            _context.Guest.Remove(guest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestExists(int id)
        {
            return _context.Guest.Any(e => e.GuestId == id);
        }

        [ServiceFilter(typeof(InsertActionFilter))]

        public IActionResult MultuDataInsert()
        {
            return View();
        }


        [ServiceFilter(typeof(InsertActionFilter))]
        [HttpPost]
        public JsonResult MultuDataInsert(string guestJson)
        {
            var js = new JsonSerializer();
            Guest[] guest = (Guest[])Newtonsoft.Json.JsonConvert.DeserializeObject(guestJson, typeof(Guest[]));
            try
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var v in guest)
                        {
                            v.GuestId = 0;

                            _context.Guest.Add(v);
                            _context.SaveChanges();                            
                        }
                        dbContextTransaction.Commit();
                        return Json("Data are inserted in Institute Table");
                    }
                    catch (Exception ex)
                    {
                        string ksks = ex.Message;
                        dbContextTransaction.Rollback();
                        return Json("There is a Probem arise");
                    }
                }
            }
            catch (Exception ex)
            {
                string ksks = ex.Message;
            }
            return Json("There is a Probem arise");
        }
    }
}
