using System.ComponentModel.DataAnnotations;

namespace DAL;

public class creator
{
    [Key]
    public string email { get; set; }
    public string displayName { get; set; }
    public bool self { get; set; }

}
