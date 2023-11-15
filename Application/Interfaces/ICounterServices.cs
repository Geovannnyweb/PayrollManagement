

using Domain.Models;

namespace Application.Interfaces
{
    public interface ICounterServices
    {
        IEnumerable<Counter> Get();
        void Save(Counter counter);
        void Update(Guid id, Counter counter);
        void Delete(Guid id);

    }
}
