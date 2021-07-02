using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using School.BusinessLogic;
using School.BusinessLogic.Interfaces;
using School.Services;
using School.Services.Interfaces;

namespace School.DependencyInjection
{
    public static class DIAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentBusinessLogic, StudentBusinessLogic>();
            services.AddScoped<IStudentServices, StudentServices>();
        }
    }
}
