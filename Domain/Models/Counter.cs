

namespace Domain.Models
{



    public class Counter 
    {
        
        public Guid CounterId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public int? Dni { get; set; }
        public DateTime HireDate { get; set; }
        public decimal? HoursWorked { get; set; }
        public int? YearsOfExperiences { get; set; }
        public virtual Employee? Employees { get; set; }


     }
}
