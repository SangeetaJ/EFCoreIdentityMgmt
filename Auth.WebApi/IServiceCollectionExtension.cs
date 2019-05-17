using AutoMapper;
using EFCore.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Auth.WebApi
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IUserDataService, UserDataService>();
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile()); mc.CreateMissingTypeMaps = true;
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
