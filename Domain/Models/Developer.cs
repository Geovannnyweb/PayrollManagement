using Domain.Enums;

namespace Domain.Models
{
    public class Developer 
    {

         public Guid DeveloperId { get; set; }
         public Guid EmployeeId { get; set; }
         public string? FullName { get; set; }
         public int? Dni {  get; set; }
        public DateTime HireDate { get; set; }
        public decimal? HoursWorked { get; set; }
        public RankDeveloper RankDeveloper { get; set; }
         public virtual Employee? Employees { get; set; }

}
}
