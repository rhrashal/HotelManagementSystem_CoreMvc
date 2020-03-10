using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagementSystem_CoreMvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult About()
        {
            var applicationDbContext = _context.Room.Include(r => r.BeddingType).Include(r => r.RoomType);
            return View(applicationDbContext.ToList());        
        }
        public IActionResult Food()
        {
            return View(_context.Food.ToList());

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
