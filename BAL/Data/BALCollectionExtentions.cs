using BAL.Services;
using BAL.Services.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Data
{
    public static class BALCollectionExtentions
    {
        public static IServiceCollection AddBusinessLibraryCollection(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<IUserBalService, UserBalService>();
            services.AddScoped<IPlayerBalService, PlayerBalService>();

            return services;

        }
    }
}


