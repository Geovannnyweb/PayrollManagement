

using Application.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class CounterServices : ICounterServices
    {
        private readonly IRepository<Counter> _counterRepository;

        public CounterServices(IRepository<Counter> counterRepository) {
         
            _counterRepository = counterRepository;
        }

        public IEnumerable<Counter> Get()
        {
            return _counterRepository.GetAll();
        }
        public void Save(Counter counter)
        {
            _counterRepository.Save(counter);
        }

        public void Update(Guid id, Counter counter)
        {
            var currentCounter = _counterRepository.GetById(id);

            if (currentCounter != null)
            {
                currentCounter.FullName = counter.FullName;
                currentCounter.Dni = counter.Dni;
                currentCounter.HoursWorked = counter.HoursWorked;
                currentCounter.HireDate = counter.HireDate;
                currentCounter.YearsOfExperiences = counter.YearsOfExperiences;

                _counterRepository.Update(currentCounter);
            }

        }

        public void Delete(Guid id)
        {
            _counterRepository.GetById(id);
            _counterRepository.Delete(id);
        }



 
    }
}
