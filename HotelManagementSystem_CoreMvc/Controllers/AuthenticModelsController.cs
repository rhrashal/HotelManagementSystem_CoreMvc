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
    public class AuthenticModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthenticModelsController(ApplicationDbContext context)
        {
            _context = context;
        }
        //[ServiceFilter(typeof(SelectActionFilter))]
        // GET: AuthenticModels
        public IActionResult Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            List<AuthenticModel> AuthenticModelList = new List<AuthenticModel>();

            foreach(AuthenticModel am in _context.AuthenticModel.ToList())
            {
                am.Role = new ApplicationRole()
                {
                    Id = am.RoleId,
                    Name = _context.Roles.Where(w => w.Id == am.RoleId).FirstOrDefault().Name
                };
                AuthenticModelList.Add(am);
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                AuthenticModelList = AuthenticModelList.Where(s => s.ControllerName.Contains(searchString)).ToList();
            }
            return View( AuthenticModelList.ToList());
        }


        [ServiceFilter(typeof(SelectActionFilter))]
        // GET: AuthenticModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authenticModel = await _context.AuthenticModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authenticModel == null)
            {
                return NotFound();
            }

            return View(authenticModel);
        }


        //[ServiceFilter(typeof(InsertActionFilter))]
        // GET: AuthenticModels/Create
        public IActionResult Create()
        {
           
            ViewData["RollList"] = _context.Roles.ToList();
            return View();
            
        }

        // POST: AuthenticModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[ServiceFilter(typeof(InsertActionFilter))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleId,ControllerName,Retrive,Insert,Update,Delete")] AuthenticModel authenticModel)
        {
            if (ModelState.IsValid)
            {
                var authentic = await _context.AuthenticModel.FirstOrDefaultAsync(m => m.RoleId == authenticModel.RoleId && m.ControllerName == authenticModel.ControllerName);

                if (authentic == null)
                {
                    _context.Add(authenticModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
              
            }
            return RedirectToAction(nameof(Create));
        }
        [ServiceFilter(typeof(EditActionFilter))]
        // GET: AuthenticModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authenticModel = await _context.AuthenticModel.FindAsync(id);
            var roleId = authenticModel.RoleId;
            var RoleModel = await _context.Roles.FindAsync(roleId);
            ViewData["RollModel"] = RoleModel.Name;
            if (authenticModel == null)
            {
                return NotFound();
            }
            return View(authenticModel);
        }

        // POST: AuthenticModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ServiceFilter(typeof(EditActionFilter))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleId,ControllerName,Retrive,Insert,Update,Delete")] AuthenticModel authenticModel)
        {
            if (id != authenticModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authenticModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthenticModelExists(authenticModel.Id))
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
            return View(authenticModel);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // GET: AuthenticModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authenticModel = await _context.AuthenticModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authenticModel == null)
            {
                return NotFound();
            }

            return View(authenticModel);
        }
        [ServiceFilter(typeof(DeleteActionFilter))]
        // POST: AuthenticModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authenticModel = await _context.AuthenticModel.FindAsync(id);
            _context.AuthenticModel.Remove(authenticModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthenticModelExists(int id)
        {
            return _context.AuthenticModel.Any(e => e.Id == id);
        }
    }
}
