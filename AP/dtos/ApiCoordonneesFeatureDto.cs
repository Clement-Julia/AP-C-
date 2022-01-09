using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.dtos
{
    public class ApiCoordonneesFeatureDto
    {
        public ApiCoordonneesGeometryDto geometry { get; set; }
        public ApiCoordonneesPropertiesDto properties { get; set; }
    }
}
