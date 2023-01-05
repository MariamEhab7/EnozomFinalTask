using BL.DTOs.Holiday;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Country;

public class CountriesDTO
{

    [JsonProperty("country")]
    public string Name { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("iso3")]
    public string Iso3 { get; set; }
}
