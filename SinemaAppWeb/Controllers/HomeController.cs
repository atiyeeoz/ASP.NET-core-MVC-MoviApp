using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SinemaAppWeb.Data;
using SinemaAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            if (id!=null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            
            return View(MovieRepository.GetById(id));
        }
        

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "Id", "Name");
            return View();
        }

       [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.AddMovie(m);
                return RedirectToAction("index");
            }
            
            return View(m);
        }
       
    }
}
