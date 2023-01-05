using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;

public class UpdateHolidayDTO
{
    public string kind { get; set; }
    public string etag { get; set; }
    public string id { get; set; }
    public string status { get; set; }
    public string htmlLink { get; set; }
    public string created { get; set; }
    public string updated { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
}
