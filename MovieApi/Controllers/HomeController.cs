using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApi.Models;
using MovieApi.Services;
using MovieApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieApiService movieApiService;

        public HomeController(ILogger<HomeController> logger, IMovieApiService movieApiService)
        {
            _logger = logger;
            this.movieApiService = movieApiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Search(string movieTitle, int page = 1)
        {
            // ViewBag.MovieTitle = movieTitle;
            var result = await movieApiService.SearchByTitle(movieTitle, page);
            //ViewBag.TotalResults = result.TotalResults;
            //ViewBag.TotalPages = Math.Ceiling(result.TotalResults / 10.0);
            //   ViewBag.CurentPage = page;
            ViewBag.MovieTitle = result?.Movies.FirstOrDefault()?.Title;
            
            SearchViewModel searchViewModel = new SearchViewModel()
            {
                CurrentPage = page,
                Title = movieTitle,
                Movies = result.Movies,
                TotalPages = (int)Math.Ceiling(result.TotalResults / 10.0),
                TotalResults = result.TotalResults
            };
            return View(searchViewModel);
        }
        public async Task<IActionResult> Details(string id)
        {
            Details details = await movieApiService.SearchById(id);
            Console.WriteLine("Details - " + id);
            return View(details);
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
