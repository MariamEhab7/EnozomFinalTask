using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class CountryDbContext : DbContext
{
	public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options)
	{

	}

	public DbSet<Country> Countries { get; set; }
    public DbSet<Holiday> Holidays { get; set; }

}
