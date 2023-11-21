using System.Collections.Generic;
using Newtonsoft.Json;

namespace FiveFriday.Models
{
    public class Trace
    {
        [JsonProperty("date")] public string Date { get; set; }

        [JsonProperty("activity")] public List<Activity> Activity { get; set; }
    }
}