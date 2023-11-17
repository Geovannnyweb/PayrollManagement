using Application.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces;

namespace Application.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IRepository<Developer> _developerRepository;

        public DeveloperService(IRepository<Developer> developerRepository)
        {
            _developerRepository = developerRepository;
        }

        public IEnumerable<Developer> Get()
        {
            return _developerRepository.GetAll();
        }

        public void Save(Developer developer)
        {
            _developerRepository.Save(developer);
        }

        public void Update(Guid id, Developer developer)
        {
           
            var currentDeveloper = _developerRepository.GetById(id);

            if (currentDeveloper != null)
            {
                currentDeveloper.FullName = developer.FullName;
                currentDeveloper.Dni = developer.Dni;
                currentDeveloper.HireDate = currentDeveloper.HireDate;
                currentDeveloper.HoursWorked = currentDeveloper.HoursWorked;
                currentDeveloper.RankDeveloper = currentDeveloper.RankDeveloper;

                _developerRepository.Update(currentDeveloper);
            }
        }

        public void Delete(Guid id)
        {
            _developerRepository.GetById(id);
            _developerRepository.Delete(id);

        }
    }
}
