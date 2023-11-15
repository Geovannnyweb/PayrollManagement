

using Application.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Application.Services
{
    public class CounterServices : ICounterServices
    {
        private readonly DbEmployeeContext context;

        public CounterServices(DbEmployeeContext dbcontext) {
            context = dbcontext;
        }

        public IEnumerable<Counter> Get()
        {
            return context.Counters;
        }
        public void Save(Counter counter)
        {
            context.Add(counter);
            context.SaveChanges();
        }

        public void Update(Guid id, Counter counter)
        {
            var currentCounter = context.Counters.Find(id);

            if (currentCounter != null)
            {
                currentCounter.FullName = counter.FullName;
                currentCounter.Dni = counter.Dni;
                currentCounter.HoursWorked = counter.HoursWorked;
                currentCounter.HireDate = counter.HireDate;
                currentCounter.YearsOfExperiences = counter.YearsOfExperiences;

                context.Counters.Add(counter);
                context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            var currentCounter = context.Counters.Find(id);

            if(currentCounter != null)
            {
                context.Remove(currentCounter);
                context.SaveChanges();
            }
        }



 
    }
}
