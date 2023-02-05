using Lab2.DataAccesLayer;
using Lab2.Models;
using Lab2.ViewModels;
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
            List<Home> homes = await _context.homes.ToListAsync();
            List<About> abouts = await _context.abouts.ToListAsync();
            List<Counts> counts = await _context.counts.ToListAsync();
            List<Courses> courses = await _context.courses.ToListAsync();
            List<Events> events = await _context.events.ToListAsync();
            List<Features> features = await _context.features.ToListAsync();
            List<Images> images = await _context.images.ToListAsync();
            List<Pricing> pricings = await _context.pricings.ToListAsync();
            List<Trainers> trainers = await _context.trainers.ToListAsync();
            List<WhyUs> whyUs = await _context.whyUs.ToListAsync();
            List<WhyUsBoxes> whyUsBoxes = await _context.whyUsBoxes.ToListAsync();

            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
            {
                home = homes,
                about= abouts,
                counts= counts,
                courses=courses,
                events= events,
                features= features,
                images= images,
                pricing= pricings,
                trainers= trainers,
                whyUs= whyUs,
                whyUsBoxes= whyUsBoxes
            };
            return View(homeIndexViewModel); 
        }
    }
}
