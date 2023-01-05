using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public interface ICountriesRepo:IGenericRepo<Country>
{
    Task<ICollection<Country>> PagingCountries();
}
