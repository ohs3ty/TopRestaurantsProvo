using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurantsProvo.Models
{
    public class Suggestion
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's ALL good";

        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Invalid Phone number")]
        public string RestaurantPhone { get; set; }
    }
}
