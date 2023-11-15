

using Domain.Models;

namespace Application.Interfaces
{
     public interface IEmployeeService
    {
        IEnumerable<Employee> Get();
        void Save(Employee employee);
        void Update(Guid id, Employee employee);
        void Delete(Guid id);
    }
}
