using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }

        [JsonConverter(typeof(DurationConverter))]
        public int Duration { get; set; }

        public string Description { get; set; }
        public string ShowTime { get; set; } // Optional for Enchanted Tiki Room
    }
    public class DurationConverter : JsonConverter<int>
    {
        public override int ReadJson(JsonReader reader, Type objectType, int existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string durationString = (string)reader.Value;
            if (durationString.EndsWith(" minutes"))
            {
                durationString = durationString.Replace(" minutes", "").Trim();
            }
            return int.Parse(durationString);
        }

        public override void WriteJson(JsonWriter writer, int value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
