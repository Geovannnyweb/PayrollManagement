
using Domain.Enums;

namespace Domain.Models;

    public class Manager : Employee
    {
        public DepartamentManager DepartamentManager { get; set; }
        public bool HasManagementWorkTeam { get; set; }
    }
