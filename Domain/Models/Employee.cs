using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public Guid AreaId { get; set; }
        public string? FullName { get; set; }
        public int? Dni { get; set; }
        public DateTime HireDate { get; set; }
        public RanksEmployee? RanksEmployee { get; set; } 
        public decimal Salary { get; set; }
        public virtual Area? Areas { get; set; }

    }
}
