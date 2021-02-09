using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurantsProvo.Models;

namespace TopRestaurantsProvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<Restaurant> restaurantList = new List<Restaurant>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(r);
            }
            return View(restaurantList);
        }
        public IActionResult RestaurantList()
        {

            return View(TempStorage.SuggestionResponses);    
        }

        [HttpGet("RestaurantSuggestions")]
        public IActionResult RestaurantSuggestions()
        {
            return View();
        }

        [HttpPost("RestaurantSuggestions")]
        public IActionResult RestaurantSuggestions(Suggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(suggestion);
                return View("RestaurantList", TempStorage.SuggestionResponses);
            }
            return View("RestaurantSuggestions");
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
