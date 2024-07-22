using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public static void SortDestinationsByName(List<Category> categories)
        {
            var sortedDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name)
                .ToList();

            Console.WriteLine("Destinations sorted alphabetically by name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine($"{destination.Name} - {destination.Duration} minutes");
            }
        }
    }
}
