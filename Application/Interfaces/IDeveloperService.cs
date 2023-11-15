

using Domain.Models;

namespace Application.Interfaces
{
    public interface IDeveloperService
    {
        IEnumerable<Developer> Get();
        void Save(Developer developer);
        void Update(Guid id, Developer developer);
        void Delete(Guid id);

    }
}
