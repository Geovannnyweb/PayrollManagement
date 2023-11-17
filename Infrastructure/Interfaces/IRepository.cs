
namespace Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Save(T entity);
        void Update(T entity);
        void Delete(Guid id);

    }
}