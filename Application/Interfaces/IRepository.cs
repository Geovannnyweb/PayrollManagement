

namespace Application.Interfaces
{
    public interface IRepository<T>
    {
        void Get(Guid id);
        void Save(T entity);
        void Update(Guid id, T entity);
        void Delete(Guid id);
    

    }
}
