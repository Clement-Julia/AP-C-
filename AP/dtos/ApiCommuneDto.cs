using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AP.dtos
{
    public class ApiCommuneDto
    {
        public string nom { get; set; }

        public string code { get; set; }

        public List<string> codesPostaux { get; set; }

        public string codeRegion { get; set; }
    }
}
