using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailistSimulation.Models
{
    public class FailistObject
    {
        //[JsonProperty("ID_PLANES")]
        public IdPlane[] IdPlanes { get; set; }

        //[JsonProperty("TYPE_PLANE")]
        public TypePlane[] TypePlane { get; set; }

        //[JsonProperty("ID_FAILURE_X")]
        public IdFailureX[] IdFailureX { get; set; }

        //[JsonProperty("ID_COMPONENT_FAILURE_X")]
        public IdComponentFailureX[] IdComponentFailureX { get; set; }
    }
}
