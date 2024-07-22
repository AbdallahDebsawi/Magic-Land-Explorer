using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        public static void FindTop3LongestDurationDestinations(List<Category> categories)
        {
            var top3LongestDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var destination in top3LongestDestinations)
            {
                Console.WriteLine($"{destination.Name} - {destination.Duration} minutes");
            }
        }
    }
}
