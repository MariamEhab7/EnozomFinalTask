
using AutoMapper;
using BL.DTOs.Holiday;
using DAL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BL;

public class HolidayServices : IHolidayServices
{
    #region Dependancy Injection
    private readonly CountryDbContext _context;
    private readonly IMapper _mapper;
    private readonly IHolidayRepo _holiday;

    public HolidayServices(CountryDbContext context, IMapper mapper, IHolidayRepo holiday)
    {
        _context = context;
        _mapper = mapper;
        _holiday = holiday;
    }
    #endregion

    public async Task<Holiday> AddHolidayToCountry(string Countryid, AddHolidayDTO holiday)
    {
        var country = _context.Countries.Find(Countryid);
        var NewHoliday = _mapper.Map<Holiday>(holiday);

        country.holidays.Add(NewHoliday);

        _context.SaveChanges();

        return NewHoliday;

    }

    public async Task<Country> DeleteHolidayFromCountry(string CountryId, string HolidayId)
    {
        var country = _context.Countries.Find(CountryId);

        var targetHoliday = _context.Holidays.Include(c => c.Countries.Where(h => h.Code == CountryId)).FirstOrDefault();

        _context.Holidays.Remove(targetHoliday);
        _context.SaveChanges();

        return country;
    }

    public async Task<Holiday> UpdateHoliday(UpdateHolidayDTO holiday, int id)
    {
        var oldHoliday = await _holiday.GetById(id);
        var result = _mapper.Map(holiday, oldHoliday);

        _holiday.Update(result);
        _holiday.SaveChanges();
        return result;
    }
}
