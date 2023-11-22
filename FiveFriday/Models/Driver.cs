using System;
using System.Collections.Generic;
using System.Linq;
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

        public string FullName => Forename + " " + Surname;

        public int TimeSpentOnActivities
        {
            get
            {
                // In an actual application these dates would obviously come from a date range picker of some kind
                var startDate = DateTime.Parse("2021/02/01");
                var endDate = DateTime.Parse("2021/02/07");

                var duration = 0;
                foreach (var trace in Traces)
                {
                    var date = DateTime.Parse(trace.Date);
                    if (date >= startDate && date <= endDate)
                    {
                        duration += trace.Activity.Sum(activity => activity.Duration);
                    }
                }

                return duration;
            }
        }
    }
}