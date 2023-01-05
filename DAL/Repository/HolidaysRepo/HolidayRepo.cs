using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class HolidayRepo : GenericRepo<Holiday>, IHolidayRepo
{
    #region Dependancy Injection
    private readonly CountryDbContext _context;
    public HolidayRepo(CountryDbContext context) : base(context)
    {
        _context = context;
    }

    #endregion


}
