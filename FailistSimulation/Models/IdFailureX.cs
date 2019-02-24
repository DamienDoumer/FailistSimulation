using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FailistSimulation.Models
{
    public class IdFailureX
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("Failure type")]
        public string FailureType { get; set; }
    }
}
