
using System.ComponentModel.DataAnnotations;

namespace DAL;

public class Country
{
    public Country()
    {
        this.holidays = new HashSet<Holiday>();
    }
    public string? Name { get; set; }
    [Key]
    public string? Code { get; set; }
    public string? Iso3 { get; set; }


    public ICollection<Holiday> holidays { get; set; }


}
