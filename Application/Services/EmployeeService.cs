using Application.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DbEmployeeContext context;

        public EmployeeService(DbEmployeeContext dbcontext)
        {
            context = dbcontext;
        }

        public IEnumerable<Employee> Get()
        {
            return context.Employees;
        }

        public void Save(Employee employee)
        {
            context.Add(employee);
            context.SaveChanges();
        }

        public void Update(Guid id, Employee employee)
        {
            var currentEmployee = context.Employees.Find(id);

            if (currentEmployee != null) {
                currentEmployee.Name = employee.Name;
                currentEmployee.Description = employee.Description;

                context.Employees.Update(currentEmployee);
                context.SaveChanges();
            }
        }
        public void Delete(Guid id)
        {
            var currentEmployee = context.Employees.Find(id);

            if (currentEmployee != null)
            {
                context.Remove(currentEmployee);
                context.SaveChanges();
            }
        }
    }
}
