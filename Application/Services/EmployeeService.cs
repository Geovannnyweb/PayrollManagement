using Application.Interfaces;
using Domain.Models;


namespace Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAll();
        }

        public void Save(Employee employee)
        {
            _employeeRepository.Save(employee);
        }

        public void Update(Guid id, Employee employee)
        {
            var currentEmployee = _employeeRepository.GetById(id);

            if (currentEmployee != null) {
                currentEmployee.Name = employee.Name;
                currentEmployee.Description = employee.Description;

                _employeeRepository.Update(currentEmployee);

            }
        }
        public void Delete(Guid id)
        {
               _employeeRepository.GetById(id);
                _employeeRepository.Delete(id);
               

        }
    }
}
