using Infrastructure.Context;
using Domain.Models;
using Application.Interfaces;

namespace Api._DependencyInjection
{
    public static class ServicesInjections
    {
        public static void InjectServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSqlServer<DbEmployeeContext>(builder.Configuration.
            GetConnectionString("cnEmployee"));
            builder.Services.AddScoped<IRepository<Employee>, EmployeeRepository<Employee>>();
            builder.Services.AddScoped<IRepository<Counter>, EmployeeRepository<Counter>>();
            builder.Services.AddScoped<IRepository<Developer>, EmployeeRepository<Developer>>();
        }
    }
}
