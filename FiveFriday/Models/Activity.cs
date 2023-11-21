using Newtonsoft.Json;

namespace FiveFriday.Models
{
    public class Activity
    {
        [JsonProperty("startTime")] public string StartTime { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("duration")] public int Duration { get; set; }
    }
}