using BL.DTOs.Holiday;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountriesHolidays.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {

        #region Dependancy Injection
        private readonly ICountriesServices _countriesServices;
        private readonly IHolidayServices _holidayServices;

        public HolidayController(ICountriesServices countriesServices, IHolidayServices holidayServices)
        {
            _countriesServices = countriesServices;
            _holidayServices = holidayServices;
        }
        #endregion

        [HttpGet]
        [Route("GetAllHolidays")]
        public async Task<IActionResult> GetHolidays()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _countriesServices.AllHolidays();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddHolidayToCountry")]
        public async Task<IActionResult> AddHoliday(string CountryId, AddHolidayDTO holiday)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _holidayServices.AddHolidayToCountry(CountryId, holiday);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteHolidayFromCountry")]
        public async Task<IActionResult> DeleteHoliday(string CountryId, string HolidayId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _holidayServices.DeleteHolidayFromCountry(CountryId, HolidayId);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateHoliday")]
        public async Task<IActionResult> UpdatingHoliday(UpdateHolidayDTO holiday, int HolidayId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _holidayServices.UpdateHoliday(holiday, HolidayId);
            return Ok(result);
        }

    }
}
