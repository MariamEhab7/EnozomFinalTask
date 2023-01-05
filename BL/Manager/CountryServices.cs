using AutoMapper;
using BL.DTOs.Country;
using BL.DTOs.Holiday;
using DAL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BL;

public class CountryServices : ICountriesServices
{
    #region Dependancy Injection
    private readonly HttpService _httpService;
    private readonly CountryDbContext _context;
    private readonly IMapper _mapper;
    private readonly ICountriesRepo _countries;
    //public static int page;

    public CountryServices(HttpService httpService, CountryDbContext context, IMapper mapper
                        , ICountriesRepo countries)
    {
        _httpService = httpService;
        _context = context;
        _mapper = mapper;
        _countries = countries;
    }
    #endregion
    
    public async Task<ReadCountriesDTO> AllCountries()
    {
        var countries = await _httpService.GetCountriesHttp();
        return countries;
    }  
    
    public async Task<ReadCalenderDTO> AllHolidays()
    {
        var countries = await _httpService.GetCalenderHttp();
        return countries;
    }

    public async Task<bool> AddCountries()
    {
        try
        {
            var jsonObject = await AllCountries();
            var countriesList = jsonObject.data;
            var dbList = _mapper.Map<ICollection<Country>>(countriesList);
            await _context.Countries.AddRangeAsync(dbList);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            return false;
        }
    }
        
    public async Task<ICollection<ListCountriesDTO>> ListCountries()
    {
        var listOfCountries = _countries.PagingCountries();
        var result = _mapper.Map<ICollection<ListCountriesDTO>>(listOfCountries);
        return result;
    }

    //public async Task<Holiday> AddHolidayToCountry(string Countryid, AddHolidayDTO holiday)
    //{
    //    var country = _context.Countries.Find(Countryid); //got country
    //    var NewHoliday = _mapper.Map<Holiday>(holiday);

    //    country.holidays.Add(NewHoliday);

    //    _context.SaveChanges();

    //    return NewHoliday;

    //}

    //public async Task<Country> DeleteHolidayFromCountry(string CountryId, string HolidayId)
    //{
    //    var country = _context.Countries.Find(CountryId);

    //    var targetHoliday = _context.Holidays.Include(c => c.Countries.Where(h => h.Code == CountryId)).FirstOrDefault();

    //    _context.Holidays.Remove(targetHoliday);
    //    _context.SaveChanges();

    //    return country;
    //}

    //public async Task<Holiday> UpdateHoliday(UpdateHolidayDTO holiday, int id)
    //{
    //    var oldHoliday = await _holiday.GetById(id);
    //    var result = _mapper.Map(holiday, oldHoliday);
        
    //    _holiday.Update(result);
    //    _holiday.SaveChanges();
    //    return result;
    //}

}
