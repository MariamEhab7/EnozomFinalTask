using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Holiday;

public class CalenderDTO
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
    public CreatorDTO creator { get; set; }
    public OrganizerDTO organizer { get; set; }
    public StartDTO start { get; set; }
    public EndDTO end { get; set; }
    public string transparency { get; set; }
    public string visibility { get; set; }
    public string iCalUID { get; set; }
    public int sequence { get; set; }
    public string eventType { get; set; }
}
