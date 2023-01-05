using BL;
using BL.DTOs.Holiday;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace CountriesHolidays.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        #region Dependancy Injection
        private readonly ICountriesServices _countriesServices;

        public CountryController(ICountriesServices countriesServices)
        {
            _countriesServices = countriesServices;
        }
        #endregion
     

        [HttpGet]
        [Route("GetAllCountries")]
        public async Task<IActionResult> GetCountries()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _countriesServices.AllCountries();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddAllCountries")]
        public async Task<IActionResult> AddAllCountries()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _countriesServices.AddCountries();
            return Ok(result);
        }

        [HttpGet]
        [Route("PagingCountries")]
        public async Task<IActionResult> ListOfCountries()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _countriesServices.ListCountries();
            return Ok(result);
        }


    }
}
