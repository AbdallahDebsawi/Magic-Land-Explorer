using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static void FilterDestinationsLessThan100(List<Category> categories)
        {
            var filteredDestinations = categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Duration < 100)
                .Select(d => d.Name)
                .ToList();

            Console.WriteLine("Destinations with duration less than 100 minutes:");
            foreach (var name in filteredDestinations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
