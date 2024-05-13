using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Front_To_Back.Data;
using MVC_Front_To_Back.Models;
using MVC_Front_To_Back.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //List<Car> cars = await _context.Cars.ToListAsync();
            List<Slider>sliders=await _context.Sliders.ToListAsync();
            List<Photo> photos = await _context.Photos.ToListAsync();
            HomeVM model = new()
            {
                
                Sliders = sliders,
                Photos = photos
            };
            return View(model);
        }
    }
}
