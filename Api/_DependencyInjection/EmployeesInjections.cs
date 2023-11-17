using Application.Interfaces;
using Application.Services;
using Domain.Models;
using Infrastructure.Context;
using Infrastructure.Interfaces;

namespace Api._DependencyInjection
{
    public static class EmployeesInjections
    {
        public static void InjectEmployees(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IDeveloperService, DeveloperService>();
            builder.Services.AddScoped<ICounterServices, CounterServices>();
            builder.Services.AddScoped<IRepository<Employee>, EmployeeRepository<Employee>>();
            builder.Services.AddScoped<IRepository<Counter>, EmployeeRepository<Counter>>();
            builder.Services.AddScoped<IRepository<Developer>, EmployeeRepository<Developer>>();


        }


    }
}
