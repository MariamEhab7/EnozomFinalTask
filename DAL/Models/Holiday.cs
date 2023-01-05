using System.ComponentModel.DataAnnotations;

namespace DAL;

public class Holiday
{
    public Holiday()
    {
        this.Countries = new HashSet<Country>();
    }
    public string kind { get; set; }

    [Key]
    public string etag { get; set; }
    public string id { get; set; }
    public string status { get; set; }
    public string htmlLink { get; set; }
    public string created { get; set; }
    public string updated { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public creator creator { get; set; }
    public organizer organizer { get; set; }
    public String start { get; set; }
    public String end { get; set; }
    public string transparency { get; set; }
    public string visibility { get; set; }
    public string iCalUID { get; set; }
    public int sequence { get; set; }
    public string eventType { get; set; }

    public ICollection<Country> Countries { get; set; }

}
