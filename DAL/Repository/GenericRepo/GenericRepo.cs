using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class GenericRepo<Entity> : IGenericRepo<Entity> where Entity : class
{
    private readonly CountryDbContext _context;

    public GenericRepo(CountryDbContext context)
    {
        _context = context;
    }
    public void Add(Entity entity)
    {
         _context.Add(entity);
    }

    public async Task <Entity> GetById(int id)
    {
        return await _context.Set<Entity>().FindAsync(id);
    }

    public void DeleteById(int id)
    {
        var entity = GetById(id);
        _context.Remove(entity);
    }

    public async Task<ICollection<Entity>> GetAll()
    {
        var entities = await _context.Set<Entity>().ToListAsync();
        return entities;
    }

    public void AddList(ICollection<Entity> t)
    {
        _context.Set<Entity>().AddRange(t);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
    public void Update(Entity t)
    {
    }
}
