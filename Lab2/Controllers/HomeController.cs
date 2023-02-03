using Lab2.DataAccesLayer;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() {
            List<About> about = await _context.abouts.ToListAsync();
            return View(about); 
        }
    }
}
