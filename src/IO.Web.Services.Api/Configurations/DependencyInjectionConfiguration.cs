﻿using IO.Infra.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace IO.Web.Services.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
