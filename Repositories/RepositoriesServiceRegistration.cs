using Core.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Abstacts;
using Repositories.Concretes;
using Repositories.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class RepositoriesServiceRegistration
    {
        public static IServiceCollection AddRepositoriesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("EfConfiguration")));

            services.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(s => s.ServiceType.Name.EndsWith("Repository"));

            return services;
        }
    }
}
