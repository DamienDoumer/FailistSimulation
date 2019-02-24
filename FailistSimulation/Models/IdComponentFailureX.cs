using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FailistSimulation.Models
{
    public class IdComponentFailureX
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("Component")]
        public string Component { get; set; }
    }
}
