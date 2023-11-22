using System.Collections.Generic;
using Newtonsoft.Json;

namespace FiveFriday.Models
{
    public class Data
    {
        [JsonProperty("data")] public List<Driver> Drivers { get; set; }
    }
}