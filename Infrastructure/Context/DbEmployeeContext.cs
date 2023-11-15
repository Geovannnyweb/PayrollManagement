using Domain.Enums;
using Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Context
{
    public class DbEmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Developer> Developers { get; set; }

        public DbEmployeeContext(DbContextOptions<DbEmployeeContext> options) :base
        (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Employee> employeesInit  = new List<Employee>();
            employeesInit.Add(new Employee() { EmployeeId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                Name = "OpiTech" });

            employeesInit.Add(new Employee() { EmployeeId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                Name = "Tour Colombia" });


            modelBuilder.Entity<Employee>(employee =>
            {
                employee.ToTable("Employees");
                employee.HasKey(p => p.EmployeeId);
                employee.Property(p => p.Name).IsRequired().HasMaxLength(120);
                employee.Property(p => p.Description).IsRequired(false);
                employee.HasData(employeesInit);

            });


            List<Counter> counterInit = new List<Counter>();
            counterInit.Add(new Counter() { CounterId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                EmployeeId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                FullName = "Geovanny Camargo", 
                Dni = int.Parse("10010020022"),
                HireDate = new DateTime(2022, 1, 1),
                HoursWorked = decimal.Parse("120.09"),
                YearsOfExperiences = int.Parse("3"),
             });

            modelBuilder.Entity<Counter>(counter =>
            {
                counter.ToTable("Counters");
                counter.HasKey(p => p.CounterId);
                counter.HasOne(p => p.Employees).WithMany(p => p.Counter).
                HasForeignKey(p => p.EmployeeId);
                counter.Property(p => p.FullName).IsRequired().HasMaxLength(120);
                counter.Property(p => p.Dni).IsRequired().HasMaxLength(30);
                counter.Property(p => p.HireDate).IsRequired();
                counter.Property(p => p.HoursWorked).IsRequired();
                counter.Property(p => p.YearsOfExperiences).IsRequired();
                counter.HasData(counterInit);
            });


            List<Developer> developerInit = new List<Developer>();
            developerInit.Add(new Developer() { DeveloperId = Guid.Parse("ce2de404-c22e-4c90-ac52-de0640dfb290"),
                EmployeeId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                FullName = "Luis Almanza",
                Dni = int.Parse("2002000999"),
                HireDate = new DateTime(2023, 1, 1),
                HoursWorked = decimal.Parse("121.03"),
                RankDeveloper = RankDeveloper.Junior,
            });

            modelBuilder.Entity<Developer>(developer =>
            {
                developer.ToTable("Developers");
                developer.HasKey(p => p.DeveloperId);
                developer.HasOne(p => p.Employees).WithMany(p => p.Developer).
                HasForeignKey(p => p.EmployeeId);
                developer.Property(p => p.FullName).IsRequired().HasMaxLength(120);
                developer.Property(p => p.Dni).IsRequired().HasMaxLength(30);
                developer.Property(p => p.HireDate).IsRequired();
                developer.Property(p => p.HoursWorked).IsRequired();
                developer.Property(p => p.RankDeveloper);
                developer.HasData(developerInit);

            });


        }

    }
}
