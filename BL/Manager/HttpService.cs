using BL.DTOs.Country;
using BL.DTOs.Holiday;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL;

public class HttpService
{
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<ReadCountriesDTO> GetCountriesHttp()
	{
        var endpoint = new Uri("https://restcountries.com/v3.1/all");
        var result = _httpClient.GetAsync(endpoint).Result;
        string? jsonString = result.Content.ReadAsStringAsync().Result;
        var responseObject = JsonConvert.DeserializeObject<ReadCountriesDTO>(jsonString);

        return responseObject;
    }
    
    public async Task<ReadCalenderDTO> GetCalenderHttp()
	{
        var endpoint = new Uri("https://www.googleapis.com/calendar/v3/calendars/en.EG%23holiday%40group.v.calendar.google.com/events?key=AIzaSyBpSZoCr4xUGsNzmAuxVw_WT0Q4hVW9Bos");
        var result = _httpClient.GetAsync(endpoint).Result;
        string? jsonString = result.Content.ReadAsStringAsync().Result;
        var responseObject = JsonConvert.DeserializeObject<ReadCalenderDTO>(jsonString);

        return responseObject;
    }



}
