
namespace Api._DependencyInjection
{
    public static class DependencyInjections
    {
        public static void Inject(this WebApplicationBuilder builder)
        {
            EmployeesInjections.InjectEmployees(builder);
            ServicesInjections.InjectServices(builder);
        }
    }
}
