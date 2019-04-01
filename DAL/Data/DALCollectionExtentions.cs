using DAL.Services;
using DAL.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Snake.Services.Implementation;

namespace DAL.Data
{
    public static class DALCollectionExtentions
    {
        public static IServiceCollection AddDataLibraryCollection(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddEntityFrameworkNpgsql()
               .AddDbContext<ApplicationDbContext>(options =>
               options.UseNpgsql(
                   Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserDalService, UserDalService>();
            services.AddScoped<IPlayerDalService, PlayerDalService>();

            return services;
        }
    }
}
