using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurantsProvo.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty";
        [Required]
        public string Address { get; set; }
        public string? RestaurantPhone { get; set; } = "No number listed";
        public string? WebsiteLink { get; set; } = "Coming soon";

        //List of Restaurants (top 5)
        public static Restaurant[] GetRestaurants()
        { 
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "BYU Creamery on Ninth",
                FavoriteDish = "Kids' Meal",
                Address = "1209 900 E, Provo, UT 84604",
                RestaurantPhone = "(801) 422-2663",
                WebsiteLink = "https://dining.byu.edu/creamery/",

            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Bombay House",
                Address = "463 N University Ave, Provo, UT 84601",
                RestaurantPhone = "(801) 373-6677",
                WebsiteLink = "https://bombayhouse.com/"

            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "J. Dawgs",
                Address = "858 700 E, Provo, UT 84606",
                RestaurantPhone = "(801) 373-3294",
                WebsiteLink = "https://jdawgs.com/"

            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Slab Pizza",
                Address = "671 E 800 N, Provo, UT 84606",
                RestaurantPhone = "(801) 377-3883",
                WebsiteLink = "https://slabpizza.com/"

            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "The Pendulum Court Café",
                Address = "1 Campus Dr, Provo, UT 84604",
                RestaurantPhone = "(801) 422-4636",

            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
