using BL.DTOs.Country;
using BL.DTOs.Holiday;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;

public interface ICountriesServices
{
    Task<ReadCountriesDTO> AllCountries();
    Task<ReadCalenderDTO> AllHolidays();
    Task<bool> AddCountries();
    Task<ICollection<ListCountriesDTO>> ListCountries();

}
