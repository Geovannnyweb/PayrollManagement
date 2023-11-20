using Application.Interfaces;
using Application.Services;


namespace Api._DependencyInjection
{
    public static class EmployeesInjections
    {
        public static void InjectEmployees(this WebApplicationBuilder builder)
        {

            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IDeveloperService, DeveloperService>();
            builder.Services.AddScoped<ICounterServices, CounterServices>();
            


        }


    }
}
