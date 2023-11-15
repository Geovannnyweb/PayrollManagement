using Application.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Application.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly DbEmployeeContext context;

        public DeveloperService(DbEmployeeContext dbcontext)
        {
            context = dbcontext;
        }

        public IEnumerable<Developer> Get()
        {
            return context.Developers;
        }

        public void Save(Developer developer)
        {
            context.Add(developer);
            context.SaveChanges();
        }

        public void Update(Guid id, Developer developer)
        {
            var currentDeveloper = context.Developers.Find(id);

            if (currentDeveloper != null)
            {
                currentDeveloper.FullName = developer.FullName;
                currentDeveloper.Dni = developer.Dni;
                currentDeveloper.HireDate = currentDeveloper.HireDate;
                currentDeveloper.HoursWorked = currentDeveloper.HoursWorked;
                currentDeveloper.RankDeveloper = currentDeveloper.RankDeveloper;
                
                context.Developers.Update(currentDeveloper);
                context.SaveChanges();
            }


        }

        public void Delete(Guid id)
        {
            var currentDeveloper = context.Developers.Find(id);

            if (currentDeveloper != null)
            {
                context.Remove(currentDeveloper);
                context.SaveChanges();

            }

        }
    }
}
