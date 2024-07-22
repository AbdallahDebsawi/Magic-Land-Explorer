using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MagicLandExplorer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string dataDirectory = Path.Combine(baseDirectory, "data");
            string jsonFilePath = Path.Combine(dataDirectory, "MagicLandData.json");

            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine($"{jsonFilePath} not found.");
                return;
            }

            string json = File.ReadAllText(jsonFilePath);

            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json, new JsonSerializerSettings
            {
                Converters = { new DurationConverter() } // Register the custom converter
            });

            // Delegate for handling user input
            Action<List<Category>>[] actions = new Action<List<Category>>[]
            {
                FilterDestinations.FilterDestinationsLessThan100,
                LongestDuration.FindLongestDurationDestination,
                SortByName.SortDestinationsByName,
                Top3Duration.FindTop3LongestDurationDestinations
            };

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Show destinations with duration less than 100 minutes");
                Console.WriteLine("2. Show destination with the longest duration");
                Console.WriteLine("3. Sort destinations by name");
                Console.WriteLine("4. Show top 3 longest-duration destinations");
                Console.WriteLine("5. Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                actions[choice - 1](categories);
            }
        }

        // Task 1: Destinations with duration less than 100 minutes
        static void FilterDestinationsLessThan100(List<Category> categories)
        {
            var filteredDestinations = categories
                .SelectMany(c => c.Destinations)
                .Where(d => d.Duration < 100)
                .Select(d => d.Name);

            Console.WriteLine("Destinations with duration less than 100 minutes:");
            foreach (var name in filteredDestinations)
            {
                Console.WriteLine(name);
            }
        }

        // Task 2: Destination with the longest duration
        static void FindLongestDurationDestination(List<Category> categories)
        {
            var longestDurationDestination = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .FirstOrDefault();

            Console.WriteLine($"Destination with the longest duration: {longestDurationDestination?.Name}");
        }

        // Task 3: Sort destinations alphabetically by name
        static void SortDestinationsByName(List<Category> categories)
        {
            var sortedDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name);

            Console.WriteLine("Destinations sorted alphabetically by name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine(destination.Name);
            }
        }

        // Task 4: Top 3 longest-duration destinations
        static void FindTop3LongestDurationDestinations(List<Category> categories)
        {
            var top3LongestDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderByDescending(d => d.Duration)
                .Take(3);

            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var destination in top3LongestDestinations)
            {
                Console.WriteLine($"{destination.Name} - {destination.Duration} minutes");
            }
        }
    }
    }

