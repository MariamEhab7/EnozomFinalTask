namespace DAL;

public interface IGenericRepo<Entity> where Entity : class
{
    Task<ICollection<Entity>> GetAll();
    Task<Entity> GetById(int id);
    void Add(Entity t);
    void AddList(ICollection<Entity> t);
    void DeleteById(int id);
    void Update(Entity t);
    void SaveChanges();

}
