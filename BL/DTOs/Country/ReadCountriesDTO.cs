using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Country;

public class ReadCountriesDTO
{
    public bool error { get; set; }
    public string msg { get; set; }

    public IList<CountriesDTO> data { get; set; }

}
