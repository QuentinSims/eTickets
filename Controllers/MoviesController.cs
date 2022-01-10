using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        //data comes from db context
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMovies = _context.Movies
                .Include(n => n.Cinema)
                .OrderBy(n => n.Name).ToList();
            return View(allMovies);
        }
    }
}
