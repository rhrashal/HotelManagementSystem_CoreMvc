using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem_CoreMvc.Models;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class OrderFoodsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderFoodsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: OrderFoods
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.OrderFood.Include(o => o.Food).Include(o => o.Guest);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        public async Task<IActionResult> Index( string sortOrder,  string currentFilter,   string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var students = from s in _context.OrderFood.Include(o => o.Food).Include(o => o.Guest)
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Food.FoodName.Contains(searchString)
                                       || s.Guest.FullName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.Guest.FirstName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.Food.FoodName);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.Food.FoodName);
                    break;
                default:
                    students = students.OrderBy(s => s.Guest.FirstName);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<OrderFood>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: OrderFoods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderFood = await _context.OrderFood
                .Include(o => o.Food)
                .Include(o => o.Guest)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderFood == null)
            {
                return NotFound();
            }

            return View(orderFood);
        }
        [ServiceFilter(typeof(InsertActionFilter))]
        // GET: OrderFoods/Create
        public IActionResult Create()
        {
            ViewData["FoodId"] = new SelectList(_context.Food, "FoodId", "FoodName");
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName");
            return View();
        }

        // POST: OrderFoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ServiceFilter(typeof(InsertActionFilter))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,GuestId,FoodId,Quntity")] OrderFood orderFood)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderFood);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FoodId"] = new SelectList(_context.Food, "FoodId", "FoodName", orderFood.FoodId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", orderFood.GuestId);
            return View(orderFood);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: OrderFoods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderFood = await _context.OrderFood.FindAsync(id);
            if (orderFood == null)
            {
                return NotFound();
            }
            ViewData["FoodId"] = new SelectList(_context.Food, "FoodId", "FoodName", orderFood.FoodId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", orderFood.GuestId);
            return View(orderFood);
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // POST: OrderFoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,GuestId,FoodId,Quntity")] OrderFood orderFood)
        {
            if (id != orderFood.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderFood);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderFoodExists(orderFood.OrderId))
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
            ViewData["FoodId"] = new SelectList(_context.Food, "FoodId", "FoodName", orderFood.FoodId);
            ViewData["GuestId"] = new SelectList(_context.Guest, "GuestId", "FullName", orderFood.GuestId);
            return View(orderFood);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: OrderFoods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderFood = await _context.OrderFood
                .Include(o => o.Food)
                .Include(o => o.Guest)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderFood == null)
            {
                return NotFound();
            }

            return View(orderFood);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: OrderFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderFood = await _context.OrderFood.FindAsync(id);
            _context.OrderFood.Remove(orderFood);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderFoodExists(int id)
        {
            return _context.OrderFood.Any(e => e.OrderId == id);
        }
        [ServiceFilter(typeof(SelectActionFilter))]
        public ActionResult getRelatedGuest(string searchString, int? GuestId, int? OrderId)
        {
            var geustFoodOrder = new GeustFoodOrder();
            geustFoodOrder.Guests = _context.Guest.ToList();
            if (GuestId == null)
            {
                byte[] kkk = HttpContext.Session.Get("GuestId");
                if(kkk != null)
                {
                    string someString = Encoding.ASCII.GetString(kkk);
                    GuestId = Convert.ToInt32(someString);
                }               
            }
            if (GuestId != null)
            {
                HttpContext.Session.SetString("GuestId", GuestId.ToString());
                geustFoodOrder.OrderFoods = _context.OrderFood.Where(w => w.GuestId == GuestId.Value).ToList();
            }
            if (OrderId != null)
            {
                geustFoodOrder.Foods = _context.Food.Where(w => w.FoodId == OrderId.Value).ToList();
            }
            return View(geustFoodOrder);
        }
    }
}
