
using Domain.Enums;
using System.Text.Json.Serialization;

namespace Domain.Models
{ 

    public class Manager 
    {
        public Guid ManagerId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public int? Dni { get; set; }
        public DepartamentManager DepartamentManager { get; set; }
        public bool HasManagementWorkTeam { get; set; }

        [JsonIgnore]
        public virtual Employee? Employees { get; set; }

    }
}