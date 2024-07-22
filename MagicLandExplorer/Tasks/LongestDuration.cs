using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public static void FindLongestDurationDestination(List<Category> categories)
        {
            var longestDurationDestination = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .FirstOrDefault();

            Console.WriteLine($"Destination with the longest duration: {longestDurationDestination?.Name}");
        }
    }
}
