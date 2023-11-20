using Application.Interfaces;

namespace Infrastructure.Context
{
    public class EmployeeRepository<T> : IRepository<T> where T : class
    {



        private readonly DbEmployeeContext _dbEmployeeContext;

        public EmployeeRepository(DbEmployeeContext dbEmployeeContext)
        {
            _dbEmployeeContext = dbEmployeeContext;
        }

        public void Delete(Guid id)
        {
            var currentEntity = _dbEmployeeContext.Set<T>().Find(id);
            _dbEmployeeContext.Remove(currentEntity);
            _dbEmployeeContext.SaveChanges();
            
        }

        public IEnumerable<T> GetAll()
        {
            return _dbEmployeeContext.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _dbEmployeeContext.Set<T>().Find(id);
           
        }

        public void Save(T entity)
        {
            _dbEmployeeContext.Add(entity);
            _dbEmployeeContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbEmployeeContext.Update(entity);
            _dbEmployeeContext.SaveChanges();

        }
    }
}
