using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Holiday;

public class ReadCalenderDTO
{
    public string kind { get; set; }
    public string etag { get; set; }
    public string summary { get; set; }
    public string updated { get; set; }
    public string timeZone { get; set; }
    public string accessRole { get; set; }
    public List<string> defaultReminders { get; set; }
    public string nextSyncToken { get; set; }

    public IList<CalenderDTO> items { get; set; }

}
