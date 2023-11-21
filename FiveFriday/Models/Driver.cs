using System.Collections.Generic;
using Newtonsoft.Json;

namespace FiveFriday.Models
{
    public class Driver
    {
        [JsonProperty("driverID")] public int DriverId { get; set; }

        [JsonProperty("surname")] public string Surname { get; set; }

        [JsonProperty("forename")] public string Forename { get; set; }

        [JsonProperty("vehicleRegistration")] public string VehicleRegistration { get; set; }

        [JsonProperty("traces")] public List<Trace> Traces { get; set; }
    }
}