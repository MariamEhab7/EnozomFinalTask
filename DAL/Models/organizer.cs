using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class organizer
{
    [Key]
    public string email { get; set; }
    public string displayName { get; set; }
    public bool self { get; set; }
}
