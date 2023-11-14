

namespace Domain.Models
{
    public abstract class Employee
    {
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public int? Dni { get; set; }
        public DateTime HireDate { get; set; }
        

    }
}
