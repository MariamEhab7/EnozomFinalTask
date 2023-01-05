using AutoMapper;
using BL.DTOs.Country;
using DAL;

namespace BL;

public class AutoMapperProfile : Profile
{
	public AutoMapperProfile()
	{
		CreateMap<CountriesDTO, Country>();
		CreateMap<ReadCountriesDTO, Country>();

		CreateMap<Country, ListCountriesDTO>();
	}
}
