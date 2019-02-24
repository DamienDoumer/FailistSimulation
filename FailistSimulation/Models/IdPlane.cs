using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FailistSimulation.Models
{
    public class IdPlane
    {
        [JsonProperty("Country or region", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryOrRegion { get; set; }

        [JsonProperty("Registration prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationPrefix { get; set; }

        [JsonProperty("Presentation and notes", NullValueHandling = NullValueHandling.Ignore)]
        public string PresentationAndNotes { get; set; }

        public override string ToString()
        {
            return $"{CountryOrRegion} {RegistrationPrefix} {PresentationAndNotes}";
        }
    }
}
