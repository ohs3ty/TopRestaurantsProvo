using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurantsProvo.Models
{
    public static class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();
        public static IEnumerable<Suggestion> SuggestionResponses => suggestions;
        public static void AddApplication(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
