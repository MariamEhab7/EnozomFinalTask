using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class CountriesRepo : GenericRepo<Country>, ICountriesRepo
{
    #region Dependancy Injection
    private readonly CountryDbContext _context;
    public static int page;

    public CountriesRepo(CountryDbContext context) : base(context)
    {
        _context = context;
    }
    #endregion
    public async Task<ICollection<Country>> PagingCountries()
    {
        var listOfCountries = await _context.Countries.OrderBy(n => n.Name).Skip(page * 50).Take(50).ToListAsync();
        pageCounter();
        return listOfCountries;
    }

    #region Helper Method
    public void pageCounter()
    {
        Interlocked.Increment(ref page);
    }
    #endregion
    


}
