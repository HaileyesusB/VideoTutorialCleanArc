using Clean.Arc.Application.Interfaces;
using Clean.Arc.Application.Services;
using Clean.Arc.Domain.Interfaces;
using Clean.Arc.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Arc.Infra.IOC
{
    public class DependencyContainer
    {
        public static void  RegisterServices(IServiceCollection services) {
            //Application Layer
            services.AddScoped<ICourseService, CourseServices>();

            //Infrastructure Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }

}
